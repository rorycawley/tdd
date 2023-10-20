namespace todolist.Tests;

using System;
using System.Collections.Generic;
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
        Dollar five = new Dollar(5);

        // Act
        five.times(2);

        // var math = new MulticurrencyReport();

        // var result = math.Mult(1, 2);

        // Assert
        Assert.Equal(10, five.amount);
    }
}

class Dollar
{
    internal int amount;


    public Dollar(int v)
    {
        this.amount = v;
    }

    public void times(int multiplier)
    {
        amount = amount * multiplier;
    }
}