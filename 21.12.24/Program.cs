namespace _21._12._24;

class Program
{
    //field or instance variable sometimes even global variable
     int myResult;


    static void Main(string[] args)
    {
        //methods are structured like this:
        // modifier returntype methodname(parameters){code}
        
   
   

        Console.WriteLine("Enter a number and ill add 10 to it!");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Program myProgram = new Program();

        myResult = addTwoValues(num1,10);
        Console.WriteLine($"The result is {myResult}");
        Console.ReadKey();
    }
static int addTwoValues(int value1, int value2)
{
    int result = value1 + value2;
    return result;
}

static int subtractTwovalues(int value1, int value2)
        {
            int result = (value1 - value2);
            return result;

        }

}
