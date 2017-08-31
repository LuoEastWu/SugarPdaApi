using EJETable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Bll_Forwarder
    {
        public Model.GeneralReturns Forwarder()
        {
            Model.GeneralReturns genRet = new Model.GeneralReturns();
            Model.M_Forwarder.Return der = new Model.M_Forwarder.Return();

          
            der.ForwarderLiset = new DAL.Dal_Forwarder().Forwarder();
            if (der.ForwarderLiset.Count > 0)
            {
                List<Model.EJETable.WaybillRule> wR=new DAL.Dal_WaybillRule().WaybillRule();
                der.TotalSize = wR[0].ruleValues;
                der.overweight = wR[1].ruleValues;
                der.warnLong = wR[2].ruleValues;
                der.warnWide = wR[3].ruleValues;
                der.warnHigh = wR[4].ruleValues;
                der.warnWeight = wR[5].ruleValues;
                der.CFWeight = wR[6].ruleValues;
                der.CFSize = wR[7].ruleValues;
                string sss = Common.DataHandling.ObjToJson(wR);
                genRet.ReturnJson = Common.DataHandling.ObjToJson(der);
                genRet.State = true;
            }
            else 
            {
                genRet.MsgText = "获取失败";
            }
            return genRet;
        }
    }
}
