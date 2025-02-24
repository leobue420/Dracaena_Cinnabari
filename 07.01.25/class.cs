namespace Rectangle;

class Rectangle
{
    public const int NumberOfCorners = 4; // gonna be the same for all instances of the class

    public readonly string Colour; // Keep as readonly

    //constructor
    public Rectangle(string colour)
    {
        this.Colour = colour; // Use 'this' to refer to the field
    }

    public double Width { get; set; }

    public double Height { get; set; }

    public double Area => Width * Height;

    public void DisplayDetails()
    {
        Console.WriteLine($"Colour: {Colour}\nWidth: {Width}\nHeight: {Height}\nArea: {Area}\nNumber of Corners: {NumberOfCorners}");

    }

    
}