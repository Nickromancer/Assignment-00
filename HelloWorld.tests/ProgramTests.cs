namespace HelloWorld.tests;

public class ProgramTests
{
    /*
    [Fact]
    public void ConsolePrintsPrompt()
    {
        // Arrange
        var reader = new StringReader("4");
        Console.SetIn(reader);
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        var program = Assembly.LoadFrom("HelloWorld.dll");
        program?.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().Trim();

        // Assert
        Assert.Equal("Please Enter a Year:", output);
    }

    /*
    [Fact]
    public void HasInput()
    {
        // Arrange
        var reader = new StringReader("4");
        Console.SetIn(reader);

        // Act
        var program = Assembly.LoadFrom("HelloWorld.dll");
        program?.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        // Assert
        Assert.Equal("4", input);
    }

    [Fact]
    public void GivenInput4OutputsTrue() {
         // Arrange
        var reader = new StringReader("4");
        Console.SetIn(reader);
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        var program = Assembly.LoadFrom("HelloWorld.dll");
        program?.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().Trim();
        
        // Assert
        Assert.Equal("yay", output);
    }
    */
}