using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("GoodsCatalog")]
    public partial class GoodsCatalog
    {
           public GoodsCatalog(){


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
           /// Nullable:True
           /// </summary>           
           public string goodsName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string goodsType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? goodsMoney {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? exp_prot {get;set;}

           /// <summary>
           /// Desc:简码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string briefCode {get;set;}

           /// <summary>
           /// Desc:优先级别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? priority {get;set;}

    }
}
