# dotnet-api-rest-boilerplate
Feel free to use this project as a boilerplate for your WebApi projects

## How to use
- Open the solution, launch it.
- Go to http://localhost:51881/swagger if Visual Studio has not already brought you there.
- The created user has id 1

## Technologies used

- [Unity](https://www.nuget.org/packages/Unity.AspNet.WebApi/) is an IoC container that helps you to make abstraction between your repository implementation and your controlers.
Using interfaces is also good because it helps you to test your controlers by faking the repo behaviour
- [Swagger](https://www.nuget.org/packages/Swashbuckle/) helps you to expose your API's routes. I use it for tests, feel free to remove it in production.

### Data Access Layer
- [Dapper](https://www.nuget.org/packages/Dapper/) is a micro ORM that helps you to access your database
- I chose [SQLite](https://www.nuget.org/packages/System.Data.SQLite/) to make the project actually work, but you probably want to change that

### Unit tests
- [Nunit](https://www.nuget.org/packages/NUnit/) is the unit test framework I used here
- [Moq](https://www.nuget.org/packages/Moq/) helps you to fake your interface implementations for your controler

### Logging
- I use [Nlog](https://www.nuget.org/packages/NLog/) as logging framework.
- As you will see, controlers also depends on a ILogging interface. As the repo, it is injected by Unity, but I used an [extension](https://www.nuget.org/packages/Unity.NLog/) that create the logger depending on the class name
- The nlog.config probably don't suits your needs
