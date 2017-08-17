using System;
using SqlSugar;

namespace EJETable
{
    [SugarTable("pmw_config")]
    public partial class pmw_config
    {
        public pmw_config() { }
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
        public decimal? w_b {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public decimal? w_t {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public decimal? w_w {get;set;}

    }
}
