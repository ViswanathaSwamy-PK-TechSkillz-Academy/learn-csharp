using HeaderFooter;

Header _header = new();
Footer _footer = new();

_header.DisplayHeader('=', "A1 Stirngs Demo");

string userName = "John";

string userAddress = @"
Flat No: 102, 1st Floor
Sai Residency
Kondapur
Hyderabad - 500084
";

string officeAddress = """
        Flat No: 102, 1st Floor
        Sai Residency
        Kondapur
        Hyderabad - 500084
""";

string emptyString = string.Empty;

string emptyString2 = "";

string whiteSpaceString = " ";

string nullString = null;

string defaultString = default;

string uninitializedString;

WriteLine($"Welcome {userName} !");
WriteLine($"Your address is: {userAddress}");
WriteLine($"Your office address is: {officeAddress}");
WriteLine($"Empty String: {emptyString}");
WriteLine($"Empty String 2: {emptyString2}");
WriteLine($"White Space String: {whiteSpaceString}");
WriteLine($"Null String: {nullString}");
WriteLine($"Default String: {defaultString}");

_footer.DisplayFooter('-');