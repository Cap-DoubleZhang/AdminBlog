using Application.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    /// <summary>
    /// 保存系统用户DTO
    /// </summary>
    public class SysUserSaveDto : BaseInputDto
    {
        /// <summary>
        /// 用户登录名
        /// </summary>
        public string UserLoginName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPassworrd { get; set; }
        /// <summary>
        /// 用户描述
        /// </summary>
        public string Descripts { get; set; }
        /// <summary>
        /// 是否在线
        /// </summary>
        public int IsOnline { get; set; }
        /// <summary>
        /// 登陆次数
        /// </summary>
        public int LoginTimes { get; set; }
        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime? LastLoginTime { get; set; }
        /// <summary>
        /// 上次登录IP
        /// </summary>
        public string LastLoginIP { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        public int IsUse { get; set; }
        /// <summary>
        /// 是否被删除
        /// </summary>
        public int ValigFlag { get; set; }
    }
}
