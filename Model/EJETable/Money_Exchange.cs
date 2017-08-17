using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Money_Exchange")]
    public partial class Money_Exchange
    {
           public Money_Exchange(){


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
           public decimal? money_type1 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? money_type2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? money_pay {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? Is_Use {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? discount {get;set;}

    }
}
