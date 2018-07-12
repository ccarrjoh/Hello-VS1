using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var m = new Movie();

            var actual = m.Id;

            Assert.True(actual.GetType() == expected);
        }

        [Fact]
        public void Test_MovieActors()
        {
            var expected = 1;
            var m = new Movie();
            var actual = m.Actors;

            Assert.True(typeof(List<Person>) == actual.GetType());
            Assert.True(actual.Count() >= expected);

        }
    }
}
