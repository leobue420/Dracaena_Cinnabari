namespace _13._01._25._18_21;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
      //this array list has an infinite amount of objects
        ArrayList myArrayList = new ArrayList();
        //this array list has 100 objects
        ArrayList myArrayList2 = new ArrayList(100);

       

        myArrayList.Add(25);
        myArrayList.Add("hello");
        myArrayList.Add(15.12);
        myArrayList.Add(13);
        myArrayList.Add(444);
        myArrayList.Add(13);
        myArrayList.Add(42.4);

        //will delete element with specific value from list
        myArrayList.Remove(13);
        myArrayList.Remove(13);

        myArrayList.RemoveAt(0);


        Console.WriteLine(myArrayList.Count);

        double Sum = 0;

        foreach (object obj in myArrayList)
        {
          if (obj is int)
          {
            Sum += Convert.ToDouble(obj);
          }  
          else if(obj is double)
          {
            Sum += (double)obj;
          }
          else if(obj is string)
          {
            Console.WriteLine(obj);
          }
        }

        Console.WriteLine(Sum);

    Console.WriteLine("Hello, World!");
    Console.ReadKey();

    }
}
