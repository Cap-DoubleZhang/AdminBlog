using Application.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Shared.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    /// <summary>
    /// 系统用户业务操作
    /// </summary>
    public class SysUserAppService : ISysUserAppService
    {
        private readonly IMapper _mapper;
        private readonly IEfRepository<SysUser> _userRepository;

        public async Task Save(SysUserSaveDto saveDto)
        {
            var user = _mapper.Map<SysUser>(saveDto);

            await _userRepository.InsertAsync(user);
        }
    }
}
