using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mode
{
    public class standardMode
    {
        public class staandardModeReturn 
        {
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
        }
    }
}
