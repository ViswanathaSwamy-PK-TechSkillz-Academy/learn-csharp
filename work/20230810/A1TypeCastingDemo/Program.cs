// See https://aka.ms/new-console-template for more information

int age = 181;
Console.WriteLine($"Type: {age.GetType()} :: Size: {sizeof(int)}  Value:: {age}");

// implicit type casting
decimal salary = age + 5;
Console.WriteLine($"Type: {salary.GetType()} :: Size: {sizeof(decimal)}  Value:: {salary}");

// implicit type casting. Undesired result
age = int.MaxValue;
Console.WriteLine($"Type: {age.GetType()} :: Size: {sizeof(int)}  Value:: {age}");
salary = age + 5;
Console.WriteLine($"Type: {salary.GetType()} :: Size: {sizeof(decimal)}  Value:: {salary}");

// explicit type casting
double newSalary = (double)salary;
Console.WriteLine($"Type: {newSalary.GetType()} :: Size: {sizeof(double)}  Value:: {newSalary}");