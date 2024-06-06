# ASP.NET Core MVC Movie Application

This is an ASP.NET Core MVC application for managing a movie database. The application allows users to view, create, edit, and delete movie entries.

## Features

- List all movies
- View details of a specific movie
- Add a new movie
- Edit an existing movie
- Delete a movie

## Prerequisites

- .NET Core SDK
- Visual Studio 2019 or later / Visual Studio Code
- SQL Server or LocalDB (for database)

## Getting Started

### Clone the Repository

```sh
git clone https://github.com/nischalbaskota9818/ASP.net-core-MVC-for-movie.git
cd ASP.net-core-MVC-for-movie

#Update the connection string in appsettings.json to match your database configuration
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=MvcMovie;Trusted_Connection=True;MultipleActiveResultSets=true"
}
#Run the following commands to update the database:

dotnet ef database update

#Run the application using Visual Studio or using the .NET CLI:
dotnet run

#Seeding the Database
To seed the database with initial data, ensure the SeedData class is set up to seed data on application startup. You can manually run the seed method if needed.

#License
This project is licensed under the MIT License - see the LICENSE file for details.

