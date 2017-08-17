using EJETable;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DalLogin
    {
        public Model.LoginMode.LoginReturn Login(string userName, string passWord)
        {
            return Common.Config.StartSqlSugar<Model.LoginMode.LoginReturn>((db) =>
            {
                return db.Queryable<pmw_admin, pmw_house>((x, x2) => new object[]
                                   {
                                     JoinType.Left,x.houseid==x2.id
                                   })
                       .Where((x, x2) => x.username == userName && x.password == passWord)
                       .Select((x, x2) => new Model.LoginMode.LoginReturn()
                       {
                           nickname = x.nickname,
                           username = x.username,
                           permission = SqlFunc.ToInt32(x.permission),
                           areaCode = x.areaCode,
                           PDA_role = x.PDA_role,
                           country_id = SqlFunc.ToInt32(x.country_id),
                           house_name = x2.house_name,
                           houseid = x2.id.ToString(),
                           house_type = x2.house_type
                       }).First();
            });

        }

    }
}
