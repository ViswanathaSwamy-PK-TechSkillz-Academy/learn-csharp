# 20 Jul 2023 Session

## Commands

```powershell
dotnet new sln -n 20230720

dotnet new console -o A1DefaultValuesDemo
dotnet add reference ..\..\Common\HeaderFooter\HeaderFooter.csproj
dotnet sln add .\A2DefaultValuesDemo\A2DefaultValuesDemo.csproj

dotnet new console -o A2StringsDemo
dotnet add reference ..\..\Common\HeaderFooter\HeaderFooter.csproj
dotnet sln add .\A1StringsDemo\A1StringsDemo.csproj
```

---------------------------------------------------

dotnet new console -o A2CharsDemo

dotnet new console -o A3IntegersDemo

dotnet new console -o A4DecimalsDemo

dotnet new console -o A4BoolDemo

dotnet new console -o A5DateTimeDemo

dotnet sln add .\A1StringsDemo\A1StringsDemo.csproj

dotnet add reference ..\..\Common\HeaderFooter\HeaderFooter.csproj

dotnet add:
  package <PACKAGE_NAME>    Add a NuGet package reference to the project.
  reference <PROJECT_PATH>  Add a project-to-project reference to the project.
