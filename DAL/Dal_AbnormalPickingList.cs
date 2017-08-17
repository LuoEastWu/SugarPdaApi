using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EJETable;
using SqlSugar;

namespace DAL
{
    public class Dal_AbnormalPickingList
    {
        public List<Model.M_AbnormalPickingList.Return> AbnormalPickingList(string out_barcode)
        {
            return Common.Config.StartSqlSugar<List<Model.M_AbnormalPickingList.Return>>((db) =>
            {
                return db.Queryable<pmw_billcode>()
                          .Where(a => a.order_code == out_barcode && SqlFunc.IIF(a.is_outplace == 1, 1, 0) == 0)
                          .Select<Model.M_AbnormalPickingList.Return>(a => new Model.M_AbnormalPickingList.Return
                          {
                              kd_billcode = a.kd_billcode,
                              stock_area = a.stock_area,
                              guige = a.dd_size,
                              dd_weight2 = SqlFunc.ToDouble(a.dd_weight),
                              username = a.username,
                              is_inplace = SqlFunc.ToInt32(a.is_inplace),
                              number = SqlFunc.ToInt32(a.number)
                          }).ToList();
            });

        }
    }
}
