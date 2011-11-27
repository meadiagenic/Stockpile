namespace Stockpile.Tests.EntryTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using FluentAssertions;

    [TestFixture]
    public class EntryTestsFixture
    {
        [Test]
        public void Can_Create_Entry()
        {
            var time = DateTime.Now;
            var entry = Entry.Create("raw", time, new { compress = false, expires_in = 300 });
            entry.RawValue.Should().Equals("raw");
            entry.CreatedAt.Should().Equals(time);
            //entry.Compressed.Should().
        }
    }
}
