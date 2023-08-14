using ProgramStructureDemoV2.Services;

// Uncomment the following line to see the exception with Program.<Main>$(String[] args) method.
// throw new Exception("This is an exception");

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Hello .NET 8 World!"); /* This is a statement and it ends with semi colon. */

Console.WriteLine("Enter your name: ");
var name = Console.ReadLine();
Console.WriteLine($"Hello {name}!");

int num1 = 10, num2 = 20; /* Variable declaration and initialization. */
Maths maths = new(); /* Instantiation of Maths class. */
Console.WriteLine($"{num1} + {num2} = {maths.AddNumbers(num1, num2)}");

/* Accessing static members of a class. */
Console.WriteLine($"{num1} + {num2} = {Maths.AddNumbersV1(num1, num2)}");
Console.WriteLine($"Max value is {Maths.MaxValue}");

Console.ResetColor();

/* The dot operator (.) is used to access members of a namespace, type, or object. */
Console.WriteLine("Press any key to exit.");
Console.ReadKey();
