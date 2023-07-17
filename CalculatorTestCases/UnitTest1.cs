using System;
using Xunit;

public class CalculatorTests
{
    private readonly ICalculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Add_WhenCalled_ReturnsCorrectResult()
    {
        // Arrange
        int a = 10;
        int b = 5;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Subtract_WhenCalled_ReturnsCorrectResult()
    {
        // Arrange
        int a = 10;
        int b = 5;

        // Act
        int result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Multiply_WhenCalled_ReturnsCorrectResult()
    {
        // Arrange
        int a = 10;
        int b = 5;

        // Act
        int result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(50, result);
    }

    [Fact]
    public void Divide_WhenCalledWithValidInput_ReturnsCorrectResult()
    {
        // Arrange
        int a = 10;
        int b = 5;

        // Act
        int result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void Divide_WhenCalledWithZero_ThrowsDivideByZeroException()
    {
        // Arrange & Act & Assert
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
    }
}
