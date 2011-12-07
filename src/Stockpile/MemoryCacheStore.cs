namespace System.Caching
{

	public class MemoryStore : Store
	{

		public override void CleanUp()
		{
			throw new System.NotImplementedException();
		}

		public override void Clear()
		{
			throw new System.NotImplementedException();
		}

		public override int Decrement(string key, int amount = 1)
		{
			throw new System.NotImplementedException();
		}

		protected override object ReadEntry(string key)
		{
			throw new System.NotImplementedException();
		}

		protected override object WriteEntry(string key, object entry)
		{
			throw new System.NotImplementedException();
		}

		protected override object DeleteEntry(string key)
		{
			throw new System.NotImplementedException();
		}
	}
}
