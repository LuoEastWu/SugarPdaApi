using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("pmw_track_fj")]
    public partial class pmw_track_fj
    {
           public pmw_track_fj(){


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

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string packno {get;set;}

    }
}
