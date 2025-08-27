using Xunit;
// Add the correct using if Calculator is in a namespace
// using MyApp;

public class CalculatorTests    
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var calc = new Calculator();
        Assert.Equal(4, calc.Add(2, 2));
    }
}

public class Calculator    
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
    public int Divide(int a, int b) => a / b;
