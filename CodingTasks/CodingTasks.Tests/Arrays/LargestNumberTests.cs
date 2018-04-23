using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingTasks.Arrays;
using NUnit.Framework;

namespace CodingTasks.Tests.Arrays
{
    [TestFixture]
    public class LargestNumberTests
    {
        [TestCase(new[] { 0, 0, 9, 9, 9 }, new[] { 1, 0, 0, 0 })]
        public void Should_Pass_Cases(int[] input, int[] expected)
        {
            // Arrange
            var obj = new LargestNumber();

            // Act
            var actual = obj.plusOne(input.ToList());

            // Assert
            actual.Should().BeEquivalentTo(expected.ToList());
        }
    }
}
