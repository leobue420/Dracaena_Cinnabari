using System.Runtime.CompilerServices;

namespace _21._12._24._14_20;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of days to simulate!");
        int days = Convert.ToInt32(Console.ReadLine());

        int[] temperature = new int[days];
        string[] conditions = {"sunny", "rainy", "cloudy", "foggy", "snowy"};
        string[] weatherconditions = new string[days];

        Random random = new Random();

        for (int i = 0; i < days; i++)
        {
            temperature[i] = random.Next(-10,40);
            weatherconditions[i] = conditions[random.Next(conditions.Length)];


            string temperatureoutput = temperature[i].ToString();
            string weatherconditionsoutput = weatherconditions[i];

            Console.WriteLine($"it is {temperatureoutput} degrees and is {weatherconditionsoutput}");
          
        }
        temperature.Max();      
        Console.WriteLine($"the average temperature is {CalculateAverage(temperature)}");
        Console.WriteLine($"the max temperature is {temperature.Max()}");
        Console.WriteLine($"the min temperature is {temperature.Min()}");
        Console.WriteLine($"the min temperature is {MinTemperature(temperature)}");
        Console.WriteLine($"the most common condition is is {MostCommonCondition(weatherconditions)}");
        Console.ReadLine();
    }



static string MostCommonCondition(string[] conditions)
{
    int count = 0;
    string mostCommon = conditions[0];

    for (int i = 0; i < conditions.Length; i++)
    {
        int tempCount = 0;
        for (int j = 0; j < conditions.Length; j++)
        {
            if(conditions[j]==conditions[i])
            {tempCount++;}
        }

        if(tempCount > count)
        {
            count = tempCount;
            mostCommon = conditions[i];
        }
    }
return mostCommon;
}

    static double CalculateAverage(int[] temperature)
    {
        int sum = 0;

        for (int i = 0; i < temperature.Length; i++)
        {
            sum+=temperature[i];
        }

        double average = sum/temperature.Length;

        return average;
    }

    // getting min and max temperature with an own method

    static int MinTemperature(int[] temperature)
    {
        int min = temperature[0];

        foreach (int temp in temperature)
        {
            if(temp<min)
            {
                min=temp;
            }
        }
        return min;
    }
}
