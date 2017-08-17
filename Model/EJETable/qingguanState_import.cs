using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("qingguanState_import")]
    public partial class qingguanState_import
    {
           public qingguanState_import(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long id {get;set;}

           /// <summary>
           /// Desc:清关公司编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string qingguanComNo {get;set;}

           /// <summary>
           /// Desc:清关公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string qingguanComName {get;set;}

           /// <summary>
           /// Desc:清关单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string qingguanNO {get;set;}

           /// <summary>
           /// Desc:清关状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string qingguanState {get;set;}

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
