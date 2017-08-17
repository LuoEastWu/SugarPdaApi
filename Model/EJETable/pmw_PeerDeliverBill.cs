using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("pmw_PeerDeliverBill")]
    public partial class pmw_PeerDeliverBill
    {
           public pmw_PeerDeliverBill(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CusName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string billcode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime createTime {get;set;}

           /// <summary>
           /// Desc:是否到达
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? is_arrive {get;set;}

           /// <summary>
           /// Desc:扫描人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string scan_emp {get;set;}

           /// <summary>
           /// Desc:扫描站点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string scan_site {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? arrive_time {get;set;}

    }
}
