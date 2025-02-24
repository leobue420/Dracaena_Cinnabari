namespace _09._01._25;
using MyQuizApp;

class Program
{
    static void Main(string[] args)
    {
    

        Question[] questions = new Question[]
        {
            new Question(
                "What is the capital of Germany?", 
                new string[] {" Paris", " Berlin", " London", " Madrid"},
                 1 ),
            new Question(
                 "What is 2+2?", 
                 new string[] {"3", " 4", " 5", " 8"},
                 1 ),
                 new Question(
                 "Where are my Panties?", 
                 new string[] {"here", " there", " Datenschutz", " anywhere"},
                 2 )

                 
        };

        

        Quiz myQuiz = new Quiz(questions);
        // myQuiz.DisplayQuestion(questions[0]);
        myQuiz.StartQuiz();
        Console.ReadLine();



        // Console.WriteLine("Hello, World!");
    }
}
