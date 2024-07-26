## Start a New Console Project

```
dotnet new console -o <app-name>
```

## Make sure to use old syntax

Configure app.name.csproj as follow:
```
# app-name.csproj

<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>disable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

## Check version

```
dotnet --version
```