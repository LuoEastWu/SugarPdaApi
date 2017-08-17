using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("virtual_house")]
    public partial class virtual_house
    {
           public virtual_house(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long id {get;set;}

           /// <summary>
           /// Desc:仓库ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? house_ID {get;set;}

           /// <summary>
           /// Desc:国家ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? country_id {get;set;}

           /// <summary>
           /// Desc:仓库名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string house_name {get;set;}

           /// <summary>
           /// Desc:店铺ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? shop_ID {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string address {get;set;}

           /// <summary>
           /// Desc:联系人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Linkman {get;set;}

           /// <summary>
           /// Desc:联系电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LinkPhone {get;set;}

           /// <summary>
           /// Desc:联系邮编
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LinkZipCode {get;set;}

    }
}
