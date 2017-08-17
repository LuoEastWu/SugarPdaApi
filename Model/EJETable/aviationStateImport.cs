using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("aviationStateImport")]
    public partial class aviationStateImport
    {
           public aviationStateImport(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long id {get;set;}

           /// <summary>
           /// Desc:航空编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string aviation_no {get;set;}

           /// <summary>
           /// Desc:航次
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string voyage {get;set;}

           /// <summary>
           /// Desc:主号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string main_no {get;set;}

           /// <summary>
           /// Desc:航次日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? voyage_date {get;set;}

           /// <summary>
           /// Desc:航空状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string aviation_state {get;set;}

           /// <summary>
           /// Desc:状态更新日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? stateUpdateDate {get;set;}

           /// <summary>
           /// Desc:操作员
           /// Default:
           /// Nullable:True
           /// </summary>           
           [SugarColumn(ColumnName = "operator")]
        public string _operator {get;set;}

           /// <summary>
           /// Desc:操作站点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string operator_site {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Creation_time {get;set;}

    }
}
