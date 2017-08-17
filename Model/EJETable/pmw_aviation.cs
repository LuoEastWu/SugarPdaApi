using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("pmw_aviation")]
    public partial class pmw_aviation
    {
           public pmw_aviation(){


           }
           /// <summary>
           /// Desc:航空公司编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long aviation_Id {get;set;}

           /// <summary>
           /// Desc:航空公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string aviation_name {get;set;}

           /// <summary>
           /// Desc:航空公司代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string aviation_code {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? sort_id {get;set;}

    }
}
