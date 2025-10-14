namespace ToDoList.Test;

public class CalculatorTests
{
    [Fact]
    public void Calculator_Add_ShouldReturnCorrectResult()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 5;
        int b = 3;

        // Act
        int result = calculator.Add(a, b);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Calculator_Divide_ShouldThrowDivideByZeroException()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 10;
        int b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
    }
}

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }
}
