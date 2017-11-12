# Simple .NET MVC5 Shopping Cart
An experimental online shopping cart project using C# .NET MVC5, MSSQL, HTML5, CSS3 and JavaScript

![alt tag](https://raw.githubusercontent.com/mrjcka/Simple-.NET-MVC-5-Shopping-Cart/master/demo.PNG)

## Installation

As mentioned, this is a experimental project and is not ready for production. Please use on your own risk.

**Required libraries**:

- .NET Identity

**Steps of installation**

- Import project into Visual Studio (or alternative IDE)
- Import and run SQL script attached name `Scripts.sql`. This will automatically generate database for the project.

## Features

- Frontend pages - display Products, Orders, Suppliers for Customers and Visitor.
- Authentication - a `Visitor` can become a `Customer`
- Admin Page
    - CRUD functions for Products and Suppliers, view Orders, view and delete Customer
    - Displaying Stock level using chartjs
