using System;
using SqlSugar;

namespace EJETable
{
    [SugarTable("pmw_wavehouse")]
    public partial class pmw_wavehouse
    {
        public pmw_wavehouse() { }
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
        public string wavehouse_name {get;set;}

        /// <summary>
        /// Desc:区 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public string wavehouse_bigarea_name {get;set;}

        /// <summary>
        /// Desc:柜 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public string wavehouse_area_name {get;set;}

        /// <summary>
        /// Desc:组 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public string wavehouse_Letter_section {get;set;}

        /// <summary>
        /// Desc:层 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public int? wavehouse_tier {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public string wavehouse_place_name {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public string wavehouse_place_memo {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:(NULL) 
        /// Nullable:True 
        /// </summary>
        public string wavehouse_place_flag {get;set;}

    }
}
