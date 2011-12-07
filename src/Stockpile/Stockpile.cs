
namespace System.Caching
{
	public static class Stockpile
	{
		static Stockpile()
		{
			EnableCaching = true;
		}

		public static ICache Cache { get; set; }

		private static Store _store;

		public static Store Store
		{
			get { return _store = _store ?? new MemoryStore(); }
			set { _store = value; }
		}

		public static bool EnableCaching { get; set; }
	}
}

