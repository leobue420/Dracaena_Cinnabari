// using System;
// using System.Security.Cryptography;

namespace blob
{
    internal class Car
    // its internal so it can only be accessed from within the same assembly, other programs cannot access this class
    {
        //member variable
        // private hides the variable from other classes
        // backing field for the blueprints
        public string _model = "";
        private string _age = "";

        private bool _luxury;

        //property

       //public string Model { get; set;}

        public string Model 
        {get
        {
            if(_luxury)
            {return _model + " luxury edition";}
            else
            return _model;
        }
        
         set => _model = value; } 


         // same effect as lambda expression

        //  public string Model
        //  {
        //     get 
        //     {
        //         return _model;
        //     }
        //     set
        //     {
        //         _model = value;
        //     }
        //  }


         public string Age
         
        { get => _age; 
         
         set {
            if(string.IsNullOrEmpty(value))
            {
                Console.WriteLine("you entered NOTHING");
                _age = "DEFAULTVALUE";
            }
            else
             _age = value;
            } 
           } 


//lambda expression
        public bool Luxury {get => _luxury; set => _luxury = value;} 


        public Car(string model, string age, bool luxury )
        {
            Model = model;
            Age = age; 
            _luxury = luxury;

            Console.WriteLine($"an object of car has been created! its name is {_model} and its {age} years old");

        }
        //properties, constructors, methods go here
    }
}