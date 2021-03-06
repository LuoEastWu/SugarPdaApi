﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;

namespace BLL
{
    public class Bll_inplace
    {
        public Model.GeneralReturns PutawayInventory(Model.M_inplaceRequest S)
        {
            Common.SystemLog.WriteSystemLog("快递交单", Common.DataHandling.ObjToJson(S));
            Model.GeneralReturns genRet = new Model.GeneralReturns();
            if (string.IsNullOrEmpty(S.place_code) || string.IsNullOrEmpty(S.billcode) || string.IsNullOrEmpty(S.emp) || string.IsNullOrEmpty(S.wavehouse_name))
            {
                genRet.MsgText = "参数不全，请核实";
            }
            else if (!new DAL.Dal_inplace().inplaceRecord(S))
            {
                genRet.MsgText = "此单没有入库记录";
            }
            else if (new DAL.Dal_inplace().inplaceSendOut(S))
            {
                genRet.MsgText = "该单号已经发货不能操作";
            }
            else if (S.in_type==0&&new DAL.Dal_inplace().Putaway(S)) 
            {
                genRet.MsgText = "单号已上架不能重复上架";
            }
            else if (!new DAL.Dal_inplace().WarehouseLocation(S))
            {
                genRet.MsgText = "库位号不存在";
            }
            else 
            {
                SqlSugar.DbResult<bool> dbRes = new DAL.Dal_inplace().ExecuteInplace(S);
                genRet.State = dbRes.IsSuccess;
                genRet.MsgText =dbRes.Messaage;
            }
            return genRet;
        }
    }
}
