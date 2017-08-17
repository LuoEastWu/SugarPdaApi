using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("pmw_ztd_track")]
    public partial class pmw_ztd_track
    {
           public pmw_ztd_track(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string billcode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public DateTime? scan_time {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string scan_type {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string scan_memo {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string scan_site {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string scan_emp {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string next_site {get;set;}

    }
}
