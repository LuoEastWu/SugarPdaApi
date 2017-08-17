using System;
using SqlSugar;

namespace EJETable
{
    [SugarTable("pmw_track")]
    public partial class pmw_track
    {
        public pmw_track() { }
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public Int64 id {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string billcode {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public DateTime? scan_time {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public string scan_type {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public string scan_memo {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public string scan_site {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public string scan_emp {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public string next_site {get;set;}

    }
}
