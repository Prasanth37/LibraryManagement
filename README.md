# DotNetStarterKit

**Note**: 
* This is a sample starter kit.
* Feel free to use your own Tools, IDE, Database etc. as mentioned below in [Project Featuers & Tools](#ProjectFeaturesAndTools) section.
* This starter kit has a sample Home page made in MVC, Razor UI. You are **NOT** **required** to create any kind of UI. 
* Expectation is to create Web Apis, which can be tested.
* Either this starter kit, or your own(which contains the same intent as this starter kit), should be tried and tested in your development environment.
* PLEASE DO NOT CLONE AND SEND PRs. Instead Fork it and keep commiting to your own git repository. [Learn Git](https://try.github.io/levels/1/challenges/1)

## Pre-requisites
* .NET 4.5
* Nuget Extension for your Visual Studio
* This project was built on Visual Studio 2012. It is expected to work in Visual Studio 2012 or above. [Report at singsuyash@gmail.com](mailto:singsuyash@gmail.com) in case of problems.
* Postman or equivalent to test apis
    * Or Swagger (included in project)
* [Sql Server Local DB](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-2016-express-localdb), This comes pre-installed with installation of Visual Studio 2012 and above. Feel free to use your own database, change the connection string in `web.config`

## Project Template
* ASP.NET MVC 4 WebApi

## <a name="ProjectFeaturesAndTools">Project Features & Tools</a>
| Feature | Tool | Url | App Url |
|---------|------|-----|---------|
|Authentication | Anonymous | | |
|Dependency Injection | Autofac | [Autofac](http://autofac.readthedocs.io/en/latest/getting-started/index.html)
|API description format | Swagger | [Swagger](https://swagger.io/docs/specification/about/) | [AppUrl](http://localhost:35429/swagger)
|Unit Tests| MS Test | | |
|App Hosting| IIS Express | | |
|Database|Sql Server Local DB| | |
|Database Driver|ADO.NET | | |
|UI Rendering Engine | Razor | | |

## Project Structure
### DotNetStarterKit
| Folder | File | Comments |
|--------|----------|------|
|App_Data|`Employee.mdf`|Employee Database file|
|App_Data|`Employee.ldf`|Employee Database log file|
|App_Data|`dbo.Employee.sql`|Script file to create Employee table|
|App_Start|`AutofacConfig.cs`|Container for your DI|
|App_Start|`WebApiConfig.cs`|Register your apis here|
|Controllers|`EmployeeController.cs`|Employee ApiController|
|Domain|`Employee.cs`|Employee entity|
|Models|Interfaces\ `IEmployeeRepository.cs`|Repository Interface for Employee Repository|
|Models|`EmployeeRepository.cs`|Employee Repository Implementation|
|Services|Interfaces\ - |Service Interfaces go here|
|Services| - |Service Interface Implementations go here|
|/|Web.config|Database Connection String goes here| 

### DotNetStarterKit.Tests
| Folder | File | Comments |
|--------|----------|------|
|Controllers|`EmployeeControllerTest.cs`| Tests for Employee Controller|
|FakeRepositories|`FakeEmployeeRepository.cs`| Fake Implementation for Employee Repository Interface|
|FakeServices| - | Fake Implementation for services go here|

## Start up
* Set DotNetStarterKit Project as the startup project if not
* Press F5

### IIS, instead of IIS Express
* Go to DotNetStarterKit/Properties/Web
* Choose to use Local IIS, Uncheck/Remove IIS Express
* Create Virtual Directory
* Press F5


