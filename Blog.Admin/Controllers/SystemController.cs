using Application;
using Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Admin.Controllers
{
    public class SystemController : ControllerBase
    {
        private readonly ISysUserAppService _userService;

        public SystemController(ISysUserAppService userService)
        {
            _userService = userService;
        }
        /// <summary>
        /// 保存用户(新增/修改)
        /// </summary>
        /// <param name="userDto">用户信息</param>
        /// <returns></returns>
        [HttpPost]
        public async Task Save([FromBody] SysUserSaveDto userDto)
        {
            await _userService.Save(userDto);
        }
    }
}
