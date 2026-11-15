
# BARAFood – Restaurant Management System

## Overview

BARAFood is a web-based Restaurant Management System developed as my Final Year Development Project for the BSc (Hons) Computer Science degree at De Montfort University, UK.

The application was developed using ASP.NET Core MVC, C#, Entity Framework Core and Microsoft SQL Server.

The project focuses on providing a web-based platform where customers can browse restaurant menus, manage their food selections and make table reservations. It also includes administrative functionality for managing restaurant information and customer records.

## Technologies Used

- C#
- ASP.NET Core MVC (.NET 6)
- Entity Framework Core
- Microsoft SQL Server / LocalDB
- ASP.NET Core Identity
- HTML, CSS and Bootstrap
- Visual Studio 2022

## Main Features

### User Authentication
- User registration and login
- Authentication using ASP.NET Core Identity
- Role-based access for customers and administrators

### Restaurant Menu
- Browse food, drinks and desserts
- View menu item descriptions and prices
- Select items to add to the shopping cart
- Administrative functionality for managing menu items

### Shopping Cart
- Add selected menu items
- Update item quantities
- Remove items from the cart
- Calculate the total price
- Associate cart items with individual user accounts

### Table Reservations
- Enter reservation details
- Select a reservation date and time
- Choose from 12 restaurant tables
- View and delete personal reservations
- Associate reservations with authenticated users

### Administration
- Create, edit and delete menu items
- View customer cart information
- View and manage customer reservations
- Restrict administrative functionality using role-based authorisation

## System Architecture

The application follows the Model-View-Controller (MVC) architectural pattern.

- Models represent application data and business entities.
- Views provide the user interface using Razor, HTML and CSS.
- Controllers handle requests and coordinate application operations.
- Entity Framework Core supports database access and data persistence.
- ASP.NET Core Identity manages authentication and user roles.

## Development Experience

This project provided practical experience in full-stack web application development, relational databases, authentication, authorisation and integrating multiple application components.

The development process involved implementing customer-facing features, connecting the application to a database and building administrative functionality.

## Known Limitations

The project is an academic prototype. Some functionality requires further testing and refinement, including an item-removal issue observed during cart testing.

## Project Screenshots

Screenshots of the application interface will be added to this repository.

## Author

Md Jobaer Hasan Efaz

BSc (Hons) Computer Science – First Class Honours

De Montfort University, UK

## Project Purpose

Final Year Development Project – BSc (Hons) Computer Science.
