using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingTasks.Arrays;
using FluentAssertions;
using NUnit.Framework;

namespace CodingTasks.Tests.Arrays
{
    [TestFixture]
    public class LargestNumberTests
    {
        [TestCase(new[] { 0, 0, 0, 0, 0, 0 }, "0")]
        [TestCase(new[] { 38, 3, 777, 26, 31, 3 }, "77738333126")]
        public void Should_Pass_Cases(int[] input, string expected)
        {
            // Arrange
            var obj = new LargestNumber();

            // Act
            var actual = obj.largestNumber(input.ToList());

            // Assert
            actual.Should().Be(expected);
        }
    }
}
