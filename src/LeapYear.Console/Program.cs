// See https://aka.ms/new-console-template for more information


public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsLeapYear(400));

        
    }
    
    public static bool IsLeapYear(int year)
    {
        return year == 0 || year == 400;
    }
}