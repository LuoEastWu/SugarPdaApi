using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Bll_PushMessage
    {
        public Model.GeneralReturns PushMessage(Model.M_PushMessage.Request S) 
        {
            Model.GeneralReturns genRet = new Model.GeneralReturns();
            SqlSugar.DbResult<bool> dbr = new DAL.Dal_PushMessage().ProblemInset(S);
            if (dbr.IsSuccess)
            {
                genRet.State = true;
            }
            else 
            {
                genRet.MsgText = dbr.Messaage;
            }
            return genRet;
        }
    }
}
