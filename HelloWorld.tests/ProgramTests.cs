namespace HelloWorld.tests;

public class ProgramTests
{
    [Fact]
    public void ConsolePrintsPrompt()
    {
        // Arrange
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        var program = Assembly.LoadFrom("HelloWorld.dll");
        program?.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().Trim();

        // Assert
        Assert.Equal("Please Enter a Year:", output);
    }
}