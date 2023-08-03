using HeaderFooter;

Header _header = new();
Footer _footer = new();

_header.DisplayHeader('=', "A1 Integer Variables Demo");

ShowIntegeralTypes();
ShowIntegeralTypesV1();

_footer.DisplayFooter('-');

static void ShowIntegeralTypes()
{
    ForegroundColor = ConsoleColor.DarkCyan;

    WriteLine($"Byte: {sizeof(byte)} byte(s) of memory. Its Min and Max Values are {byte.MinValue} and {byte.MaxValue}");
    WriteLine($"SByte: {sizeof(sbyte)} byte(s) of memory. Its Min and Max Values are {sbyte.MinValue} and {sbyte.MaxValue}");

    WriteLine($"Short: {sizeof(short)} byte(s) of memory. Its Min and Max Values are {short.MinValue} and {short.MaxValue}");
    WriteLine($"UShort: {sizeof(ushort)} byte(s) of memory. Its Min and Max Values are {ushort.MinValue} and {ushort.MaxValue}");

    ResetColor();
}

static void ShowIntegeralTypesV1()
{
    ForegroundColor = ConsoleColor.Magenta;

    WriteLine($"Int: {sizeof(int)} byte(s) of memory. Its Min and Max Values are {int.MinValue} and {int.MaxValue}");
    WriteLine($"UInt: {sizeof(uint)} byte(s) of memory. Its Min and Max Values are {uint.MinValue} and {uint.MaxValue}");

    WriteLine($"Long: {sizeof(long)} byte(s) of memory. Its Min and Max Values are {long.MinValue} and {long.MaxValue}");
    WriteLine($"ULong: {sizeof(ulong)} byte(s) of memory. Its Min and Max Values are {ulong.MinValue} and {ulong.MaxValue}");

    ResetColor();
}