namespace _18._02._25._13_11;

public delegate int Comparison<T> (T x, T y);

public class Person
{
    public int Age {get; set;}

    public string Name {get; set;}
}

public class PersonSorter
{
    public void Sort(Person[] people, Comparison<Person> comparison)
    {
        for (int i = 0; i < people.Length -1; i++)
        {
            for (int j = i+1; j < people.Length; j++)
            {

                //comparing people[i] and people[j] using the provided comparison delegate
                if (comparison(people[i], people[j]) > 0)
                {
                    //swap people i anj j if they are in the wrong order
                    Person TemprarilyStoredPerson = people[i];
                    people[i] = people[j]; 
                    people[j] = TemprarilyStoredPerson;
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        Person[] people =
        {
            new Person {Name = "Pusscat", Age = 9},
            new Person {Name = "Friedo", Age = 3},
            new Person {Name = "Roosmoos", Age = 2},
            new Person {Name = "Bob", Age = 42}
        };

        PersonSorter sorter = new PersonSorter();
        sorter.Sort(people, ComparebyAge);

        foreach(Person person in people)
        {
            Console.WriteLine($"Person Name: {person.Name} and Age: {person.Age}");
        }

        sorter.Sort(people, ComparebyName);

        foreach(Person person in people)
        {
            Console.WriteLine($"Person Name: {person.Name} and Age: {person.Age}");
        }

        Console.ReadKey();
        Console.WriteLine("Hello, World!");
    }

    static int ComparebyAge(Person x, Person y)
    {
       return x.Age.CompareTo(y.Age);
    }

    static int ComparebyName(Person x, Person y)
    {
        return x.Name.CompareTo(y.Name);
    }
}
