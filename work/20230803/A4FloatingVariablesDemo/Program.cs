using HeaderFooter;

Header _header = new();
Footer _footer = new();

_header.DisplayHeader('=', "A1 Floating Variables Demo");

ShowFloatingTypes();
ShowFloatingTypesDemo();

_footer.DisplayFooter('-');

static void ShowFloatingTypes()
{
    ForegroundColor = ConsoleColor.Blue;

    WriteLine($"Float: {sizeof(float)} byte(s) of memory. Its Min and Max Values are {float.MinValue} and {float.MaxValue}");
    WriteLine($"Double: {sizeof(double)} byte(s) of memory. Its Min and Max Values are {double.MinValue} and {double.MaxValue}");
    WriteLine($"Decimal: {sizeof(decimal)} byte(s) of memory. Its Min and Max Values are {decimal.MinValue} and {decimal.MaxValue}");

    ResetColor();
}

static void ShowFloatingTypesDemo()
{
    double d = 3D;
    WriteLine(d);

    d = 4d;
    WriteLine(d);

    d = 3.934_001;
    WriteLine(d);

    float f = 3_000.5F;
    WriteLine(f);
    f = 5.4f;
    WriteLine(f);

    decimal money = 3_000.5m;
    WriteLine(money);

    money = 400.75M;
    WriteLine(money);
}
