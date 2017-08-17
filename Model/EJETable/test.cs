using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("test")]
    public partial class test
    {
           public test(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string n {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? intNull {get;set;}

    }
}
