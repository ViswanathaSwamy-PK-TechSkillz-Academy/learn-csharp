/* 
    Using VB.NET style namespace aliasing. We are using VB.NET Library in this C# program.
*/
using MathServices.MathLibrary;
using MathServicesCSLib;

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("Hello .NET 8 World!"); /* This is a statement and it ends with semi colon. */

Console.Write("Enter your name: ");
var name = Console.ReadLine();
Console.WriteLine($"Hello {name}!");

Console.ForegroundColor = ConsoleColor.Magenta;

int num1 = 10, num2 = 20; /* Variable declaration and initialization. */
Maths maths = new(); /* Instantiation of Maths VB.NET Lib class. */
Console.WriteLine($"Maths VB.NET Lib => {num1} + {num2} = {maths.AddNumbers(num1, num2)}");

/* Accessing static members of a class. */
Console.WriteLine($"Maths VB.NET Lib Static Method => {num1} + {num2} = {Maths.AddNumbersV1(num1, num2)}");
Console.WriteLine($"Maths VB.NET Lib Static Member => Max value: {Maths.MaxValue}");

Console.WriteLine($"Maths VB.NET Lib Static Member => Maths.MaxValue: {Maths.MaxValue.GetType()}.");
int maxValue = Maths.MaxValue;
Console.WriteLine($"(C# Variable) Max value: {maxValue} and its type {maxValue.GetType()}.");

Console.ForegroundColor = ConsoleColor.DarkCyan;

MathsCS mathsCs = new(); /* Instantiation of Maths C# Lib class. */
Console.WriteLine($"Maths C# Lib => {num1} + {num2} = {mathsCs.AddNumbers(num1, num2)}");

/* Accessing static members of a class. */
Console.WriteLine($"Maths C# Lib Static Method => {num1} + {num2} = {MathsCS.AddNumbersV1(num1, num2)}");
Console.WriteLine($"Maths C# Lib Static Member => Max value: {MathsCS.MaxValue}");

Console.WriteLine($"Maths C# Lib Static Member => Maths.MaxValue: {MathsCS.MaxValue.GetType()}.");
maxValue = MathsCS.MaxValue;
Console.WriteLine($"(C# Variable) Max value: {maxValue} and its type {maxValue.GetType()}.");

Console.ResetColor();

/* The dot operator (.) is used to access members of a namespace, type, or object. */
Console.WriteLine("Press any key to exit.");
Console.ReadKey();
