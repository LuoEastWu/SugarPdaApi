using System;
using SqlSugar;

namespace EJETableData
{
    [SugarTable("pmw_number")]
    public partial class pmw_number
    {
        public pmw_number() { }
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
        public string num {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:((0)) 
        /// Nullable:True 
        /// </summary>
        public int? is_Use {get;set;}

        /// <summary>
        /// Desc:承运商ID 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Int64 ForwarderID {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:True 
        /// </summary>
        public Int64 clearance_id {get;set;}

    }
}
