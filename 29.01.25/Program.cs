using System.Collections;
using System.Xml.Schema;

namespace _29._01._25;

class Program
{
    //Key - Value
    //Auto - Car


    static void Main(string[] args)
    {
        
        Hashtable studentsTable = new Hashtable();

        Student stud1 = new Student(1, "Mario", 96);
        Student stud2 = new Student(2, "Maria", 97);
        Student stud3 = new Student(3, "Marie", 98);
        Student stud4 = new Student(4, "Marill", 99);

        studentsTable.Add(stud1.Id, stud1);
        studentsTable.Add(stud2.Id, stud2);
        studentsTable.Add(stud3.Id, stud3);
        studentsTable.Add(stud4.Id, stud4);

        Student storedStudent1 = (Student)studentsTable[stud1.Id];
        
        Console.WriteLine("Hello, World!");
        
       //Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);

        // foreach (DictionaryEntry entry in studentsTable)
        // {
        //     Student temp = (Student)entry.Value;
        //     Console.WriteLine("Student ID: {0}",temp.Id);
        //     Console.WriteLine("Student Name: {0}",temp.Name);
        //     Console.WriteLine("Student GPA: {0} \n ",temp.GPA);
            
        // }

        foreach (Student value in studentsTable.Values)
        {
            Console.WriteLine("Student ID: {0}",value.Id);
            Console.WriteLine("Student Name: {0}",value.Name);
            Console.WriteLine("Student GPA: {0} \n ",value.GPA);
        }

    }


    class Student
    {
        //property called ID
        public int Id {get; set;}

        //property called name
        public string Name {get; set;}

        //property called GPA

        public float GPA {get; set;}

        //simple constructor
        public Student(int id, string name, float gpa)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}
