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
            var s = new Showing();

            var actual = s.Id;

            Assert.True(actual.GetType() == expected);
        }

        [Fact]
        public void Test_ShowingMovies()
        {
            var expected = 1;
            var s = new Showing();
            var actual = s.Movies;

            Assert.True(typeof(List<Movie>) == actual.GetType());
            Assert.True(actual.Count >= expected);
        }
    }
}
