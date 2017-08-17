using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("pmw_declaration")]
    public partial class pmw_declaration
    {
           public pmw_declaration(){


           }
           /// <summary>
           /// Desc:报关公司编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long declaration_id {get;set;}

           /// <summary>
           /// Desc:报关公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string declaration_name {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string declaration_code {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? sort_id {get;set;}

    }
}
