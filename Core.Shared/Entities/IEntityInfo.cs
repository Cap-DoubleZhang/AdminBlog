using System;
using System.Collections.Concurrent;

namespace Core.Shared.Entities
{
    public interface IEntityInfo
    {
        ConcurrentBag<Type> GetEntities();
    }
}
