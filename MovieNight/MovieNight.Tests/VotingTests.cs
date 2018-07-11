using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class VotingTests
    {
        [Fact]
        public void Test_Voting_Id()
        {
            var expected = typeof(Guid);
            var h = new Voting();

            var actual = h.Id;

            Assert.True(actual.GetType() == expected);
        }
    }
}
