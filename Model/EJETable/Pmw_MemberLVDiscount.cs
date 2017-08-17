using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Pmw_MemberLVDiscount")]
    public partial class Pmw_MemberLVDiscount
    {
           public Pmw_MemberLVDiscount(){


           }
           /// <summary>
           /// Desc:ID 主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long ID {get;set;}

           /// <summary>
           /// Desc:店铺ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Shop {get;set;}

           /// <summary>
           /// Desc:会员等级ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int MemberLV {get;set;}

           /// <summary>
           /// Desc:显示名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:折扣
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public decimal Discount {get;set;}

           /// <summary>
           /// Desc:升级金额
           /// Default:1000
           /// Nullable:False
           /// </summary>           
           public decimal UpMoney {get;set;}

           /// <summary>
           /// Desc:是否有效
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int Valid {get;set;}

    }
}
