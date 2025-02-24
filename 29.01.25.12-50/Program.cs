using System.Dynamic;

namespace _29._01._25._12_50;

class Employee
{
string Name {get; set;}
int Age {get; set;}

int Salary{get; set;}

Employee(string name, int age, int salary)
{
    Name = name;
    Age = age;
    Salary = salary;
}

}

class Program
{
    static void Main(string[] args)
    {
        // int myAge = 20;

        // Console.WriteLine("Hello, World!");

        // int? age = null; //int? is nullable

        // if(age.HasValue)
        // {
        //     Console.WriteLine($"Age is: {age.Value}");
        //     int sum = age.Value + myAge;
        // }
        // else
        // {
        // Console.WriteLine($"Age is: not specified");

        
        // }


        //DICTIONARIES

        // each key has a value

        //declaring and initializing a Dictionary

        Dictionary<int, string> employees = new Dictionary<int, string>();

        employees.Add(101, "Telekom");
        employees.Add(99, "bonobob");
        employees.Add(98, "Telekoomm");
        employees.Add(97, "bonnobob");
        employees.Add(102, "Teleekom");
        employees.Add(103, "boonobob");
        // employees.Add(1, "numberone");

        string name = employees[101];

        Console.WriteLine(name);

        
        //update data in a dictionary
        employees[99] = "upgrade zu >bonoboss< ";

        employees.Remove(101);
        employees.Remove(98);

        // foreach (KeyValuePair<int, string> employee in employees)
        // {
        //    Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}"); 
        // } //Verbesserte Version ist unten

          if (!employees.ContainsKey(104))
        {
            employees.Add(104,"nummer einhundertundvier");
        }

        int counter = 105;
        while(employees.ContainsKey(counter))
        {
            counter++;
        }
        employees.Add(counter,"Jesus Christ");

        bool added100 = employees.TryAdd(100, "why is this number not taken yet??");
        if (!added100)
        {
            Console.WriteLine("100 is already taken, sorry");
        }

        var sortedEmployees = employees.OrderBy(x => x.Key).ToList();

        foreach (var employee in sortedEmployees)
                {
                    Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
                }



        // To display free key numbers, we first determine the range of existing keys
        int minKey = employees.Keys.Min();
        int maxKey = employees.Keys.Max();


        //then print them.
         Console.WriteLine("\nAvailable employee IDs:");
        for (int i = minKey; i <= maxKey; i++)
        {
            if (!employees.ContainsKey(i))
            {
                Console.WriteLine($"ID: {i}");
            }
        }

        


        Console.ReadLine();
     }
}
