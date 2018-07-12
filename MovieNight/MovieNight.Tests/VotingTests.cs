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

        [Fact]
        public void Test_MovieVote()
        {
            var expected = 1;
            var sut = new Voting();
            var actual = sut.Movie;

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_VotingPeople()
        {
            var expected = 0;
            var sut = new Voting();
            var actual = sut.People;

            Assert.True(typeof(List<Person>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
    }
}
