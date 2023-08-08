int age; // declaring
// Console.WriteLine(age); // error: use of unassigned local variable 'age'

age = 18; // initializing
Console.WriteLine(age); // error: use of unassigned local variable 'age'

Console.WriteLine("What is your age?"); // asking for input
age = int.Parse(Console.ReadLine()!); // reading input and converting it to int
Console.WriteLine($"Your age is {age}"); // string interpolation

int rollNumber = 1, marks = 100; // declaring and initializing multiple variables
Console.WriteLine($"{rollNumber} {marks}"); // string interpolation

Console.WriteLine($"Int: {sizeof(int)} byte(s) of memory. Its Min and Max Values are {int.MinValue} and {int.MaxValue}");

age = 25; // re-initializing
Console.WriteLine(age);

Console.WriteLine(int.Parse("123")); // converting string to int

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"You entered {number}");
Console.WriteLine($"Square of {number} is {Add(number, number)}");

static int Add(int a, int b) // method declaration
{
    return a + b; // method body
}

/* Using + symbol to string concatenate is a BAD practice. */
// Console.WriteLine("Byte: 1 byte of memory. Its Min and Max Values are " + byte.MinValue + " and " + byte.MaxValue);
// Console.WriteLine("SByte: 1 byte of memory. Its Min and Max Values are " + sbyte.MinValue + " and " + sbyte.MaxValue);
// Console.WriteLine("Short: 2 bytes of memory. Its Min and Max Values are " + short.MinValue + " and " + short.MaxValue);
// Console.WriteLine("UShort: 2 bytes of memory. Its Min and Max Values are " + ushort.MinValue + " and " + ushort.MaxValue);
// Console.WriteLine("Int: 4 bytes of memory. Its Min and Max Values are " + int.MinValue + " and " + int.MaxValue);
// Console.WriteLine("UInt: 4 bytes of memory. Its Min and Max Values are " + uint.MinValue + " and " + uint.MaxValue);
// Console.WriteLine("Long: 8 bytes of memory. Its Min and Max Values are " + long.MinValue + " and " + long.MaxValue);
// Console.WriteLine("ULong: 4 bytes of memory. Its Min and Max Values are " + ulong.MinValue + " and " + ulong.MaxValue);
