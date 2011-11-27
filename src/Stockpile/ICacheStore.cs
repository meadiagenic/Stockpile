using System;
namespace Stockpile
{

    public interface ICacheStore
    {

        T Fetch<T>(string name, Func<T> callIfMiss, object options = null);
        T Read<T>(string name, object options = null);
        //IDictionary<string, T> ReadMany<T>(IEnumerable<string> names, object options = null);
        void Write<T>(string name, T value, object options = null);
        //bool Delete(string name, object options = null);
        //void DeleteMatched(Func<string, bool> matcher, object options = null);
        //int Increment(string name, int amount = 1, object options = null);
        //int Decrement(string name, int amount = 1, object options = null);
        //void CleanUp(object options = null);
        //void Clear(object options = null);
    }
}
