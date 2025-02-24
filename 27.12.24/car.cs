using System;
using System.Security.Cryptography;

namespace ClassesApp
{
    internal class Car
    // its internal so it can only be accessed from within the same assembly, other programs cannot access this class
    {
        //member variable
        // private hides the variable from other classes
        private string _model = "";
        private string _age = "";

        public Car(string model, string age)
        {
            _model = model;
            _age = age; 

            Console.WriteLine($"an object of car has been created! its name is {_model} and its {age} years old");

        }
        //properties, constructors, methods go here
    }
}