
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }
    
    [Fact]
    public void StringReturnsNumbers()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1");

        Assert.Equal(1, result);
    }
    
    [Fact]
    public void StringReturnsNumbersAdded()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1,2");

        Assert.Equal(3, result);
    }
    
    [Fact]
    public void StringReturnsManyNumbersAdded()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1,2,3");

        Assert.Equal(6, result);
    }

}
