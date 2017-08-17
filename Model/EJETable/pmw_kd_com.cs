using System;
using SqlSugar;

namespace EJETable
{
    [SugarTable("pmw_kd_com")]
    public partial class pmw_kd_com
    {
        public pmw_kd_com() { }
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
        public string kd_com {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? country_id {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public string jym {get;set;}

        /// <summary>
        /// Desc:排序 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? sort {get;set;}

    }
}
