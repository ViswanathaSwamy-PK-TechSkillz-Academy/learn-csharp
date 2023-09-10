using HeaderFooter;

Header _header = new();
Footer _footer = new();

_header.DisplayHeader('=', "Default Values Demo");

int age;
char gender;
string userName;
bool isManager;
decimal salary;
double bonus;
float tax;

age = 18;
gender = 'M';
userName = "John Doe";
isManager = true;
salary = 100000.00M;
bonus = 10000.00;
tax = 0.10F;

Console.WriteLine($"Age: {age}");
Console.WriteLine($"Gender: {gender}");
Console.WriteLine($"User Name: {userName}");
Console.WriteLine($"Is Manager: {isManager}");
Console.WriteLine($"Salary: {salary}");
Console.WriteLine($"Bonus: {bonus}");
Console.WriteLine($"Tax: {tax}");

_footer.DisplayFooter('-');