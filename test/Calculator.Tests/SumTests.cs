using FluentAssertions;

namespace Calculator.Tests;

public class SumTests
{
    [Fact]
    public void Sum_Should_Return_The_Sum()
    {
        // Arrange
        Calc calculator = new();
        // Act
        int a = 2;
        int b = 3;
        var result = calculator.Sum(a, b);
        // Assert
        result.Should().Be(a + b);
    }
}