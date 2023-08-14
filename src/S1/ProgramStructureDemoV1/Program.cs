/*
    File: Program.cs
    Author: Viswanatha Swamy
    Created On: 14-Aug-2023
*/

using System;
using ProgramStructureDemoV1.Services;

/// <summary>
/// This is a demo program to show the structure of a C# program.
/// </summary>
namespace ProgramStructureDemo
{
    // Program is a class is the container of the program. It is the entry point of the program.
    class Program
    {

        // Main method is the entry point of the program
        static void Main(string[] args)
        { /* Block of code Starts here */

            Console.ForegroundColor = ConsoleColor.DarkCyan;

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

            // Console.ReadKey(); & Console.Readkey(); are different /* C# is a case sensitive language. */

        } /* Block of code Ends here */
    }

}
