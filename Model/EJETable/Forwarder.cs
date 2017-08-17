using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Forwarder")]
    public partial class Forwarder
    {
           public Forwarder(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long id {get;set;}

           /// <summary>
           /// Desc:承运商名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ForwarderName {get;set;}

           /// <summary>
           /// Desc:承运商查件地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ForwarderURL {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ForwarderCode {get;set;}

           /// <summary>
           /// Desc:清关表ID关联
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? clearance_id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? country_id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? order_id {get;set;}

    }
}
