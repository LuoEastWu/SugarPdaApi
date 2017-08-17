using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETableData
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("pmw_Peer")]
    public partial class pmw_Peer
    {
           public pmw_Peer(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PeerName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PeerGoods {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PeerOrder {get;set;}

    }
}
