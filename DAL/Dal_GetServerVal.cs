using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJETable;

namespace DAL
{
    public class Dal_GetServerVal
    {
        /// <summary>
        /// 获取服务器配置项
        /// </summary>
        public EJETable.AppConFig GetServerVal()
        {
            return Common.Config.StartSqlSugar<EJETable.AppConFig>((db) =>
                   {
                       return db.Queryable<EJETable.AppConFig>()
                                .OrderBy(a => a.UpdateTime, SqlSugar.OrderByType.Desc)
                                .First();
                   });
        }
    }
}
