# EduRelief – Student Emergency Aid System

EduRelief is a full-stack Windows Forms application designed to manage emergency financial aid requests for students. The system connects Students, Sponsors, and Administrators through a centralized, secure platform.

## Features
- **Student Portal:** Register, login securely, submit funding requests, upload documents, and track status.
- **Admin Dashboard:** View live analytics, review student requests, approve/reject applications, and manage users.
- **Sponsor Portal:** Register, make donations via a simulated payment gateway, and view donation history.

## Technology Stack
- **Language:** C# (.NET 8.0 Windows Forms)
- **Database:** Microsoft SQL Server
- **Data Access:** ADO.NET
- **Security:** SHA-256 Password Hashing, Parameterized SQL Queries

## How to Run This Project
1. Clone this repository to your local machine.
2. Open the `database.sql` file in SQL Server Management Studio (SSMS) and execute it to create the database.
3. Open the solution in Visual Studio.
4. Update the `ConnectionString` in `DbHelper.cs` to point to your local SQL Server instance.
5. Build and Run the application.