using FluentAssertions;
using NUnit.Framework;

namespace CodingTasks.Tests
{
    [TestFixture]
    public class RedundantBracesTests
    {
        [TestCase("((a+b))", 1)]
        [TestCase("(a+(a+b))", 0)]
        [TestCase("(a)", 1)]
        [TestCase("b+a", 0)]
        public void Should_Pass_Cases(string input, int expected)
        {
            // Arrange
            var obj = new RedundantBraces();

            // Act
            var actual = obj.braces(input);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
