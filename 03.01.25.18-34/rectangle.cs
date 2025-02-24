namespace rectangle;
internal class Regtangle
{
    public double Width {get; set;}

    public double Height{get; set;}

    //computed property
    public double Area
    {
        get {return Width * Height;}
    }

}
