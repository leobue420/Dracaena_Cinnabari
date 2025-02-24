// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//implicit conversion

int blob = 42;
double wlob = blob;
float fwop = blob;
long lwop = blob;


//explicit conversion
long mylong = 777;
int interstellar = (int)mylong; //by writing(int) or (double) or (long) or (float) you change  the type but be aware of the fitting into each other

Console.WriteLine(interstellar); 
Console.ReadKey();
