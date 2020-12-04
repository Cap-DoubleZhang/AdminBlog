using Application.Dtos;
using Application.Shared.Services;
using AutoMapper;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    /// <summary>
    /// 系统用户业务处理接口
    /// </summary>
    public interface ISysUserAppService : IAppService
    {
        //[OpsLog(LogName = "新增/修改用户")]
        Task Save(SysUserSaveDto saveDto);
    }
}
