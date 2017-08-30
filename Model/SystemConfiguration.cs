using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 系统配置类
    /// </summary>
    [Serializable]
    public class SystemConfiguration
    {

        /// <summary>
        /// 初始化类
        /// </summary>
        public SystemConfiguration()
        {
            this.TotalSize = "155";
            this.overweight = "25";
            this.warnLong = "9999";
            this.warnHigh = "90";
            this.warnWide = "70";
            this.warnWeight = "70";

        }
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
