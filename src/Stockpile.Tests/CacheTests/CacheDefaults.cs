namespace Stockpile.Tests.CacheTests
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class CacheDefaults
    {

        [Test]
        public void DefaultCacheStore_Should_Be_Null_Cache_Store()
        {
            Cache.Store.Should().NotBeNull().And.BeOfType<MemoryCacheStore>();

        }

        [Test]
        public void EnableCaching_Should_Be_False()
        {
            Cache.EnableCaching.Should().BeFalse();
        }
    }
}
