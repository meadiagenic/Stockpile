namespace Stockpile.Tests.CacheStoreTests
{
    using FakeItEasy;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class Fetch
    {
        ICacheStore store;

        [SetUp]
        public void SetUp()
        {
            store = A.Fake<ICacheStore>();
        }

        [Test]
        public void Without_Cache_Miss()
        {
            A.CallTo(() => store.Read<string>("foo", null)).Returns("bar");
            store.Fetch("foo", "baz").Should().Equals("bar");
        }

        [Test]
        public void With_Cache_Miss()
        {
            A.CallTo(() => store.Read<string>("foo", null)).Returns(null);

            store.Fetch("foo", "baz").Should().Equals("baz");

            A.CallTo(() => store.Write("foo", "baz", null)).MustHaveHappened();

        }
    }
}
