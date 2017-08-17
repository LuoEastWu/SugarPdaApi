using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("pmw_salesReturn")]
    public partial class pmw_salesReturn
    {
           public pmw_salesReturn(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long id {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreationDate {get;set;}

           /// <summary>
           /// Desc:退件原单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReturnOriginal {get;set;}

           /// <summary>
           /// Desc:店铺
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string store {get;set;}

           /// <summary>
           /// Desc:退出单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OutOrder {get;set;}

           /// <summary>
           /// Desc:付款单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string payOrderID {get;set;}

           /// <summary>
           /// Desc:仓库确认金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? amount {get;set;}

           /// <summary>
           /// Desc:客户支付费用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? payMoney {get;set;}

           /// <summary>
           /// Desc:付款登记人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string payEmp {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? payState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? payTime {get;set;}

           /// <summary>
           /// Desc:收货地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ShippingAdd {get;set;}

           /// <summary>
           /// Desc:电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string phone {get;set;}

           /// <summary>
           /// Desc:收货人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string recipient {get;set;}

           /// <summary>
           /// Desc:是否确认
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? is_confirm {get;set;}

           /// <summary>
           /// Desc:确认时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? confirmDate {get;set;}

           /// <summary>
           /// Desc:仓库操作员
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Operation_emp {get;set;}

           /// <summary>
           /// Desc:操作客服
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Airlines {get;set;}

           /// <summary>
           /// Desc:退件类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SalesRetuType {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string notes {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? updteDateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string updateEmp {get;set;}

    }
}
