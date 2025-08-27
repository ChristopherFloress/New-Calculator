using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        
        public void Add_ReturnsCorrectSum()
        {
            var calc = new Calculator();
            Assert.Equal(4, calc.Add(2, 2));
        }
    }
}