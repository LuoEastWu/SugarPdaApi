using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("pmw_member_deletelog")]
    public partial class pmw_member_deletelog
    {
           public pmw_member_deletelog(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OpenID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string username {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string password {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string question {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string answer {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string cnname {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string enname {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string avatar {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string sex {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public byte? birthtype {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'-1'
           /// Nullable:True
           /// </summary>           
           public string birth_year {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'-1'
           /// Nullable:True
           /// </summary>           
           public string birth_month {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'-1'
           /// Nullable:True
           /// </summary>           
           public string birth_day {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string url {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? astro {get;set;}

           /// <summary>
           /// Desc:
           /// Default:-1
           /// Nullable:True
           /// </summary>           
           public short? bloodtype {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'-1'
           /// Nullable:True
           /// </summary>           
           public string trade {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'-1'
           /// Nullable:True
           /// </summary>           
           public string live_prov {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'-1'
           /// Nullable:True
           /// </summary>           
           public string live_city {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'-1'
           /// Nullable:True
           /// </summary>           
           public string live_country {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'-1'
           /// Nullable:True
           /// </summary>           
           public string home_prov {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'-1'
           /// Nullable:True
           /// </summary>           
           public string home_city {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'-1'
           /// Nullable:True
           /// </summary>           
           public string home_country {get;set;}

           /// <summary>
           /// Desc:
           /// Default:-1
           /// Nullable:True
           /// </summary>           
           public short? cardtype {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string cardnum {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string intro {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string email {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string qqnum {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string mobile {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string telephone {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'-1'
           /// Nullable:True
           /// </summary>           
           public string address_prov {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'-1'
           /// Nullable:True
           /// </summary>           
           public string address_city {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'-1'
           /// Nullable:True
           /// </summary>           
           public string address_country {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string address {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string zipcode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string enteruser {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public int? expval {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public long? integral {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public long? regtime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string regip {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public long? logintime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string loginip {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string qqid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string weiboid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string jym {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? reg_date {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string memberid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public int? weight {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Money {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? rank {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string reg_come {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string vip_rank {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? discount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string zc_type {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OldMemberID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Money_t {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? deliveryType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? is_inspect {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string unifiedCompile {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReferenceNumber {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SiteName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UseName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string mac {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? DeleteTime {get;set;}

    }
}
