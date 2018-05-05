using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace CodingTasks.Tests
{
    [TestFixture]
    public class RainWaterTrappedTests
    {
        //[TestCase(new [] {2,1,0,1}, 1)]
        [TestCase(new [] {0,1,0,2,1,0,1,3,2,1,2,1}, 6)]
        public void Should_Pass_Cases(int[] input, int expected)
        {
            // Arrange
            var obj = new RainWaterTrapped();

            // Act
            var actual = obj.trap(input.ToList());

            // Assert
            actual.Should().Be(expected);
        }
    }
}
