using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("pmw_Print")]
    public partial class pmw_Print
    {
           public pmw_Print(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long id {get;set;}

           /// <summary>
           /// Desc:运单号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WaybillNo {get;set;}

           /// <summary>
           /// Desc:订单号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long orderID {get;set;}

           /// <summary>
           /// Desc:重量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? z_weight {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string address {get;set;}

           /// <summary>
           /// Desc:操作员
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string operateMan {get;set;}

           /// <summary>
           /// Desc:操作时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? operateTime {get;set;}

           /// <summary>
           /// Desc:操作地点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? operateSiteID {get;set;}

    }
}
