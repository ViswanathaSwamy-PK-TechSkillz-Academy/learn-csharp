# Dive into JIT Compilation, Console Apps in .NET 6/7/8, Primitive Types, and Type Conversions - Part of Microservices Series 4/120

## Commands

```powershell
dotnet new sln -n S4

dotnet new console -o A1CompilerVersionDemo
dotnet sln add .\A1CompilerVersionDemo\A1CompilerVersionDemo.csproj
dotnet restore
dotnet build
dotnet run --project .\A1CompilerVersionDemo\A1CompilerVersionDemo.csproj

dotnet new console -o A2VariablesDemo
dotnet sln add .\A2VariablesDemo\A2VariablesDemo.csproj
dotnet add reference ../../Common/HeaderFooter/HeaderFooter.csproj
dotnet restore
dotnet build
dotnet run --project .\A2VariablesDemo\A2VariablesDemo.csproj

dotnet new console -o A3InputOutputDemo
dotnet sln add .\A3InputOutputDemo\A3InputOutputDemo.csproj
dotnet add reference ../../Common/HeaderFooter/HeaderFooter.csproj
dotnet restore
dotnet build
dotnet run --project .\A3InputOutputDemo\A3InputOutputDemo.csproj
```
