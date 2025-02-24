namespace doubleit;

internal class doubleit
{
public int number1{get; set;}
public int result{get; set;}

public doubleit(int Number1)
{
    number1 = Number1;

}

public void timestwo(int result)
    {
        result = number1 * 2;
    }

}