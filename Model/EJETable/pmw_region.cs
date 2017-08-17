using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("pmw_region")]
    public partial class pmw_region
    {
           public pmw_region(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long regionID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string regionName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? id {get;set;}

    }
}
