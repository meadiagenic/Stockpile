using System.Caching;
using System;
using FluentAssertions;
using NUnit.Framework;

namespace StockpileTests.EntryTests
{
	[TestFixture]
	public class EntryTestsFixture
	{
		[Test]
		public void Can_Create_Entry()
		{
			var time = DateTime.Now;
			var entry = CacheEntry.Create("raw", time, new { compress = false, expires_in = 300 });
			entry.RawValue.Should().Equals("raw");
			entry.CreatedAt.Should().Equals(time);
			//entry.Compressed.Should().
		}
	}
}
