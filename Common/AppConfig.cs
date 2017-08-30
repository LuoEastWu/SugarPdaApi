using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    /// <summary>
    /// 系统配置类
    /// </summary>
    [Serializable]
    public class AppConfig
    {
        /// <summary>
        /// 初始化类
        /// </summary>
        public AppConfig()
        {
            this.ImgUrl = "http://121.201.38.115:8010/";
            this.Title = "集运管理系统";
            this.Jf_bl = 20;
            this.Jf_Name = "积分";
            this.zfb_dh = 0.8;
            this.kd_jd = false;
            this.Remarkexe = 0;
            this.Tj_ratio = 6000;
            this.TaobaoUrl = "https://world.taobao.com/item/45191159557.htm";
            this.defaultWeight = (decimal)0.5;
            this.TotalSize = "155";
            this.overweight = "25";
            this.warnLong = "9999";
            this.warnHigh = "90";
            this.warnWide = "70";
            this.warnWeight = "70";

        }
        /// <summary>
        /// 图片Url
        /// </summary>
        public string ImgUrl { get; set; }
        /// <summary>
        /// 软件标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 积分兑换比例
        /// </summary>
        public decimal Jf_bl { get; set; }
        /// <summary>
        /// 积分显示名称
        /// </summary>
        public string Jf_Name { get; set; }
        /// <summary>
        /// 支付宝兑换比率
        /// </summary>
        public double zfb_dh { get; set; }
        /// <summary>
        /// 快递员交单检测
        /// </summary>
        public bool kd_jd { get; set; }
        /// <summary>
        /// 备注回车执行事件
        /// </summary>
        public int Remarkexe { get; set; }
        /// <summary>
        /// 体积换算比例
        /// </summary>
        public double Tj_ratio { get; set; }
        /// <summary>
        /// 淘宝网宝贝链接
        /// </summary>
        public string TaobaoUrl { get; set; }

        /// <summary>
        /// 会员中心网址
        /// </summary>
        public string member_center_url { get; set; }
        /// <summary>
        /// 默认重量
        /// </summary>
        public decimal defaultWeight { get; set; }
        /// <summary>
        /// 尺寸三边和
        /// </summary>
        public string TotalSize { get; set; }
        /// <summary>
        /// 重量超过
        /// </summary>
        public string overweight { get; set; }
        /// <summary>
        /// 提示长
        /// </summary>
        public string warnLong { get; set; }
        /// <summary>
        /// 提示宽
        /// </summary>
        public string warnWide { get; set; }
        /// <summary>
        /// 提示高
        /// </summary>
        public string warnHigh { get; set; }
        /// <summary>
        /// 提示重
        /// </summary>
        public string warnWeight { get; set; }
        /// <summary>
        /// 超峰大小货判断
        /// </summary>
        public string CFWeight { get; set; }

        /// <summary>
        /// 超峰大小货尺寸之和
        /// </summary>
        public string CFSize { get; set; }

    }
}
