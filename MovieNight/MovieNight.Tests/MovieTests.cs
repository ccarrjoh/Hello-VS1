using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class MovieTests
    {
        [Fact]
        public void Test_Movie_Id()
        {
            var expected = typeof(Guid);
            var h = new Movie();

            var actual = h.Id;

            Assert.True(actual.GetType() == expected);
        }
    }
}
