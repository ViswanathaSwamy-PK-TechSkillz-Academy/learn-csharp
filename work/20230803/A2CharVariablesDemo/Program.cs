using HeaderFooter;

Header _header = new();
Footer _footer = new();

_header.DisplayHeader('=', "A2 Char Variables Demo");

ShowCharDemo();

_footer.DisplayFooter('-');

static void ShowCharDemo()
{
    ForegroundColor = ConsoleColor.Magenta;

    WriteLine($"Char: {sizeof(char)} byte(s) of memory. Its Min and Max Values are {(int)char.MinValue} and {(int)char.MaxValue}");

    char choice = 'Y';
    WriteLine($"Char: {choice} {(int)choice}");

    choice = 'y';
    WriteLine($"Char: {choice} {(int)choice}");

    WriteLine($"Char: {(char)97} {(int)89}");

    for (int i = 97, j = 65; i < 123; i++)
    {
        Write($"{(char)i} == {i} :: {(char)j} == {j++} || ");
    }

    ResetColor();
}

// char chA = 'A';
// char ch1 = '1';
// string str = "test string";

// Console.WriteLine(chA.CompareTo('B'));          //-----------  Output: "-1" (meaning 'A' is 1 less than 'B')
// Console.WriteLine(chA.Equals('A'));             //-----------  Output: "True"
// Console.WriteLine(Char.GetNumericValue(ch1));   //-----------  Output: "1"
// Console.WriteLine(Char.IsControl('\t'));        //-----------  Output: "True"
// Console.WriteLine(Char.IsDigit(ch1));           //-----------  Output: "True"
// Console.WriteLine(Char.IsLetter(','));          //-----------  Output: "False"
// Console.WriteLine(Char.IsLower('u'));           //-----------  Output: "True"
// Console.WriteLine(Char.IsNumber(ch1));          //-----------  Output: "True"
// Console.WriteLine(Char.IsPunctuation('.'));     //-----------  Output: "True"
// Console.WriteLine(Char.IsSeparator(str, 4));    //-----------  Output: "True"
// Console.WriteLine(Char.IsSymbol('+'));          //-----------  Output: "True"
// Console.WriteLine(Char.IsWhiteSpace(str, 4));   //-----------  Output: "True"
// Console.WriteLine(Char.Parse("S"));             //-----------  Output: "S"
// Console.WriteLine(Char.ToLower('M'));           //-----------  Output: "m"
// Console.WriteLine('x'.ToString());              //-----------  Output: "x"

// for (int i = 0; i < 2000; i++)
// {
//     Write($"Char: {(char)i} {i} || ");
// }
