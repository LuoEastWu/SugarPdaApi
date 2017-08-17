using System;
using SqlSugar;

namespace EJETable
{
    [SugarTable("pmw_usergroup")]
    public partial class pmw_usergroup
    {
        public pmw_usergroup() { }
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string groupname {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int expvala {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public int expvalb {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public Int64 stars {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string color {get;set;}

    }
}
