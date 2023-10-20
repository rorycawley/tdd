namespace todolist.Tests;
using todolist;

public class MulticurrencyReportTest
{
    [Fact]
    public void Add_ReturnsSumOfTwoNumbers()
    {
        // Arrange
        var math = new MulticurrencyReport();

        // Act
        var result = math.Add(1, 2);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Mult_ReturnsFactorOfTwoNumbers()
    {
        // Arrange
        var math = new MulticurrencyReport();

        // Act
        var result = math.Mult(1, 2);

        // Assert
        Assert.Equal(2, result);
    }
}

