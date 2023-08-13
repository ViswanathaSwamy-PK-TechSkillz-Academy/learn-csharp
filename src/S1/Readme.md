# Session

## Commands

```powershell
dotnet new sln -n S1

dotnet new console -o ProgramStructureDemoV1
dotnet sln add .\ProgramStructureDemoV1\ProgramStructureDemoV1.csproj
dotnet add reference ../../Common/HeaderFooter/HeaderFooter.csproj
dotnet restore
dotnet build
dotnet run --project .\ProgramStructureDemoV1\ProgramStructureDemoV1.csproj

dotnet new console -o ProgramStructureDemoV2
dotnet sln add .\ProgramStructureDemoV2\ProgramStructureDemoV2.csproj
dotnet add reference ../../Common/HeaderFooter/HeaderFooter.csproj
dotnet restore
dotnet build
dotnet run --project .\ProgramStructureDemoV2\ProgramStructureDemoV2.csproj
```
