﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Bll_Print
    {
        public Model.GeneralReturns Print(Model.M_Print.Request S)
        {
            Model.GeneralReturns genRet = new Model.GeneralReturns();

            if (!string.IsNullOrEmpty(S.repair))
            {
                return SupplementPrint(genRet,S);
            }

            if (String.IsNullOrEmpty(S.operateMan) || String.IsNullOrEmpty(S.operateSite) || null == S.PackaginBillcode || S.PackaginBillcode.Count == 0)
            {
                genRet.MsgText = "参数不全，请核实";

            }
            else
            {
                List<Model.M_Print.Return> reqList = new List<Model.M_Print.Return>();
                EJETable.pmw_order orderInfo = new DAL.Dal_Print().getOrderInfo(long.Parse(S.orderID));
                int subcontractCount = orderInfo.subpackageNum < 1||orderInfo.subpackageNum==null ? 1 : int.Parse(orderInfo.subpackageNum.ToString());

                for (int i = 1; i <= subcontractCount; i++)
                {
                    orderInfo = i == 1 ? orderInfo : new DAL.Dal_Print().getSubOrderInfo(S.orderID + "-" + i);
                    if (orderInfo == null)
                    {
                        genRet.MsgText = "无法获取订单信息";
                    }
                    else
                    {

                        List<string> billcodeList = new List<string>();
                        foreach (var billcode in S.PackaginBillcode)
                        {
                            billcodeList.Add(i == 1 ? billcode.billcode : billcode.billcode + "-" + i);
                        }

                        string message = string.Empty;//错误消息
                        StringBuilder strBuiGoodsCode = new StringBuilder();//货物类型代码
                        StringBuilder strBuiGoodsType = new StringBuilder();//货物类型
                        StringBuilder strBuiGoodsName = new StringBuilder();//货物名称
                        double billcodeWeight = 0;

                        if (!IsPackage(orderInfo.order_code, i, billcodeList, ref message, ref strBuiGoodsType, ref strBuiGoodsName, ref billcodeWeight))
                        {
                            genRet.MsgText = message;
                            return genRet;
                        }


                        EJETable.GoodsCatalog goodsInfo = new DAL.Dal_Print().getGoodsTypeInfo(strBuiGoodsType.ToString());
                        if (goodsInfo == null)
                        {
                            genRet.MsgText = "无法获取货物类型";
                            return genRet;
                        }

                        strBuiGoodsCode.Append(goodsInfo.briefCode);
                        EJETable.pmw_member memberInfo = new DAL.Dal_Print().getMemberInfo(orderInfo.member_id);
                        if (memberInfo == null)
                        {
                            genRet.MsgText = "无法获取会员信息";
                            return genRet;
                        }

                        EJETable.TaoBaoInfo shopInfo = new DAL.Dal_Print().getShopInfo(memberInfo.astro);
                        if (shopInfo == null)
                        {
                            genRet.MsgText = "无法获取店铺信息";
                            return genRet;
                        }

                        EJETable.pmw_house houseInfo = new DAL.Dal_Print().getHouseInfo(long.Parse(S.operateSite));
                        if (houseInfo == null)
                        {
                            genRet.MsgText = "无法获取仓库信息";
                            return genRet;
                        }
                        EJETable.pmw_timeBar flightInfo = new DAL.Dal_Print().getFlightTime(orderInfo.timeBarID);
                        if (flightInfo == null)
                        {
                            genRet.MsgText = "无法获取航班时效信息";
                            return genRet;
                        }


                        if (orderInfo.agencyFund <= 0 && orderInfo.pay_type != 1 && S.express.Contains("黑猫") && !S.express.Contains("不代收"))
                        {
                            S.express = S.express + "不代收";
                        }
                        else if (S.express.Contains("黑猫") && !S.express.Contains("代收"))
                        {
                            S.express = S.express + "代收";
                        }
                        EJETable.PrintConfig printConfigInfo = new DAL.Dal_Print()
                        .getPrinConfig(S.express);
                        if (printConfigInfo == null)
                        {
                            genRet.MsgText = "无法获取打印配置信息";
                            return genRet;
                        }

                        EJETable.Forwarder forwarderInfo = new DAL.Dal_Print().getForwarderCode(S.express, printConfigInfo.pjCode);
                        if (forwarderInfo == null)
                        {
                            genRet.MsgText = "无法获取派件公司信息";
                            return genRet;
                        }

                        SqlSugar.DbResult<string> printNo = new DAL.Dal_Print().getPrintNo(forwarderInfo.id);
                        if (!printNo.IsSuccess)
                        {
                            genRet.MsgText = printNo.Messaage;
                            return genRet;
                        }

                        if (new DAL.Dal_Print().getForwardingAgentNoCount(forwarderInfo.id) < 2001)
                        {
                            var SentState1 = FastSocket.MaeesgeSend(new MassgeClass()
                            {
                                IsSite = true,
                                Mags = S.express,
                                MagsID = "0",
                                Mags_Type = "HmOrderCount",
                                SiteOrUser = new string[] { "客服" }
                            }, false);
                        }
                   
                          string recipients = new DAL.Dal_Print().getRecipientName(orderInfo.cname, orderInfo.id);
                        var dbPrint = new DAL.Dal_Print().Print(orderInfo, string.IsNullOrEmpty(orderInfo.sent_kd_billcode) ? printNo.Data : orderInfo.sent_kd_billcode + "," + printNo.Data, S.express.Contains("黑猫") ? "黑猫宅急便" : S.express, recipients, houseInfo, shopInfo, forwarderInfo, billcodeList.ToArray(), strBuiGoodsName.ToString(), S, printNo.Data, billcodeWeight);
                        if (!dbPrint.IsSuccess)
                        {
                            genRet.MsgText = dbPrint.Messaage;
                            return genRet;
                        }

                        if (orderInfo.is_Transfe == 1)
                        {
                            new DAL.Dal_Print().transfer(shopInfo.Name, orderInfo.transfe_house, printNo.Data, orderInfo.transfe_emp, houseInfo.house_name, billcodeWeight);
                        }
                      
                        string SignerCode=string.Empty, VersionCode=string.Empty,   addressCode=string.Empty;
                        PushDataEjs(recipients, S.express, billcodeWeight, strBuiGoodsName.ToString(), printNo.Data, houseInfo.house_name, orderInfo, houseInfo, memberInfo, ref SignerCode, ref VersionCode, ref addressCode, ref message);
                        string ssss = string.Join(",", billcodeList.ToArray());
                        reqList.Add(new Model.M_Print.Return
                        {
                            WaybillNo = printNo.Data,
                            billcode = string.Join(",", billcodeList.ToArray()),
                            employee = S.operateMan,
                            Js_number = billcodeList.Count,
                            briefCode = strBuiGoodsCode.ToString(),
                            goodsType = strBuiGoodsType.ToString(),
                            shopName = shopInfo.Name,
                            OrderGoodsNotes = orderInfo.OrderGoodsNotes,
                            CusCode = forwarderInfo.ForwarderCode,
                            timeBarName = flightInfo.timeBarName,
                            orderID = orderInfo.id.ToString(),
                            z_weight = billcodeWeight.ToString(),
                            address = orderInfo.address,
                            Phone = orderInfo.mobile,
                            recipients = recipients,
                            IdentificationGoods = strBuiGoodsType.ToString().Contains("特") ? "T" : "",
                            ds_mdgj_Free = orderInfo.pay_type == 1 ? Math.Round(Convert.ToDecimal(orderInfo.agencyFund + orderInfo.country_free), 2).ToString() : "0",
                            DFFeer = orderInfo.pay_type == 1 ? Math.Round(Convert.ToDecimal(orderInfo.agencyFund + orderInfo.country_free), 2).ToString() : orderInfo.agencyFund.ToString(),
                            addressCode=addressCode,
                            goodsName=strBuiGoodsName.ToString(),
                            SignerCode=SignerCode,
                            VersionCode=VersionCode
                        });
                        genRet.State = true;
                        genRet.Mb = S.express.Replace("代收", "").Replace("不", "");
                        genRet.MsgText = S.operateMan;
                    }

                }
                genRet.ReturnJson = Common.DataHandling.ObjToStr(reqList);
              
                
            }
           

            return genRet;
        }
        /// <summary>
        /// 是否能打包
        /// </summary>
        /// <param name="order_code"></param>
        /// <param name="i"></param>
        /// <param name="ReqList"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool IsPackage(string order_code, int i, List<string> billCodeList, ref string message, ref StringBuilder strBuiGoodsType, ref StringBuilder strBuiGoodsName, ref double weight)
        {
            if (billCodeList.Count < 1)
            {
                message = "请输入单号";
                return false;
            }



            bool boo = false;

            List<EJETable.pmw_billcode> billcodeInfo = new DAL.Dal_Print().getBillcodeInfo(billCodeList);
            foreach (var billcode in billcodeInfo)
            {
                if (billcodeInfo != null && order_code == billcode.order_code)
                {
                    if (billcode.is_packed == 1 || !string.IsNullOrEmpty(billcode.packed_billcode))
                    {
                        message = "快递单号【" + billcode.kd_billcode + "】已打包";
                        boo = false;
                        break;
                    }
                    else
                    {

                        strBuiGoodsName.Append(strBuiGoodsName.Length < 1 ? billcode.goods.Trim() : "," + billcode.goods.Trim());

                        strBuiGoodsType.Append(strBuiGoodsType.Length < 1 ? billcode.goodsTyep : strBuiGoodsType.ToString().Contains(billcode.goodsTyep) ? string.Empty : "," + billcode.goodsTyep);
                        weight += (double)billcode.dd_weight;
                        boo = true;
                    }

                }
                else
                {
                    message = "该快递单号不是该订单货物";
                    boo = false;
                    break;
                }
            }

            return boo;



        }


        /// <summary>
        /// 补打运单
        /// </summary>
        /// <param name="gr"></param>
        /// <param name="S"></param>
        /// <returns></returns>
        private Model.GeneralReturns SupplementPrint( Model.GeneralReturns gr, Model.M_Print.Request S)
        {
            if (String.IsNullOrEmpty(S.operateMan) || String.IsNullOrEmpty(S.operateSite))
            {
                gr.MsgText = "缺少操作人或站点";
                gr.State = false;
                return gr;
            }

            EJETable.pmw_billcode billcodeInfo = new DAL.Dal_Print().SupplementGetBillCodeInfo(S.repair);
            if (billcodeInfo == null)
            {
                gr.MsgText = "无法获取快递单信息";
                return gr;
            }
            List<Model.M_Print.Return> reqList = new List<Model.M_Print.Return>();
            EJETable.pmw_order orderInfo = new DAL.Dal_Print().SupplementGetOrderInfo(billcodeInfo.order_code);
            if (orderInfo == null)
            {
                gr.MsgText = "无法获取订单信息";
                return gr;
            }
            EJETable.CFHMPring pringInfo = new DAL.Dal_Print().SupplementGetPrintInfo(billcodeInfo.packed_billcode);
            if (orderInfo == null)
            {
                gr.MsgText = "无法获取打印信息";
                return gr;
            }
            EJETable.pmw_timeBar flightInfo = new DAL.Dal_Print().getFlightTime(orderInfo.timeBarID);
            if (orderInfo == null)
            {
                gr.MsgText = "无法获取航班信息";
                return gr;
            }
            string SignerCode=string.Empty, VersionCode=string.Empty,   addressCode=string.Empty;
            secondEJSPushData(pringInfo.deliveryCom, pringInfo.recipientsAdd, out SignerCode, out VersionCode, out addressCode);
            reqList.Add(new Model.M_Print.Return
            {
                WaybillNo = pringInfo.CForHM_number,
                billcode = pringInfo.KD_billcodeList,
                employee = S.operateMan,
                Js_number = (int)pringInfo.TurnNumber,
                briefCode = pringInfo.deliveryCode,
                goodsType = billcodeInfo.goodsTyep,
                goodsName=pringInfo.goods,
                shopName = pringInfo.consolidator,
                OrderGoodsNotes = orderInfo.OrderGoodsNotes,
                CusCode = pringInfo.deliveryCode,
                timeBarName = flightInfo.timeBarName,
                orderID = orderInfo.id.ToString(),
                z_weight = pringInfo.netWeight.ToString(),
                address = pringInfo.recipientsAdd,
                Phone = pringInfo.recipientsPhone,
                recipients = pringInfo.recipients,
                IdentificationGoods = billcodeInfo.goodsTyep.Contains("特") ? "T" : "",
                ds_mdgj_Free = orderInfo.pay_type == 1 ? Math.Round(Convert.ToDecimal(pringInfo.freightPayable + orderInfo.country_free), 2).ToString() : "0",
                DFFeer = orderInfo.pay_type == 1 ? Math.Round(Convert.ToDecimal(pringInfo.freightPayable + orderInfo.country_free), 2).ToString() : pringInfo.freightPayable.ToString(),
                addressCode=addressCode,
                SignerCode=SignerCode,
                VersionCode=VersionCode
            });
            if (reqList.Count > 0)
            {
                gr.ReturnJson = Common.DataHandling.ObjToJson(reqList);
                gr.State = true;
                gr.Mb = pringInfo.deliveryCom;
                gr.MsgText = S.operateMan;
            }
            else 
            {
                gr.MsgText = "无法获取打印信息";
            }
           
            return gr;

        }



        private  bool PushDataEjs(string cname, string expressCompany, double billWeight, string Goods, string BillCodeNum, string wavehouse, EJETable.pmw_order orderInfo, EJETable.pmw_house houseInfo, EJETable.pmw_member memberInfo, ref string SignerCode, ref string VersionCode, ref string addressCode, ref string message)
        {
            bool pushBoo = false;
            billWeight = billWeight <= 0 ? 1 : billWeight;

            if (expressCompany.Contains("黑猫"))
            {


                try
                {
                    Common.Collections.HmHelper Hm = new Common.Collections.HmHelper();

                    string HmGooods = String.Empty;
                    if (Goods.Length > 30)
                    {
                        HmGooods = Goods.Substring(0, 29);
                    }

                    var hmData = new Common.Collections.HmHelper.Data()
                    {
                        HmBillCode = BillCodeNum,
                        OrderCode = orderInfo.id.ToString(),
                        GoodsName = HmGooods,
                        Rem = orderInfo.order_memo,
                        SentDate = DateTime.Now.ToString("yyyyMMddHHmmss"),
                        Senter = memberInfo.username,
                        SenterAddress = houseInfo.house_add,
                        SenterPhone = memberInfo.mobile,
                        SenterTel = memberInfo.telephone,
                        Signer = cname.Trim(),
                        SignerAddress = orderInfo.address,
                        SignerPhone = orderInfo.mobile.Trim(),
                        SignerTel = orderInfo.mobile2,
                        Client = memberInfo.id.ToString(),
                        Dshk_Money = (int)orderInfo.agencyFund
                    };

                    Hm.AddData(hmData);

                    SignerCode = hmData.SignerZip;
                    VersionCode =Common.Collections.HmHelper.VisonNo.egs_version;
                    addressCode =Common.Collections.HmHelper.query_suda7(hmData.SignerAddress).suda7_1;

                    pushBoo = Hm.ToEOD(Common.Entity.HmPaht, true);
                    Common.SystemLog.WriteSystemLog("黑猫推送文件：", pushBoo.ToString());
                    Common.SystemLog.WriteSystemLog("Hm", pushBoo.ToString());
                }
                catch (Exception ex)
                {

                    message = ex.Message;
                    Common.SystemLog.WriteSystemLog("黑猫保存xls错误：", ex.Message);
                }

            }
            else if (expressCompany.Contains("超峰"))
            {



                try
                {
                    String Cid = "0233";
                    if (expressCompany.Contains("小"))
                    {
                        Cid = "0234";
                    }

                    Common.Collections.CFHelper Cf = new Common.Collections.CFHelper();
                    Common.Collections.CFHelper.Data cfdata = new Common.Collections.CFHelper.Data()
                    {
                        SentSite = "AF",
                        ClientID = Cid,
                        Senter = memberInfo.username,
                        SenterPhone = memberInfo.mobile,
                        SenterAddress = houseInfo.house_add,
                        SentDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                        ClientOrderNo = BillCodeNum,
                        Signer = cname.Trim(),
                        SignerPhone = orderInfo.mobile.Trim(),
                        SignerAddress = orderInfo.address.Trim(),
                        CFBillCode = BillCodeNum,
                        GoodsName = "貨件",
                        GoodsCount = "1",
                        GoodsWeight = (int)billWeight,
                        Rem = "派前電聯",
                        PackNo = orderInfo.id.ToString(),
                        GetMoney = (int)orderInfo.agencyFund
                    };

                    Cf.AddData(cfdata);
                    SignerCode = cfdata.SignSite;
                    pushBoo = Cf.ToExecl(Common.Entity.HmPaht, true);

                    Common.SystemLog.WriteSystemLog("超峰推送文件：", pushBoo.ToString());

                }
                catch (Exception ex)
                {
                    message = ex.Message;
                    Common.SystemLog.WriteSystemLog("超峰保存xls错误：", ex.Message);
                }

            }
            return pushBoo;

        }


        /// <summary>
        /// 补打单EJS
        /// </summary>
        /// <param name="MDKDCOM"></param>
        /// <param name="address"></param>
        /// <param name="SignerCode"></param>
        /// <param name="VersionCode"></param>
        /// <param name="addressCode"></param>
        private  void secondEJSPushData(String MDKDCOM, string address, out String SignerCode, out String VersionCode, out string addressCode)
        {

            if (MDKDCOM.Contains("黑猫"))
            {
                Common.Collections.HmHelper Hm = new Common.Collections.HmHelper();
                var bb = Common.Collections.HmHelper.query_suda7(address);
                SignerCode = bb.suda7_1 != null && bb.suda7_1.Replace("-", "").Length > 5 ? bb.suda7_1.Replace("-", "").Substring(bb.suda7_1.Replace("-", "").Length - 5) : "";
                VersionCode = Common.Collections.HmHelper.VisonNo.egs_version;
                addressCode = Common.Collections.HmHelper.query_suda7(address).suda7_1;
             
                try
                {
                    Hm.ToEOD(Common.Entity.HmPaht, true);
                }
                catch (Exception ex)
                {

                    Common.SystemLog.WriteSystemLog(" 补打单EJS", "黑猫EJS推送错误：", ex.Message);
                }
            }
            else if (MDKDCOM.Contains("超峰"))
            {
                Common.Collections.CFHelper Cf = new Common.Collections.CFHelper();
                var zip = Common.Collections.CFHelper.HttpGet(Common.Collections.CFHelper.EdiUrl, address);
                SignerCode = zip.Jm;
                VersionCode = String.Empty;
                addressCode = String.Empty;
            }
            else
            {
                SignerCode = String.Empty;
                VersionCode = String.Empty;
                addressCode = String.Empty;
            }



        }
    }
}
