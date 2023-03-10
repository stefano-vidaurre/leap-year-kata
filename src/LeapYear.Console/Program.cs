// See https://aka.ms/new-console-template for more information


public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsLeapYear(400));

        
    }
    
    public static bool IsLeapYear(int year)
    {
        if (year == 0)
        {
            return true;
        }
        
        if (year % 400 == 0)
        {
            return true;
        }

        if (year % 100 == 0)
        {
            return false;
        }

        return year % 4 == 0;
    }
}