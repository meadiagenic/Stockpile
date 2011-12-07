namespace System.Caching
{
	public abstract class Store
	{
		public abstract void CleanUp();

		public abstract void Clear();

		public abstract int Decrement(string key, int amount = 1);

		public virtual bool Delete(string key)
		{
			return false;
		}

		protected abstract object ReadEntry(string key);

		protected abstract object WriteEntry(string key, object entry);

		protected abstract object DeleteEntry(string key);

		public T Fetch<T>(string name, Func<T> callIfMiss, object options = null)
		{
			throw new NotImplementedException();
		}

		public T Read<T>(string name, object options = null)
		{
			throw new NotImplementedException();
		}

		public void Write<T>(string name, T value, object options = null)
		{
			throw new NotImplementedException();
		}
	}
}
