# 20 Jul 2023 Session

## Instructions and Commands

### 1. Create a new empty solution

> 1. Create a new solution `20230720`

```powershell
dotnet new sln -n 20230720
```

### 1.1. Create a new Project `A1DefaultValuesDemo`

> 1. Create a new project `A1DefaultValuesDemo`
> 1. Add a `HeaderFooter` reference to `A1DefaultValuesDemo` project
> 1. Add `A1DefaultValuesDemo` project to `20230720` solution

```powershell
dotnet new console -o A1DefaultValuesDemo
dotnet add reference ..\..\Common\HeaderFooter\HeaderFooter.csproj
dotnet sln add .\A2DefaultValuesDemo\A2DefaultValuesDemo.csproj
```

### 1.2. Create a new Project `A2StringsDemo`

> 1. Create a new project `A2StringsDemo`
> 1. Add a `HeaderFooter` reference to `A2StringsDemo` project
> 1. Add `A2StringsDemo` project to `20230720` solution

```powershell
dotnet new console -o A2StringsDemo
dotnet add reference ..\..\Common\HeaderFooter\HeaderFooter.csproj
dotnet sln add .\A1StringsDemo\A1StringsDemo.csproj
```

## Tips

```text
dotnet add:
  package <PACKAGE_NAME>    Add a NuGet package reference to the project.
  reference <PROJECT_PATH>  Add a project-to-project reference to the project.
```

