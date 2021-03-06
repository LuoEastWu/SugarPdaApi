﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Bll_PickingStop
    {
        public Model.GeneralReturns PickingStop(Model.M_PickingStop.Request S)
        {
            Model.GeneralReturns genRet = new Model.GeneralReturns();
            if (String.IsNullOrEmpty(S.out_billcode) || String.IsNullOrEmpty(S.oper))
            {
                genRet.MsgText = "运单号为空或操作员为空";
                return genRet;
            }
            SqlSugar.DbResult<bool> dbRes = new DAL.Dal_PickingStop().StopPicking(S.out_billcode, S.oper);
            if (dbRes.IsSuccess)
            {
                genRet.State = true;
            }
            else
            {
                genRet.MsgText = dbRes.Messaage;
            }
            return genRet;
        }
    }
}
