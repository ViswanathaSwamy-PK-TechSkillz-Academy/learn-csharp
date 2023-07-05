// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int age; // declaring
age = 18; // initializing
// int age = 25; /* declaring and initializing */

Console.WriteLine(age);

age = 25; // re-initializing
Console.WriteLine(age);

/* Using + symbol to string concatenate is a BAD practice. */
Console.WriteLine("Byte: 1 byte of memory. Its Min and Max Values are " + byte.MinValue + " and " + byte.MaxValue);
Console.WriteLine("SByte: 1 byte of memory. Its Min and Max Values are " + sbyte.MinValue + " and " + sbyte.MaxValue);
Console.WriteLine("Short: 2 bytes of memory. Its Min and Max Values are " + short.MinValue + " and " + short.MaxValue);
Console.WriteLine("UShort: 2 bytes of memory. Its Min and Max Values are " + ushort.MinValue + " and " + ushort.MaxValue);
Console.WriteLine("Int: 4 bytes of memory. Its Min and Max Values are " + int.MinValue + " and " + int.MaxValue);
Console.WriteLine("UInt: 4 bytes of memory. Its Min and Max Values are " + uint.MinValue + " and " + uint.MaxValue);
Console.WriteLine("Long: 8 bytes of memory. Its Min and Max Values are " + long.MinValue + " and " + long.MaxValue);
Console.WriteLine("ULong: 4 bytes of memory. Its Min and Max Values are " + ulong.MinValue + " and " + ulong.MaxValue);
