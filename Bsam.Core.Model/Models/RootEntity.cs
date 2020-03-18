using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bsam.Core.Model.Models
{
    /// <summary>
    /// 实体根
    /// </summary>
    public class RootEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }


    }
}
