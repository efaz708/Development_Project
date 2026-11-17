
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

The following screenshots demonstrate the main features and user interfaces of the BARAFood Restaurant Management System.

### Application Interface

## Application Interface

The following screenshots demonstrate the user interface and key features of BARAFood, an ASP.NET Core MVC restaurant management system with customer-facing functionality and administrator management features.

### 1. Welcome and Authentication

The application provides a landing page and user authentication interfaces for accessing the restaurant management system.

**Welcome Page**

![BARAFood Welcome Page](screenshots/Screenshot%20%281757%29.png)

**User Login**

![BARAFood Login Page](screenshots/Screenshot%20%281758%29.png)

**User Registration**

![BARAFood Registration Page](screenshots/Screenshot%20%281759%29.png)

### 2. Home Page and Restaurant Menu

After logging in, users can navigate the restaurant website, browse menu items and select food and drinks.

**Home Page**

![BARAFood Home Page](screenshots/Screenshot%20%281760%29.png)

**Food Menu**

![BARAFood Food Menu](screenshots/Screenshot%20%281761%29.png)

**Drinks Menu**

![BARAFood Drinks Menu](screenshots/Screenshot%20%281762%29.png)

**Desserts Menu**

![BARAFood Desserts Menu](screenshots/Screenshot%20%281763%29.png)

### 3. Table Reservation System

The reservation interface allows users to enter their contact details, specify the number of guests, choose a date and time, and select a table from the available interface options.

![BARAFood Table Reservation Form](screenshots/Screenshot%20%281764%29.png)

### 4. Customer Shopping Cart

The cart interface provides sections for selected menu items and table reservations.

![BARAFood Customer Cart](screenshots/Screenshot%20%281765%29.png)

### 5. Contact and Restaurant Information

The contact page presents restaurant information, opening hours, management details and a privacy policy section.

![BARAFood Contact Page](screenshots/Screenshot%20%281766%29.png)

### 6. Administrator Interface

The application includes administrator-facing functionality for managing restaurant menu items, viewing customer cart records and managing table reservations.

**Administrator Login**

![BARAFood Administrator Login](screenshots/Screenshot%20%281767%29.png)

**Administrator Menu View**

![BARAFood Administrator Menu Management](screenshots/Screenshot%20%281768%29.png)

### 7. Menu Item Management (CRUD)

The administrator interface includes menu item management pages for viewing, creating, editing and deleting menu records.

**Edit Menu Item**

![BARAFood Edit Menu Item](screenshots/Screenshot%20%281769%29.png)

**Menu Management List**

![BARAFood Menu Management List](screenshots/Screenshot%20%281770%29.png)

**Menu Item Details**

![BARAFood Menu Item Details](screenshots/Screenshot%20%281771%29.png)

### 8. Administrator Cart and Reservation Management

The administrator interface displays cart items associated with different users, including quantities, prices and actions. It also displays table reservations with customer details and edit/delete controls.

**Administrator Cart Overview**

![BARAFood Administrator Cart Overview](screenshots/Screenshot%20%281772%29.png)

**Administrator Reservation Management**

![BARAFood Administrator Reservation Management](screenshots/Screenshot%20%281773%29.png)

---

*Screenshots captured from the application running locally during development.*
## Author

Md Jobaer Hasan Efaz

BSc (Hons) Computer Science – First Class Honours

De Montfort University, UK

## Project Purpose

Final Year Development Project – BSc (Hons) Computer Science.
