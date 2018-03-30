using System;
using SearchPlayground.Service;
using SearchPlayground.Service.Engine;
using Xunit;

namespace SearchPlayground.Test
{
    public class LevenshteinDistanceEngineTests
    {
        private readonly ISearchEngine _searchEngine = new LevenshteinDistanceEngine();
        
        [Fact]
        public void CountDistanceReturn0WhenGivenStringsAreEmpty()
        {
            var distance = _searchEngine.CountDistance(string.Empty, string.Empty);

            Assert.Equal(0, distance);
        }
        
        [Fact]
        public void CountDistanceReturn0WhenGivenStringsAreEqual()
        {
            var distance = _searchEngine.CountDistance("kitten", "kitten");

            Assert.Equal(0, distance);
        }

        [Fact]
        public void CountDistanceReturnCorrectDistance()
        {
            var firstDistance = _searchEngine.CountDistance("kitten", "sitting");
            var secondDistance = _searchEngine.CountDistance("rosettacode", "raisethysword");
            

            Assert.Equal(3, firstDistance);
            Assert.Equal(8, secondDistance);
        }

        [Fact]
        public void CountDistanceReturnTwoWhenStringsHaveOneTransposition()
        {
            var distance = _searchEngine.CountDistance("kitten", "kittne");

            Assert.Equal(2, distance);
        }
    }
}
