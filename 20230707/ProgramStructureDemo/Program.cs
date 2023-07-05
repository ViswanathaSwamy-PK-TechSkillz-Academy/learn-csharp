/*
    File: Program.cs
    Author: Viswanatha Swamy
    Created On: 7/7/2021 10:37:00 PM
*/

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

            Console.WriteLine("Hello .NET 8 World!"); /* This is a statement and it ends with semi colon. */

            /* The dot operator (.) is used to access members of a namespace, type, or object. */
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        } /* Block of code Ends here */
    }
}
