using HeaderFooter;

Header _header = new();
Footer _footer = new();

_header.DisplayHeader('=', "A1 Integer Variables Demo");

ForegroundColor = ConsoleColor.DarkCyan;

WriteLine($"Byte: {sizeof(byte)} byte of memory. Its Min and Max Values are {byte.MinValue} and {byte.MaxValue}");
WriteLine($"SByte: {sizeof(sbyte)} byte of memory. Its Min and Max Values are {sbyte.MinValue} and {sbyte.MaxValue}");

ResetColor();

_footer.DisplayFooter('-');


// Console.WriteLine(": 1 byte of memory. Its Min and Max Values are " + sbyte.MinValue + " and " + sbyte.MaxValue);
// Console.WriteLine("Short: 2 bytes of memory. Its Min and Max Values are " + short.MinValue + " and " + short.MaxValue);
// Console.WriteLine("UShort: 2 bytes of memory. Its Min and Max Values are " + ushort.MinValue + " and " + ushort.MaxValue);
// Console.WriteLine("Int: 4 bytes of memory. Its Min and Max Values are " + int.MinValue + " and " + int.MaxValue);
// Console.WriteLine("UInt: 4 bytes of memory. Its Min and Max Values are " + uint.MinValue + " and " + uint.MaxValue);
// Console.WriteLine("Long: 8 bytes of memory. Its Min and Max Values are " + long.MinValue + " and " + long.MaxValue);
// Console.WriteLine("ULong: 4 bytes of memory. Its Min and Max Values are " + ulong.MinValue + " and " + ulong.MaxValue);
