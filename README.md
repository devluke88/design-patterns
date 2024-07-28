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


## Depndency Management

TODO:

* https://learn.microsoft.com/en-us/nuget/concepts/dependency-resolution
* https://learn.microsoft.com/en-us/nuget/consume-packages/packages-and-source-control
* https://fossa.com/blog/dependency-management-visual-studio-nuget-beyond/
* https://www.youtube.com/watch?v=6qoW90eEBMQ
