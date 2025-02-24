namespace _30._01._25;

class Employee
{
public string Name {get; set;}
public int Age {get; set;}

public int Salary {get; set;}

public Employee(string name, int age, int salary)
{
    this.Name = name; 
    this.Age = age;
    this.Salary = salary;
}

}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

        employees.Add(1, new Employee("Telekom", 35, 22 ));
        employees.Add(2, new Employee("Tellekom", 45, 2 ));
        employees.Add(20, new Employee("Telekoom", 36, 12 ));
        employees.Add(17, new Employee("Teellekom", 15, 32 ));
        employees.Add(42, new Employee("Ttelekomm", 42, 42 ));

        foreach (var item in employees)
        {
            Console.WriteLine($"ID: {item.Key} named: {item.Value.Name}, Age: {item.Value.Age}, Salary: {item.Value.Salary}  ");
        }


        Console.WriteLine("Hello, World!");

    }
}
