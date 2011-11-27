namespace Stockpile
{

    public class MemoryCacheStore : CacheStore
    {

        protected override object ReadEntry(string key, object options = null)
        {
            throw new System.NotImplementedException();
        }

        protected override void WriteEntry(string key, object entry, object options = null)
        {
            throw new System.NotImplementedException();
        }

        protected override void DeleteEntry(string key, object options = null)
        {
            throw new System.NotImplementedException();
        }
    }
}
