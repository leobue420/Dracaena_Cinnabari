using System.Collections;
using System.Dynamic;

namespace _13._01._25._20._08;

class Program
{
    static void Main(string[] args)
    {

        //Hashtables, they are old but needed possibly in random situations

        Hashtable studentsTable = new Hashtable();

        Student stud1 = new Student(1,"hdfjk",66);
        Student stud2 = new Student(2,"oaoao",67);
        Student stud3 = new Student(3,"sfjkjsk",68);
        Student stud4 = new Student(4,"hksjd",69);
        Student stud5 = new Student(5,"nfmds",70);

        studentsTable.Add(stud1.ID, stud1);
        studentsTable.Add(stud2.ID, stud2);
        studentsTable.Add(stud3.ID, stud3);
        studentsTable.Add(stud4.ID, stud4);
        studentsTable.Add(stud5.ID, stud5);

        Student storedStudent1 = (Student)studentsTable[stud1.ID];

        Console.WriteLine($"StudentID: {0}, Name: {1}, GPA:{2}", storedStudent1.ID, storedStudent1.Name, storedStudent1.GPA);



        Console.WriteLine("Hello, World!");

        
    }

    class Student 
    {
 //property called ID
 public int ID {get; set;}

 //property called name
 public string Name {get; set;}

 //property called GPA
 public float GPA {get; set;}


//simple constructor

public Student(int id, string name, float gpa)
{
    this.ID = id;
    this.Name = name;
    this.GPA = gpa;
}
    }
}
