using Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    [Table("Sys_RoleMenu")]
    [Description("角色对菜单表")]
    public class SysRoleMenu
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        [Column("RoleID")]
        public long RoleID { get; set; }
        /// <summary>
        /// 菜单ID 
        /// </summary>
        [Column("MenuID")]
        public long MenuID { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        [Column("ValidFlag")]
        public ValidFlagType ValidFlag { get; set; }
    }
}
