namespace Stockpile
{
    using System;

    public abstract class CacheStore : ICacheStore
    {

        protected abstract object ReadEntry(string key, object options = null);

        protected abstract void WriteEntry(string key, object entry, object options = null);

        protected abstract void DeleteEntry(string key, object options = null);



        public virtual T Fetch<T>(string name, Func<T> callIfMiss, dynamic options = null)
        {
            return Read<T>(name, options);
        }


        public T Read<T>(string name, object options = null)
        {
            options = options ?? new object();
            var entry = ReadEntry(name, options);
            if (entry != null)
            {

            }
            return default(T);
        }


        public void Write<T>(string name, T value, object options = null)
        {
            var entry = new Entry(value, options);
            WriteEntry(name, entry, options);
        }
    }
}
