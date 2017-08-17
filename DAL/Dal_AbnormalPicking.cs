﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJETable;
using SqlSugar;

namespace DAL
{
    public class Dal_AbnormalPicking
    {
        /// <summary>
        /// 返回异常订单列表
        /// </summary>
        /// <param name="site"></param>
        /// <returns></returns>
        public List<Model.M_AbnormalPicking.Return> AbnormalPickingList(string site) 
        {

            return Common.Config.StartSqlSugar<List<Model.M_AbnormalPicking.Return>>((db) => 
            {
                return db.Queryable<pmw_order, pmw_billcode>((a, b) => new object[]
                         {
                             JoinType.Left,
                             a.order_code==b.order_code
                         })
                         .Where((a, b) => SqlFunc.IIF(a.Abnormal == true, 1, 0) == 1 && b.wavehouse == site)
                         .GroupBy(a => a.order_code)
                         .GroupBy(a => a.Operator)
                         .Select<Model.M_AbnormalPicking.Return>((a, b) => new Model.M_AbnormalPicking.Return
                         {
                             AbnormalEmp = a.Operator,
                             billcode = a.order_code
                         }).ToList();
            });
                         
        }
    }
}
