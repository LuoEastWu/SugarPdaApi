using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJETableData
{
    public class ShelvesOrInventoryMode
    {
        public class ShelvesOrInventoryRequest
        {
            /// <summary>
            /// 库位号
            /// </summary>
            public string place_code { get; set; }
            /// <summary>
            /// 快递单号
            /// </summary>
            public string billcode { get; set; }
            /// <summary>
            /// 上架人
            /// </summary>
            public string emp { get; set; }
            /// <summary>
            /// 上架或盘点
            /// </summary>
            public int in_type { get; set; }
            /// <summary>
            /// 仓库名称
            /// </summary>
            public string wavehouse_name { get; set; }
        }
       
    }
}
