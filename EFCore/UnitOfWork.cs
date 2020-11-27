using Core.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    /// <summary>
    /// 事务实现
    /// </summary>
    /// <typeparam name="TDbContext"></typeparam>
    public class UnitOfWork<TDbContext> : IUnitOfWork where TDbContext : dbContext
    {
        private readonly TDbContext _dbContext;
        private IDbContextTransaction _dbTransaction;

        public UnitOfWork(TDbContext context)
        {
            _dbContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public string ProviderName => _dbContext.Database.ProviderName;

        public void BeginTransaction()
        {
            _dbTransaction = _dbContext.Database.BeginTransaction();
        }

        public void BeginTransaction(IsolationLevel isolationLevel)
        {
            _dbTransaction = _dbContext.Database.BeginTransaction(isolationLevel);
        }

        public void Commit()
        {
            _dbTransaction?.Commit();
        }

        public void Dispose()
        {
            _dbTransaction?.Rollback();
        }

        public void Rollback()
        {
            _dbTransaction?.Dispose();
        }
    }
}
