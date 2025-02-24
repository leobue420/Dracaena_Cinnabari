using System.Dynamic;

namespace _16._02._25._18_17;

class Program
{
    static void Main(string[] args)
    {

        DateTime dateTime = new DateTime(2004, 04, 20);

        Console.WriteLine($"a good day to celebrate is: {dateTime}");

        //write today on screen
        Console.WriteLine(DateTime.Today);

        Console.WriteLine(DateTime.Now);

        DateTime tomorrow = GetTomorrow();
        Console.WriteLine($"Tomorrow will be the: {tomorrow} ");

        Console.WriteLine(DateTime.DaysInMonth(2025, 2)); // For February 2025
        var culture = new System.Globalization.CultureInfo("en-US"); // or any other culture
        Console.WriteLine(culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek));
        Console.WriteLine(GetFirstDayOfYear(2004));
        
        int days = DateTime.DaysInMonth(2004, 04);
        Console.WriteLine($"Days in April 2004 were {days}");

        DateTime now = DateTime.Now;
        Console.WriteLine($"Minute: {now.Minute}");

        //display the time in this structure x o clock and y minutes and z seconds
        int currentYear = DateTime.Now.Year;
       int currentMonth = DateTime.Now.Month;
        int currentDay = DateTime.Now.Day;
        int currentHOur = DateTime.Now.Hour;
        int currentMinute = DateTime.Now.Minute;
        int currentSecond = DateTime.Now.Second;
        Console.WriteLine($"it is the {currentDay} of {currentMonth} in the year {currentYear} at {currentHOur} o clock and {currentMinute} minutes and {currentSecond} seconds");
        
        Console.WriteLine("Write a day in this format: yyyy-mm-dd");
        string input = Console.ReadLine();
        if(DateTime.TryParse(input, out dateTime))
        {
            Console.WriteLine(dateTime);
            TimeSpan DaysPassed = now.Subtract(dateTime);
            Console.WriteLine($"Days passed since {DaysPassed.Days}");
        }
        else
        {
            Console.WriteLine("Wrong Input");
        }

        Console.WriteLine("Hello, World!");
    }

    static DateTime GetTomorrow()
{
    return DateTime.Today.AddDays(1);
}

    static DateTime GetFirstDayOfYear(int year)
    {
        return new DateTime(year,1,1);
    }

}

