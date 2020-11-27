using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class dbContext : DbContext
    {
        public dbContext([NotNull] DbContextOptions options)
           : base(options)
        {
            //_userContext = userContext;
            //_entityInfo = entityInfo;

            //关闭DbContext默认事务
            Database.AutoTransactionsEnabled = false;
            //关闭查询跟踪
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //生成数据库表有下面的三种方式：
            //1、代码生生成数据库
            //Database.EnsureCreated();
            //2、程序包管理器控制台迁移
            //(1)nuge安装Microsoft.EntityFrameworkCore.Tools包
            //(2)迁移命令(efcore工程) Add-Migration Init_First 生成sql
            //(3)更新数据库  Update-Database
            //3命令行迁移
            //(1)、进入EFCore目录
            //(2)、dotnet ef migrations add Initial
            //(3)、dotnet ef database update
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var entitiesTypes = _entityInfo.GetEntities();

            //foreach (var entityType in entitiesTypes)
            //{
            //    modelBuilder.Entity(entityType);
            //}

            //种子数据
            //modelBuilder.Entity<SysLoginLog>().HasData(new SysLoginLog{});
            //种子数据初始化方法分为如下三种
            //1、modelBuilder.Entity<>().HasData()方法，context.Database.EnsureCreated()只会执行一次
            //新增新的种子后，需要调用context.Database.Migrate方法调用生成的迁移类才能对数据的更改有效
            //2、控制台命令

            //生成迁移sql
            //Script-Migration -From migrationName1 -To migrationName2  -Context ContextName
            //如：Script-Migration -From 0

            //modelBuilder.ApplyConfigurationsFromAssembly(_entityInfo.GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //用于设置是否启用缓存，暂时解决了可能出现的内存溢出的问题
            optionsBuilder.EnableServiceProviderCaching(false);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
