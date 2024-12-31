
# Unique Employee Management System by prathamesh more

## Overview
A robust and user-friendly Employee Management System built using ASP.NET Core Web API with secure token-based authentication.

## Features
- Token-based Authentication (JWT)
- CRUD operations for Employee Management
- SQL Server integration

## Prerequisites
- Visual Studio 2022 or later
- .NET 6 SDK
- SQL Server

## Setup
1. Clone the repository.
2. Update `appsettings.json` with your database connection string.
3. Run migrations:
   ```bash
   Add-Migration InitialCreate
   Update-Database
   ```
4. Run the project:
   ```bash
   dotnet run
   ```

## API Endpoints
- **Authentication**:
  - POST `/api/auth/login` - Login with a username and password.
- **Employee Management**:
  - GET `/api/employees` - Get all employees.
  - GET `/api/employees/{id}` - Get an employee by ID.
  - POST `/api/employees` - Add a new employee.
  - PUT `/api/employees/{id}` - Update an employee.
  - DELETE `/api/employees/{id}` - Delete an employee.

## Contact
For queries, reach out to the developer.( Prathamesh More)
