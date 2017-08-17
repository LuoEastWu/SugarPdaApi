using System;
using SqlSugar;
namespace EJETable
{
    [SugarTable("tab_goods")]
    public partial class tab_goods
    {
        public tab_goods() { }
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public Int64 id {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public string bill_code {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public string goods {get;set;}

    }
}
