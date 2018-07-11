using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class HistoryTests
    {
        [Fact]
        public void Test_History_Id()
        {
            var expected = typeof(Guid);
            var h = new History();

            var actual = h.Id;

            Assert.True(actual.GetType() == expected);
        }
    }
}
