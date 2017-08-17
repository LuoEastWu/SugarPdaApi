using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("aviationBag")]
    public partial class aviationBag
    {
           public aviationBag(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public long id {get;set;}

           /// <summary>
           /// Desc:清关单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string clearCode {get;set;}

           /// <summary>
           /// Desc:发货重量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? sendWeight {get;set;}

           /// <summary>
           /// Desc:实重
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? netWeight {get;set;}

           /// <summary>
           /// Desc:转运单件数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? TurnNumber {get;set;}

           /// <summary>
           /// Desc:包数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? bagNumber {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? airID {get;set;}

           /// <summary>
           /// Desc:标记
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string aviationMark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? createTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string createEmployee {get;set;}

    }
}
