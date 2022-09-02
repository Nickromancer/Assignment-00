namespace HelloWorld.tests;

public class LeapYearCalculatorTests
{
    [Fact]
    public void IsLeapYear_given_4_returns_true()
    {
        //Arrange
        var sut = new LeapYearCalculator();

        //Act
        var result = sut.IsLeapYear(4);

        //Assert
        Assert.Equal(true, result);
    }

    [Fact]
    public void IsLeapYear_given_1_returns_false()
    {
        //Arrange
        var sut = new LeapYearCalculator();

        //Act
        var result = sut.IsLeapYear(1);

        //Assert
        Assert.Equal(false, result);
    }

    [Fact]
    public void IsLeapYear_given_200_returns_false()
    {
        //Arrange
        var sut = new LeapYearCalculator();

        //Act
        var result = sut.IsLeapYear(200);

        //Assert
        Assert.Equal(false, result);
    }

    [Fact]
    public void IsLeapYear_given_1600_returns_true()
    {
        //Arrange
        var sut = new LeapYearCalculator();

        //Act
        var result = sut.IsLeapYear(1600);

        //Assert
        Assert.Equal(true, result);
    }
}