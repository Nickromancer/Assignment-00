using HelloWorld;

Console.WriteLine("Please Enter a Year:");
var input = Console.ReadLine();

var inputnumber = 0;

try 
{
    inputnumber = Int32.Parse(input);
}
catch (FormatException e) 
{
    Console.WriteLine(e.Message);
    return;
}

var calculator = new LeapYearCalculator();

bool result = false;

try 
{
    result = calculator.IsLeapYear(inputnumber);
}
catch (ArgumentException e) {
    Console.WriteLine(e.Message);
    return;
}


if(result) Console.WriteLine("yay"); 
else Console.WriteLine("nay");