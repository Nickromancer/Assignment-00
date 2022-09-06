namespace HelloWorld.tests;

public class LeapYearCalculatorTests
{
    [Fact]
    public void IsLeapYear_given_2004_returns_true()
    {
        //Arrange
        var sut = new LeapYearCalculator();

        //Act
        var result = sut.IsLeapYear(2004);

        //Assert
        Assert.Equal(true, result);
    }

    [Fact]
    public void IsLeapYear_given_1583_returns_false()
    {
        //Arrange
        var sut = new LeapYearCalculator();

        //Act
        var result = sut.IsLeapYear(1583);

        //Assert
        Assert.Equal(false, result);
    }

    [Fact]
    public void IsLeapYear_given_2000_returns_false()
    {
        //Arrange
        var sut = new LeapYearCalculator();

        //Act
        var result = sut.IsLeapYear(1900);

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

    [Fact]
    public void IsLeapYear_throws_Argument_Exception_given_1581()
    {
        //Arrange
        var sut = new LeapYearCalculator();

        //Act
        var input = 1581;

        //Assert
        Assert.Throws<ArgumentException>(() => sut.IsLeapYear(input));
    }
}