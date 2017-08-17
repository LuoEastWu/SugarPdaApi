using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("PushMessage")]
    public partial class PushMessage
    {
           public PushMessage(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long id {get;set;}

           /// <summary>
           /// Desc:超过限制的单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string billcode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreationTime {get;set;}

           /// <summary>
           /// Desc:是否通过
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Inspection {get;set;}

           /// <summary>
           /// Desc:错误类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ErrorType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Operation_emp {get;set;}

    }
}
