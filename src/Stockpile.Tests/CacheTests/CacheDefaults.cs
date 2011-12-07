using System.Caching;
using FluentAssertions;
using NUnit.Framework;

namespace StockpileTests.CacheTests
{
	[TestFixture]
	public class CacheDefaults
	{

		[Test]
		public void DefaultCacheStore_Should_Be_Memory_Cache_Store()
		{
			Stockpile.Store.Should().NotBeNull().And.BeOfType<MemoryStore>();

		}

		[Test]
		public void EnableCaching_Should_Be_True()
		{
			Stockpile.EnableCaching.Should().BeTrue();
		}
	}
}
