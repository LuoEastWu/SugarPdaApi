using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BllLogin
    {
        public Model.GeneralReturns Login(string userName, string passWord)
        {
            Model.GeneralReturns genRet = new Model.GeneralReturns();
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            { genRet.MsgText = "用户名或密码为空"; return genRet; }
            Model.LoginMode.LoginReturn logRet = new DAL.DalLogin().Login(userName, Common.Encryption.GetMD5Hash(Common.Encryption.GetMD5Hash(passWord)));
            if (logRet == null)
            { genRet.MsgText = "用户名或密码错误";}
            else if (string.IsNullOrEmpty(logRet.username))
            { genRet.MsgText = "员工用户名为空"; }
            else if (string.IsNullOrEmpty(logRet.nickname))
            { genRet.MsgText = "员工姓名为空";  }
            else
            {
                genRet.ReturnJson = Common.DataHandling.ObjToJson(logRet);
                genRet.State = true;
            }
            return genRet;
        }
    }
}
