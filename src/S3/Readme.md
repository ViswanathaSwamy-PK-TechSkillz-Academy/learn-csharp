# Session 3: Dive into Interoperability, and JIT Compilation, Debugging using VS Code - Part of Microservices Series 3/120

## Commands

```powershell
dotnet new sln -n S3

dotnet new console -o A1VariablesDemo
dotnet sln add .\A1VariablesDemo\A1VariablesDemo.csproj
dotnet add reference ../../Common/HeaderFooter/HeaderFooter.csproj
dotnet restore
dotnet build
dotnet run --project .\A1VariablesDemo\A1VariablesDemo.csproj

dotnet new console -o A2InputOutputDemo
dotnet sln add .\A2InputOutputDemo\A2InputOutputDemo.csproj
dotnet add reference ../../Common/HeaderFooter/HeaderFooter.csproj
dotnet restore
dotnet build
dotnet run --project .\A2InputOutputDemo\A2InputOutputDemo.csproj
```
