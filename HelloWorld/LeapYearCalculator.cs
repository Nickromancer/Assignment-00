namespace HelloWorld;

public class LeapYearCalculator 
{
    public bool IsLeapYear(int year) 
    {
        if(year < 1582) throw new ArgumentException("The year must be over 1581");
        if(year % 4 == 0) 
        {
            if(year % 100 == 0 && year % 400 != 0) return false;
            return true;
        }
        return false;
    }
}