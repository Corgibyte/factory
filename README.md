![Screenshot of Running Website](/screenshot.png)

## Dr. Sillystringz's Factory

By Hannah Young

A simple web application to allow a salon owner to manage their stylists and clients.

### Technologies Used

- C#
- .NET
- ASP.NET Core MVC
- MySQL
- Entity Framework

### Description

This is a web application that showcases my ability to develop a robust ASP.NET Core MVC backend attached to a MySQL database through Entity Framework.

### Setup

#### Requirements

* [git](https://git-scm.com)
* [.NET](https://dotnet.microsoft.com/en-us/)
* [MySQL](https://www.mysql.com/)
* [MySQL Workbench](https://www.mysql.com/products/workbench/)

#### To Run Web Application

1. Download and install the [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) as required for your system. Be sure to add the .NET sdk to your PATH
2. Use terminal to navigate to desired parent directory and use `git clone https://github.com/Corgibyte/factory.git Factory.Solution`
3. Navigate into the project directory nested inside the .Solution directory: `cd Factory.Solution/Factory`
4. Create an appsettings.json file: `touch appsettings.json`
5. Edit the new appsettings.json file and add the following, making sure to replace the indicated sections with your MySQL user ID and password:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=hannah_young;uid=[YOUR MYSQL USER ID];pwd=[YOUR PASSWORD];"
  }
}
```
6. Back in the terminal, in the HairSalon directory build the project: `dotnet restore`
7. Create database from migration data: `dotnet ef database update`
8. Run project: `dotnet run`
9. Use browser to navigate to `localhost:5000`

### Known bugs:

* None as of 01/07/2022 15:00

### Attributions

Background image generated with [SVG Backgrounds](https://www.svgbackgrounds.com)

### License

[Hippocratic License 2.1](https://github.com/Corgibyte/factory/blob/main/LICENSE.md), Copyright 2021 Hannah Young.