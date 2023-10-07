using HeaderFooter;

Header _header = new();
Footer _footer = new();

_header.DisplayHeader('=', "Built In Types Demo");

ForegroundColor = ConsoleColor.DarkCyan;

WriteLine($"Byte: {sizeof(byte)} byte(s) of memory. Its Min and Max Values are {byte.MinValue} and {byte.MaxValue}");
WriteLine($"SByte: {sizeof(sbyte)} byte(s) of memory. Its Min and Max Values are {sbyte.MinValue} and {sbyte.MaxValue}");
WriteLine($"Short: {sizeof(short)} byte(s) of memory. Its Min and Max Values are {short.MinValue} and {short.MaxValue}");
WriteLine($"UShort: {sizeof(ushort)} byte(s) of memory. Its Min and Max Values are {ushort.MinValue} and {ushort.MaxValue}");
WriteLine($"Int: {sizeof(int)} byte(s) of memory. Its Min and Max Values are {int.MinValue} and {int.MaxValue}");
WriteLine($"UInt: {sizeof(uint)} byte(s) of memory. Its Min and Max Values are {uint.MinValue} and {uint.MaxValue}");
WriteLine($"Long: {sizeof(long)} byte(s) of memory. Its Min and Max Values are {long.MinValue} and {long.MaxValue}");
WriteLine($"ULong: {sizeof(ulong)} byte(s) of memory. Its Min and Max Values are {ulong.MinValue} and {ulong.MaxValue}");

ForegroundColor = ConsoleColor.DarkYellow;
WriteLine($"\nFloat: {sizeof(float)} byte(s) of memory. Its Min and Max Values are {float.MinValue} and {float.MaxValue}");
WriteLine($"Double: {sizeof(double)} byte(s) of memory. Its Min and Max Values are {double.MinValue} and {double.MaxValue}");
WriteLine($"Decimal: {sizeof(decimal)} byte(s) of memory. Its Min and Max Values are {decimal.MinValue} and {decimal.MaxValue}");

ForegroundColor = ConsoleColor.DarkGreen;
WriteLine($"\nChar: {sizeof(char)} byte(s) of memory. Its Min and Max Values are {(int)char.MinValue} and {(int)char.MaxValue}");

ForegroundColor = ConsoleColor.Cyan;
WriteLine($"\nBool: {sizeof(bool)} byte(s) of memory. Its Min and Max Values are {bool.FalseString} and {bool.TrueString}");



// Assigning Values
int age = 18;
char gender = 'M';
string userName = "Sri Varu";
bool isManager = true;
decimal salary = 100000.00M;
double bonus = 10000.00;
float tax = 0.10F;
const double interestRate = 0.07;

ForegroundColor = ConsoleColor.Blue;
// Displaying Values
WriteLine($"\nAge: {age}");
WriteLine($"Gender: {gender}");
WriteLine($"User Name: {userName}");
WriteLine($"Is Manager: {isManager}");
WriteLine($"Salary: {salary}");
WriteLine($"Bonus: {bonus}");
WriteLine($"Tax: {tax}");
WriteLine($"Interest Rate: {interestRate}");

_footer.DisplayFooter('-');