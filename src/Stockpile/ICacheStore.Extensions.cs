namespace Stockpile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class CacheStoreExtensions
    {
        public static T Fetch<T>(this ICacheStore store, string key, T valueIfMissing)
        {
            return store.Fetch<T>(key, () => valueIfMissing);
        }
    }
}
