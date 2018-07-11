using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class ShowingTests
    {
        [Fact]
        public void Test_Showing_Id()
        {
            var expected = typeof(Guid);
            var h = new Showing();

            var actual = h.Id;

            Assert.True(actual.GetType() == expected);
        }
    }
}
