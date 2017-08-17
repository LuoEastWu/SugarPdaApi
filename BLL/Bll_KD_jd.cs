using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Bll_KD_jd
    {
        public Model.GeneralReturns kd_jd(Model.M_KD_jd.Request S) 
        {
            Model.GeneralReturns genRet = new Model.GeneralReturns();

            if (new DAL.Dal_KD_jd().IsHandBill(S.billcode))
            {
                genRet.MsgText = "已交单";
            }
            else 
            {

                if (new DAL.Dal_KD_jd().DeliveryBillCode(S))
                {
                    EJETable.pmw_bill_tips billInfo = new DAL.Dal_KD_jd().billTips(S.billcode);
                    if (billInfo != null)
                    {
                        string billTipsStr = billInfo.billcode + "：" + billInfo.bill_type + "备注：" + billInfo.memo;
                        if (!String.IsNullOrEmpty(billTipsStr))
                        {
                            genRet.MsgText = billTipsStr;
                        }
                    }
                    genRet.State = true;
                }
                else 
                {
                    genRet.MsgText = "交单失败";
                }
            }
            return genRet;
        }
    }
}
