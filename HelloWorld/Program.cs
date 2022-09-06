using HelloWorld;

Console.WriteLine("Please Enter a Year:");
var input = Console.ReadLine();
var inputnumber = Int32.Parse(input);

var calculator = new LeapYearCalculator();

bool result = calculator.IsLeapYear(inputnumber);

if(result) Console.WriteLine("yay"); 
else Console.WriteLine("nay");