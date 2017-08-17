using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Forwarder_number")]
    public partial class Forwarder_number
    {
           public Forwarder_number(){


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
           public string num {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? is_Use {get;set;}

           /// <summary>
           /// Desc:承运商ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? ForwarderID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? clearance_id {get;set;}

           /// <summary>
           /// Desc:同行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? peer {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ForwarderCode {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? creationTime {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string founder {get;set;}

    }
}
