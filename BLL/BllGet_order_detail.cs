using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;

namespace BLL
{
    public class BllGet_order_detail
    {
        public Model.GeneralReturns GetOrderDetail(Model.M_OffShelf.OffShelfRequest S)
        {
           
            Model.GeneralReturns genRet = new Model.GeneralReturns();
            if (string.IsNullOrEmpty(S.areaCode) || String.IsNullOrEmpty(S.Operator) || String.IsNullOrEmpty(S.site))
            {
                genRet.MsgText = "拣货员工信息不完整，无法拣货";
                return genRet;
            }
            EJETable.pmw_order orderInfo = new DAL.DalGet_order_detail().IsPicking(S);
            if (orderInfo == null)
            {
                if (String.IsNullOrEmpty(S.OrderID))
                {
                    if (S.country_id == 0)
                    { genRet.MsgText = "员工没有所属国家ID"; }
                    else
                    {
                        if (new DAL.DalGet_order_detail().NationalInspection(S.country_id))
                        {
                            orderInfo = RegionalPicking(S.country_id, S.site, S.areaCode);
                            if (orderInfo == null || string.IsNullOrEmpty(orderInfo.order_code))
                            {
                                genRet.MsgText = "没有拣货任务了";
                            }
                        }
                        else { genRet.MsgText = "国家ID错误"; }
                    }
                }
                else
                {
                    if (new DAL.DalGet_order_detail().OrderOutBillCodeNotOut(S.OrderID.ObjToInt()))
                    {
                        new DAL.DalGet_order_detail().UpdateOrderNotOut(S.OrderID.ObjToInt(), 0);
                    }
                    orderInfo = new DAL.DalGet_order_detail().OrderIDGetTask(S.OrderID.ObjToInt(), S.site);
                    if ((orderInfo == null || string.IsNullOrEmpty(orderInfo.order_code)))
                    {
                        if (new DAL.DalGet_order_detail().IsOutBillCode(S.OrderID.ObjToInt()))
                        {
                            new DAL.DalGet_order_detail().UpdateOrderNotOut(S.OrderID.ObjToInt(), 1);
                            genRet.MsgText = "该订单已经下架";
                        }
                        else 
                        {
                            genRet.MsgText = "无法获取订单信息";
                        }
                    } 
                }
            }
            if (orderInfo != null && !string.IsNullOrEmpty(orderInfo.order_code))
            {
                new DAL.DalGet_order_detail().Release_task(orderInfo.id,S.Operator, 1);
                genRet = GetOrderDetailTask(orderInfo, S.Operator, S.site);
            }
            return genRet;
        }


        /// <summary>
        /// 按区域拣货
        /// </summary>
        /// <param name="country_id"></param>
        /// <param name="site"></param>
        /// <param name="areaCodeArr"></param>
        /// <returns></returns>
        public EJETable.pmw_order RegionalPicking(int country_id, string site, string areaCodeArr)
        {
            EJETable.pmw_order orderInfo = new EJETable.pmw_order();
            foreach (var areaCode in areaCodeArr.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                orderInfo = new DAL.DalGet_order_detail().RegionalPicking(country_id, site, areaCode);
                if (orderInfo != null && !string.IsNullOrEmpty(orderInfo.order_code))
                {
                    break;
                }
            }
            return orderInfo;
        }


        /// <summary>
        /// 返回拣货任务
        /// </summary>
        /// <param name="orderInfo"></param>
        /// <returns></returns>
        private Model.GeneralReturns GetOrderDetailTask(EJETable.pmw_order orderInfo, string operatorName, string site)
        {
            Model.GeneralReturns gr = new Model.GeneralReturns();
            Model.M_OffShelf.OffShelfListRuturn offSheListRet = new Model.M_OffShelf.OffShelfListRuturn();
           offSheListRet.OffShelfRuturn = new DAL.DalGet_order_detail().PickingTask(operatorName, site, orderInfo);
           
            if (offSheListRet.OffShelfRuturn.Count > 0)
            {
                gr.ReturnJson = Common.DataHandling.ObjToJson(offSheListRet);
                gr.State = true;
            }
            else
            {
                new DAL.DalGet_order_detail().Release_task(orderInfo.id, string.Empty, 0);
                gr.MsgText = "无法获取" + orderInfo.id + "！请重试";
            }
            return gr;


        }
    }
}
