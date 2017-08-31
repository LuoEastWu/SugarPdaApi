using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.EJETable;

namespace DAL
{
    public class Dal_WaybillRule
    {
        /// <summary>
        /// 获取打印运单规则
        /// </summary>
        /// <returns></returns>
        public List<WaybillRule> WaybillRule()
        {
          return  Common.Config.StartSqlSugar<List<WaybillRule>>((db) =>
                 {
                     return db.Queryable<WaybillRule>()
                              .ToList();
                 });
        }       
    }
}
