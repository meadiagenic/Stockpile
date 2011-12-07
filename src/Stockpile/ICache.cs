namespace System.Caching
{
	public interface ICache
	{
		T Fetch<T>(string key, Func<T> actionIfCacheMiss);
	}
}
