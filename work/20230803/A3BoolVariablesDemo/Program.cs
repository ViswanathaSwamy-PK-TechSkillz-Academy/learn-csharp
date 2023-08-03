using HeaderFooter;

Header _header = new();
Footer _footer = new();

_header.DisplayHeader('=', "A2 Boolean Variables Demo");

ForegroundColor = ConsoleColor.Green;

WriteLine($"Char: {sizeof(bool)} byte(s) of memory.");

bool isManager = false;
WriteLine(isManager ? "Manager" : "Employee");

ResetColor();

_footer.DisplayFooter('-');

