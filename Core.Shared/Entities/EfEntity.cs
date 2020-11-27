using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Shared.Entities
{
    /// <summary>
    /// 实体公共字段，创建人、最后更新人字段的类型取决于主键类型（本系统中）
    /// </summary>
    public abstract class EfEntity : IEfEntity<long>
    {
        [Key]
        [Column("ID")]
        public virtual long ID { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [Description("创建人")]
        [Column("CreateBy")]
        public virtual long? CreateBy { get; set; }

        /// <summary>
        /// 创建时间/注册时间
        /// </summary>
        [Description("创建时间/注册时间")]
        [Column("CreateTime")]
        public virtual DateTime? CreateTime { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [Description("是否删除")]
        [Column("IsDeleted")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 最后更新人
        /// </summary>
        [Description("最后更新人")]
        [Column("UpdateBy")]
        public long? UpdateBy { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [Description("最后更新时间")]
        [Column("UpdateTime")]
        public DateTime? UpdateTime { get; set; }
    }
}
