using System.Linq;
using CodingTasks.Arrays;
using FluentAssertions;
using NUnit.Framework;

namespace CodingTasks.Tests.Arrays
{
    [TestFixture]
    public class MaximumUnsortedSubArrayTests
    {
        [TestCase(new[] { 1, 3, 2, 4, 5 }, new[] { 1, 2 })]
        [TestCase(new[] { 3, 3, 4, 5, 5, 9, 11, 13, 14, 15, 15, 16, 15, 20, 16 }, new[] { 11, 14 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { -1 })]
        public void Should_Pass_Cases(int[] input, int[] expected)
        {
            // Arrange
            var obj = new MaximumUnsortedSubArray();

            // Act
            var actual = obj.subUnsort(input.ToList());

            // Assert
            actual.Should().BeEquivalentTo(expected.ToList());
        }
    }
}
