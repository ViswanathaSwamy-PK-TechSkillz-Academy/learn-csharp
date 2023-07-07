Console.WriteLine("Hello .NET 8 World!");

Console.WriteLine(Maths.AddNumbers(2, 4));

Console.WriteLine("Press any key to exit.");
Console.ReadKey();

public class Maths
{

    public static int AddNumbers(int a, int b)
    {
        return a + b;
    }

}