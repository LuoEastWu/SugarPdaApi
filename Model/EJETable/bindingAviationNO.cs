using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("bindingAviationNO")]
    public partial class bindingAviationNO
    {
           public bindingAviationNO(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long id {get;set;}

           /// <summary>
           /// Desc:清关单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string qingguan_No {get;set;}

           /// <summary>
           /// Desc:航空主号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string aviation_NO {get;set;}

           /// <summary>
           /// Desc:班机
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string airliner {get;set;}

           /// <summary>
           /// Desc:预计时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? estimated_time {get;set;}

           /// <summary>
           /// Desc:实际时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? actual_time {get;set;}

           /// <summary>
           /// Desc:航空状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Air_state {get;set;}

           /// <summary>
           /// Desc:日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? date_time {get;set;}

           /// <summary>
           /// Desc:操作员
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Operation {get;set;}

           /// <summary>
           /// Desc:操作站点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Operation_site {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? Creation_time {get;set;}

    }
}
