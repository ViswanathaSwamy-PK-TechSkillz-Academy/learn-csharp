using HeaderFooter;

Header _header = new();
Footer _footer = new();

_header.DisplayHeader('=', "Default Values Demo");

Console.Write("Enter your age: ");
string? age = Console.ReadLine();

Console.Write("Enter Gender: ");
string? gender = Console.ReadLine();

Console.Write("Enter User Name: ");
string? userName = Console.ReadLine();

Console.Write("Enter Is Manager: ");
string? isManager = Console.ReadLine();

Console.Write("Enter Salary: ");
string? salary = Console.ReadLine();

Console.Write("Enter Bonus: ");
string? bonus = Console.ReadLine();

Console.Write("Enter Tax: ");
string? tax = Console.ReadLine();

Console.WriteLine("\n\n***** Displaying Values *****");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Gender: {gender}");
Console.WriteLine($"User Name: {userName}");
Console.WriteLine($"Is Manager: {isManager}");
Console.WriteLine($"Salary: {salary}");
Console.WriteLine($"Bonus: {bonus}");
Console.WriteLine($"Tax: {tax}");

_footer.DisplayFooter('-');