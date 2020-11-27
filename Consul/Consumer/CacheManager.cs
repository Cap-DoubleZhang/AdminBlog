using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consul.Consumer
{
    public class CacheManager
    {
        private static volatile IMemoryCache _memoryCache;
        private static readonly object _lockObject = new object();

        static CacheManager()
        {
            if (_memoryCache == null)
            {
                lock (_lockObject)
                {
                    if (_memoryCache == null)
                    {
                        _memoryCache = new MemoryCache(Options.Create(new MemoryCacheOptions()));
                    }
                }
            }
        }
        public static TItem GetOrCreate<TItem>(object key, Func<ICacheEntry, TItem> factory)
        {
            return _memoryCache.GetOrCreate<TItem>(key, factory);
        }

        public static void Remove(object key)
        {
            _memoryCache.Remove(key);
        }
    }
}
