using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace CodingTasks.Tests
{
    [TestFixture]
    public class NearestSmallerElementTests
    {
        [TestCase(new[] { 34, 35, 27, 42, 5, 28, 39, 20, 28 },
            new[] {-1, 34, -1, 27, -1, 5, 28, 5, 20 })]
        public void Should_Pass_Cases(int[] input, int[] expected)
        {
            // Arrange
            var obj = new NearestSmallerElement();

            // Act
            var actual = obj.prevSmaller(input.ToList()).ToArray();

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
