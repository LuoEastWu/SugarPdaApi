using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using EJETable;

namespace DAL
{
    public class Dal_Forwarder
    {
        public new List<Model.M_Forwarder.Carrier> Forwarder()
        {
            return Common.Config.StartSqlSugar<List<Model.M_Forwarder.Carrier>>((db) =>
            {

                return db.Queryable<Forwarder>()
                         .Select<Model.M_Forwarder.Carrier>(a => new Model.M_Forwarder.Carrier
                         {
                             ForwarderName = a.ForwarderName,
                             id = a.id.ToString()
                         }).ToList();

            });

        }
    }
}
