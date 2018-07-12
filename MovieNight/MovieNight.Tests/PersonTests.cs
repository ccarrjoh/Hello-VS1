using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Test_Person_Id()
        {
            var expected = typeof(Guid);
            var h = new Person();

        var actual = h.Id;

        Assert.True(actual.GetType() == expected);
        }

        [Fact]
        public void Test_PersonHistory()
        {
            var sut = new Person();
            Assert.NotNull(sut.History);
        }
    }
}
