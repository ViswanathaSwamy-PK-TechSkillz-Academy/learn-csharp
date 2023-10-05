string name = typeof(Program).Namespace ?? "None!";

ForegroundColor = ConsoleColor.DarkCyan;

WriteLine($"Namespace: {name}");

WriteLine(Environment.CurrentDirectory);
WriteLine(Environment.OSVersion.VersionString);
WriteLine("Namespace: {0}", typeof(Program).Namespace);

ResetColor();

// Uncomment the below line to see the Compiler Version and Language Version
// #error version

/*
 * Uncomment the below line to see the error message
 * Unhandled exception. System.Exception: Exception of type 'System.Exception' was thrown.
   at Program.<Main>$(String[] args) in C:\GitHub\TSA\learn-csharp\work\20231005cs12dn8\chapter1\Program.cs:line 7
 */
// throw new Exception();

WriteLine("\n\nPress any key ...");