using System.Linq;
using CodingTasks.Arrays;
using FluentAssertions;
using NUnit.Framework;

namespace CodingTasks.Tests.Arrays
{
    [TestFixture]
    public class Add1ToNumberTests
    {
        [TestCase(new [] { 0 }, new [] { 1 })]
        [TestCase(new[] { 1, 1, 1, 3, 2, 1, 1, 2, 5, 9, 6, 5 }, new[] { 1, 1, 1, 3, 2, 1, 1, 2, 5, 9, 6, 6 })]
        [TestCase(new[] { 1, 2, 4 }, new[] { 1, 2, 5 })]
        [TestCase(new[] { 9, 9, 9, 9, 9 }, new[] { 1, 0, 0, 0, 0, 0 })]
        [TestCase(new[] { 0, 0, 4, 5, 6 }, new[] { 4, 5, 7 })]
        [TestCase(new[] { 0, 0, 9, 9, 9 }, new[] { 1, 0, 0, 0 })]
        public void Should_Pass_Cases(int[] input, int[] expected)
        {
            // Arrange
            var obj = new Add1ToNumber();

            // Act
            var actual = obj.plusOne(input.ToList());

            // Assert
            actual.Should().BeEquivalentTo(expected.ToList());
        }
    }
}
