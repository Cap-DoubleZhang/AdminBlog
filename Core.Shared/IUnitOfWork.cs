using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Shared
{
    /// <summary>
    /// 事务操作
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        string ProviderName { get; }

        void BeginTransaction();

        void BeginTransaction(IsolationLevel isolationLevel);

        void Rollback();

        void Commit();
    }
}
