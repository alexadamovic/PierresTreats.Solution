# Pierre's Treats: Many-To-Many Database Relationships with Authentication / Authorization

![image](/PierresTreats/wwwroot/img/logo.png)

#### A C# application built with ASP.NET Core, Entity to integrate MySQL databases, and Identity for authentication / authorization

#### By Alex Adamovic

## Technologies Used

* _C#_
* _HTML_
* _CSS_
* _MySQL_

### Dependencies

* _Entity_
* _Identity_
* _Bootstrap_
* _ASP.NET Core_

## Description

_This C# web application, made to be used as a product management tool for Pierre's Treats, lets many users create a list of treats and a list of flavors, utilizing a MySQL database and connecting the treat and flavor tables in Many-To-Many relationships through the use of a join table (see infographic below). From the splash page, the user is able to view all treat and flavor objects in the database from all users. The user is also able to view index pages for their own treats and flavors once logged in, and they can navigate between views to ***add, delete, view details***, and ***edit*** treats and flavors for full CRUD functionality. If the user is not logged in, they are only able to ***view*** treats and flavors on the splash page and their accompanying details views. By employing Entity and LINQ syntax, user form inputs are passed to the respective mySQL database tables through Post requests, and RESTful routes are employed to ensure development standardization. This application is meant to showcase proper use of Many-To-Many database relationships in connecting an ASP.NET core web framework with mySQL databases using Entity, as well as handle authorization/authentication with Identity._

### Database Table Structure

![image](/PierresTreats/wwwroot/img/pierres_treats_tables.png)

## Setup/Installation Requirements

#### To Install MySQL & MySQL Workbench

* _go to https://dev.mysql.com/downloads/ and install **MySQL Community Server** and **MySQL Workbench** for your operating system_
* _follow the instructions at [learnhowtoprogram](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) for proper installation_

#### To Set Up Project With Dependencies

* _clone repository from https://github.com/alexadamovic/PierresTreats.Solution_
* _navigate to the project directory in your terminal/command line_
* _navigate to the subdirectory PierresTreats and enter ```dotnet restore``` to install project dependencies_

#### To Create appsettings.json

* _navigate to the subdirectory PierresTreats and create the file ```appsettings.json```_
* _add the following code:_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR_DATABASE];uid=[YOUR_USER_ID];pwd=[YOUR_PASSWORD];"
  }
}
```
* _replace the applicable sections with your database name, your user ID, and your password_

#### To Create Database using Migrations

* _navigate to the project directory in your terminal/command line_
* _navigate to the subdirectory PierresTreats and enter ```dotnet ef database update``` to create a new local database for the project_
* _the database will take the name specified in your ```appsettings.json``` file and can be viewed using MySQL_

#### To Run the Web Application

* _navigate to the subdirectory PierresTreats and enter ```dotnet run``` for a snapshot server or ```dotnet watch run``` for a live updating server for the application_
* _access the server in your browser by entering ```localhost:5000``` into your navigation bar_
* _click the hyperlinks and submit forms to navigate between the views_
* _enter ```ctrl``` + ```c``` for Windows or ```command``` + ```.``` for Mac in your terminal/command line to stop the server_

## Known Bugs

* _sidebar is currently not design responsive (need to update CSS) (3/25/2022)_

## License

_MIT License_

Copyright (c) _2022_ _Alex Adamovic_

## Contact Information

alexanderadamovic@gmail.com
