using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("rechargeSheet")]
    public partial class rechargeSheet
    {
           public rechargeSheet(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long id {get;set;}

           /// <summary>
           /// Desc:原来钱
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? oldMoney {get;set;}

           /// <summary>
           /// Desc:充值钱
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? money {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string note {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? memberID {get;set;}

           /// <summary>
           /// Desc:订单付款码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PaymentCode {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? CreationTime {get;set;}

           /// <summary>
           /// Desc:是否推送
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? is_up {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TID {get;set;}

           /// <summary>
           /// Desc:支付宝账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AliPayId {get;set;}

           /// <summary>
           /// Desc:店铺ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ShopID {get;set;}

           /// <summary>
           /// Desc:淘宝支付交易ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaoID {get;set;}

           /// <summary>
           /// Desc:操作员
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Input_Emp {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Input_house {get;set;}

    }
}
