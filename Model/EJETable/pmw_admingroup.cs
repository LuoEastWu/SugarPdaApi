using System;
using SqlSugar;

namespace EJETable
{
    [SugarTable("pmw_admingroup")]
    public partial class pmw_admingroup
    {
        public pmw_admingroup()
        {

        }
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public Byte id {get;set;}

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
        public string description {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string groupsite {get;set;}

        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string checkinfo {get;set;}

    }
}
