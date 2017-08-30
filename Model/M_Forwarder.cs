using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class M_Forwarder
    {
        public class Request 
        {

        }

        [Serializable]
        public class Return 
        {

            [Model.Mode.Mode(Rem = "承运商LIst", IsNull = false)]
            public List<Carrier> ForwarderLiset { get; set; }
            /// <summary>
            /// 尺寸三边和
            /// </summary>
            [Model.Mode.Mode(Rem = "尺寸三边和", IsNull = false)]
            public string TotalSize { get; set; }
            /// <summary>
            /// 重量超过
            /// </summary>
           [Model.Mode.Mode(Rem = "重量超过", IsNull = false)]
            public string overweight { get; set; }
            /// <summary>
            /// 提示长
            /// </summary>
            [Model.Mode.Mode(Rem = "提示长", IsNull = false)]
            public string warnLong { get; set; }
            /// <summary>
            /// 提示宽
            /// </summary>
            [Model.Mode.Mode(Rem = "提示宽", IsNull = false)]
            public string warnWide { get; set; }
            /// <summary>
            /// 提示高
            /// </summary>
            [Model.Mode.Mode(Rem = "提示高", IsNull = false)]
            public string warnHigh { get; set; }
            /// <summary>
            /// 提示重
            /// </summary>
            [Model.Mode.Mode(Rem = "提示重", IsNull = false)]
            public string warnWeight { get; set; }
            /// <summary>
            /// 超峰大小货判断
            /// </summary>
            [Model.Mode.Mode(Rem = "超峰大小货判断", IsNull = false)]
            public string CFWeight { get; set; }
            /// <summary>
            /// 超峰大小货尺寸之和
            /// </summary>
            [Model.Mode.Mode(Rem = "超峰大小货尺寸之和", IsNull = false)]
            public string CFSize { get; set; }

        }
        /// <summary>
        /// 承运商
        /// </summary>
        public class Carrier 
        {
            /// <summary>
            /// 承运商ID
            /// </summary>
            [Model.Mode.Mode(Rem = "承运商ID", IsNull = false)]
            public string id { get; set; }
            /// <summary>
            ///承运商名称
            /// </summary>
            [Model.Mode.Mode(Rem = "承运商名称", IsNull = false)]
            public string ForwarderName { get; set; }
        }
        
    }
}
