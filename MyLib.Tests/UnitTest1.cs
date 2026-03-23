using MyLibSolution;

namespace MyLib.Tests;


public class CalculatorTests
{
    private readonly Calculator _calc = new();

    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        var result = _calc.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calc.Divide(10, 0));
    }

    [Theory]
    [InlineData(10, 3, 7)]
    [InlineData(0, 0, 0)]
    public void Subtract_ReturnsCorrectResult(int a, int b, int expected)
    {
        Assert.Equal(expected, _calc.Subtract(a, b));
    }
}