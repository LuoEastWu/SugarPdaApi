using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("pmw_order_subcontract")]
    public partial class pmw_order_subcontract
    {
           public pmw_order_subcontract(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public long id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long orderID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string orderID_zd {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string shop {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime order_time {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal z_weight {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string cname {get;set;}

           /// <summary>
           /// Desc:电话号码
           /// Default:NULL
           /// Nullable:False
           /// </summary>           
           public string mobile {get;set;}

           /// <summary>
           /// Desc:收件地址
           /// Default:NULL
           /// Nullable:False
           /// </summary>           
           public string address {get;set;}

           /// <summary>
           /// Desc:总费用
           /// Default:NULL
           /// Nullable:False
           /// </summary>           
           public decimal z_fare {get;set;}

           /// <summary>
           /// Desc:目的国家到付
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public decimal? country_free {get;set;}

           /// <summary>
           /// Desc:超长费
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? longFee {get;set;}

           /// <summary>
           /// Desc:地址附加费
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? add_free {get;set;}

           /// <summary>
           /// Desc:单号附加费
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? surchargeFee {get;set;}

           /// <summary>
           /// Desc:其他费用
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public decimal? other_fare {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? Jf_Money {get;set;}

           /// <summary>
           /// Desc:保价金额
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? bj_money {get;set;}

           /// <summary>
           /// Desc:保价手续费
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? bj_sxfei {get;set;}

           /// <summary>
           /// Desc:代收货款
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? agencyFund {get;set;}

           /// <summary>
           /// Desc:带收货款手续费
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? dshk_sxf {get;set;}

           /// <summary>
           /// Desc:到付手续费
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? df_sxf {get;set;}

           /// <summary>
           /// Desc:包税费用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Bs_Free {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string packedBillcode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Operator {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? OperatorTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OperatorMac {get;set;}

    }
}
