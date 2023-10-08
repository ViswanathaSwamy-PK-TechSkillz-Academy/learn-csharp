using HeaderFooter;

Header _header = new();
Footer _footer = new();

_header.DisplayHeader('=', "Implicit Types Demo");



// Assigning Values
int age = 18;
char gender = 'M';
string userName = "Sri Varu";
bool isManager = true;
decimal salary = 100000.00M;
double bonus = 10000.00;
float tax = 0.10F;
const double interestRate = 0.07;

ForegroundColor = ConsoleColor.DarkCyan;
// Displaying Values
WriteLine($"\nAge: {age}");
WriteLine($"Gender: {gender}");
WriteLine($"User Name: {userName}");
WriteLine($"Is Manager: {isManager}");
WriteLine($"Salary: {salary}");
WriteLine($"Bonus: {bonus}");
WriteLine($"Tax: {tax}");
WriteLine($"Interest Rate: {interestRate}");

var age1 = 18;
var gender1 = 'M';
var userName1 = "Sri Varu";
var isManager1 = true;
var salary1 = 100000.00M;
var bonus1 = 10000.00;
var tax1 = 0.10F;

ForegroundColor = ConsoleColor.DarkGreen;
// Displaying Values
WriteLine($"\nAge: {age1}");
WriteLine($"Gender: {gender1}");
WriteLine($"User Name: {userName1}");
WriteLine($"Is Manager: {isManager1}");
WriteLine($"Salary: {salary1}");
WriteLine($"Bonus: {bonus1}");
WriteLine($"Tax: {tax1}");

_footer.DisplayFooter('-');