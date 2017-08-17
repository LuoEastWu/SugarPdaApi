using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace EJETable
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("CFHMPring")]
    public partial class CFHMPring
    {
        public CFHMPring()
        {


        }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public long id { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string CForHM_number { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public long OrderID { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string goods { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string recipients { get; set; }

        /// <summary>
        /// Desc:收货人
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string consignee { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string recipientsAdd { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string recipientsPhone { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string recipientsPhone2 { get; set; }

        /// <summary>
        /// Desc:收件人统编
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string recipientsIDCard { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string airPackCode { get; set; }

        /// <summary>
        /// Desc:到付费用
        /// Default:0
        /// Nullable:False
        /// </summary>           
        public decimal freightPayable { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public long? AriPackID { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal? sentWeight { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal? netWeight { get; set; }

        /// <summary>
        /// Desc:件数
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public int? TurnNumber { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string KD_billcodeList { get; set; }

        /// <summary>
        /// Desc:是否合重
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? is_confirm_weight { get; set; }

        /// <summary>
        /// Desc:合重选择承运商
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string cforhmType { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Order_Notes { get; set; }

        /// <summary>
        /// Desc:集运商名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string consolidator { get; set; }

        /// <summary>
        /// Desc:派件公司
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string deliveryCom { get; set; }

        /// <summary>
        /// Desc:派件代码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string deliveryCode { get; set; }

        /// <summary>
        /// Desc:转运单号类型
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string billNumType { get; set; }

        /// <summary>
        /// Desc:是否打包
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public int? is_AriPack { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SysAirPackCode { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public long? SysAriPackID { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? CFpacked_time { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CFpacked_emp { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CFpacked_billcode { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CFpacked_kd_com { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CFpacked_code { get; set; }

        /// <summary>
        /// Desc:出货仓库
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string houseName { get; set; }

        /// <summary>
        /// Desc:出货仓库ID
        /// Default:
        /// Nullable:False
        /// </summary>           
        public long houseID { get; set; }

        /// <summary>
        /// Desc:
        /// Default:DateTime.Now
        /// Nullable:True
        /// </summary>           
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string note { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsIgnore = true)]
        public int IsRead { get; set; }

    }
}
