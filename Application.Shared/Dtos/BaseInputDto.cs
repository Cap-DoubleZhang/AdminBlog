using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.Dtos
{
    /// <summary>
    /// 输入基础DTO类
    /// </summary>
    public abstract class BaseInputDto : BaseDto
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public virtual long? Id { get; set; }
    }
}
