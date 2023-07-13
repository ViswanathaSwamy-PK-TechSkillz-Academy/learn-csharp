SayHelloWorld();

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
SayHello(name); // name is an argument

int age = GetAge();
Console.WriteLine($"Your age is {age}");

Console.WriteLine("Enter two numbers: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"Sum of {a} and {b} is {Add(a, b)}"); // a and b are arguments

// Which accepts no parameters and returns nothing
void SayHelloWorld()
{
    Console.WriteLine("Hello, World!");
}

// Which accepts a string parameter and returns nothing
void SayHello(string name)  // name is a parameter
{
    Console.WriteLine($"Hello, {name}!");
}

// Which accepts no parameters and returns an integer
int GetAge()
{
    Console.WriteLine("Enter your age: ");
    return int.Parse(Console.ReadLine());
}

// Which accepts two integer parameters and returns an integer
int Add(int a, int b)
{
    return a + b;
}
