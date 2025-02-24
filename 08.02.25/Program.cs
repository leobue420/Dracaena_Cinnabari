using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Principal;
// You can remove Microsoft.VisualBasic if not used

namespace _08._02._25;

class Program
{
    // The Main method is the entry point of our program. It's set to async because we're calling an async method later.
    static async Task Main(string[] args)
    {
        // Creating an instance of ClassEmployee named Babu1 with the given details.
        ClassEmployee Babu1 = new ClassEmployee("Jörg", 22, "Manager", 420000, 1);

        // Calling the ShowPersonInfo method to display basic personal information.
        Babu1.ShowPersonInfo();
        // Calling the ShowEmployeeInfo method to display employee-specific information.
        //Babu1.ShowEmployeeInfo();

        // // Printing a header for the currency conversion section.
        // Console.WriteLine("Real-Time Currency Conversion:");
        // // Calling the async method ShowSalaryInDifferentCurrencies to convert and display the salary in different currencies.
        // await Babu1.ShowSalaryInDifferentCurrencies(420000);

        // A simple greeting to confirm the program has run to completion.

        ClassManager Rosie = new ClassManager("Rosie", 4, "Gadsenboss", 5, 1,1);
        // Rosie.DisplayMananerInfo();

        Console.WriteLine(Rosie.ToString());
        Rosie.BecomeOlder(5);
        Rosie.DisplayMananerInfo();
       Rosie.ShowPersonInfo();


        Console.WriteLine("Hello, World!");
    }

    // The Person class is the base class for our inheritance structure.
    public class Person
    {
        // Name property, internal for access within the same assembly, private set to prevent external modification.
        internal string Name { get; private set; }
        // Age property, similar access rules as Name.
        internal int Age { get; private set; }


        /// <summary>
        /// Makes our object older!
        /// </summary>
        /// <param name="years"> The amount of yoeas the object should age</param>
        /// <returns>Returns the new age afteer ageing</returns>

        public int BecomeOlder(int years)
        {
            Age = Age+years;
            return Age;
        }

        // Constructor for Person, initializes Name and Age.
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Console.WriteLine("Person Constructor Called");
        }

        // Virtual method that can be overridden by derived classes to show person information.
        public virtual void ShowPersonInfo()
        {
            Console.WriteLine($"The name is {Name} and Age is {Age}");
        }

        
    }

    // ClassEmployee inherits from Person, adding employee-specific properties.
    public class ClassEmployee : Person
    {
        // Position property of the employee.
        public string Position { get; private set; }
        // Salary property of the employee.
        public decimal Salary { get; private set; }
        // API key for accessing the currency conversion API, kept private and constant.
        // private const string ApiKey = "fad0e0629e0a2610d788a7a8abc56fcf"; // Your API key

        public int EmployeeID {get; private set;}

        // Constructor for ClassEmployee, calls the base constructor to set Name and Age.
        public ClassEmployee(string name, int age, string position, decimal salary, int employeeID) : base(name, age)
        {
            Position = position;
            Salary = salary;
            this.EmployeeID = employeeID;
            Console.WriteLine("Employee Constructor Called");
        }

        // Method to display employee information.
        public void ShowEmployeeInfo()
        {
            Console.WriteLine($"Position: {Position}, Salary: {Salary:C}");
        }

        // Override of ShowPersonInfo to include employee details.
        public override void ShowPersonInfo()
        {
            base.ShowPersonInfo(); // Calls the base method first
            Console.WriteLine($"This employee ID: {EmployeeID} is a {Position} with a salary of {Salary:C}");
        }

        // This method is asynchronous, meaning it can perform operations that might take time, like API calls, without blocking the program.
        // public async Task ShowSalaryInDifferentCurrencies(decimal usdSalary)
        // {
        //     try
        //     {
        //         // Using HttpClient to make HTTP requests.
        //         using (var client = new HttpClient())
        //         {
        //             // Constructing the URL for the latest endpoint with the API key.
        //             string url = $"https://api.exchangeratesapi.io/v1/latest?access_key={ApiKey}&symbols=USD,EUR";

        //             // Making an asynchronous GET request to the API.
        //             HttpResponseMessage response = await client.GetAsync(url);
        //             // Ensuring the response was successful, otherwise it throws an exception.
        //             response.EnsureSuccessStatusCode();

        //             // Reading the content of the response as a string.
        //             string responseBody = await response.Content.ReadAsStringAsync();

        //             // Parsing the JSON response into a JObject for easy access to its properties.
        //             JObject jsonObject = JObject.Parse(responseBody);

        //             // Checking if the API call was successful by casting the 'success' value to boolean.
        //             if ((bool)jsonObject["success"])
        //             {
        //                 // Extracting the base currency from the JSON response.
        //                 string baseCurrency = (string)jsonObject["base"];
        //                 // Extracting the date when the rates were collected.
        //                 string date = (string)jsonObject["date"];
        //                 // Extracting the exchange rate from EUR to USD.
        //                 decimal eurToUsdRate = (decimal)jsonObject["rates"]["USD"];
        //                 // Extracting the exchange rate from EUR to EUR (which should always be 1).
        //                 decimal eurToEurRate = (decimal)jsonObject["rates"]["EUR"];

        //                 // Printing out the conversion rates
        //                 Console.WriteLine($"Exchange Rates as of {date}:");
        //                 Console.WriteLine($"1 {baseCurrency} = {eurToUsdRate:F6} USD");
        //                 Console.WriteLine($"1 {baseCurrency} = {eurToEurRate:F6} EUR");

        //                 // Calculating the exchange rate from USD to EUR by taking the reciprocal of EUR to USD rate.
        //                 decimal usdToEurRate = 1 / eurToUsdRate;

        //                 // Calculating the salary in Euros by multiplying USD salary with the calculated rate.
        //                 decimal salaryInEuros = usdSalary * usdToEurRate;

        //                 // Displaying the salary in USD with the default currency format.
        //                 Console.WriteLine($"Salary in USD: {usdSalary:C}");
        //                 // Displaying the salary in EUR with the correct Euro symbol by specifying the German culture.
        //                 Console.WriteLine($"Salary in EUR: {salaryInEuros.ToString("C", new System.Globalization.CultureInfo("de-DE"))}");
        //             }
        //             else
        //             {
        //                 // If the API call wasn't successful, we print an error message.
        //                 Console.WriteLine("Error: API call was not successful.");
        //             }
        //         }
        //     }
        //     catch (HttpRequestException e)
        //     {
        //         // Catching and reporting any HTTP request related errors.
        //         Console.WriteLine($"Error: {e.Message}");
        //     }
        //     catch (Exception e)
        //     {
        //         // Catching and reporting any other unexpected errors.
        //         Console.WriteLine($"An error occurred: {e.Message}");
        //     }
        // }
    }

    public class ClassManager : ClassEmployee
    {

        public int Teamsize {get; private set;}
        public ClassManager(string name, int age, string position, decimal salary, int employeeID, int teamsize) : base(name, age, position, salary, employeeID)
        {
            this.Teamsize = teamsize;
        }

        public void DisplayMananerInfo()
        {
            ShowEmployeeInfo();
            Console.WriteLine($"Team size: {Teamsize}");
        }


    }
}