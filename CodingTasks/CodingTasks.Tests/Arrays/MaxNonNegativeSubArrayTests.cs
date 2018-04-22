using System.Collections.Generic;
using System.Linq;
using CodingTasks.Arrays;
using FluentAssertions;
using NUnit.Framework;

namespace CodingTasks.Tests.Arrays
{
    [TestFixture]
    public class MaxNonNegativeSubArrayTests
    {
        [TestCase(new []{ 336465782, -278722862, -2145174067, 1101513929, 1315634022,
            -1369133069, 1059961393, 628175011, -1131176229, -859484421},
            new []{ 1101513929, 1315634022})]
        [TestCase(new[] { 756898537, -1973594324, -2038664370, -184803526, 1424268980 }, new[] { 1424268980 })]
        public void Should_Pass_Cases(int[] input, int[] expected)
        {
            // Arrange
            var obj = new MaxNonNegativeSubArray();

            // Act
            var actual = obj.maxset(input.ToList());

            // Assert
            actual.Should().BeEquivalentTo(expected.ToList());
        }
    }
}
