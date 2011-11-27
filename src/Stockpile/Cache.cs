namespace Stockpile
{

    public class Cache
    {
        static Cache()
        {
           
        }

        private static ICacheStore _store;
        public static ICacheStore Store {
            get { return _store = _store ?? new MemoryCacheStore(); }
            set { _store = value; }
        }

        public static bool EnableCaching { get; set; }
    }
}
