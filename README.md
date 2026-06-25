# Blood Bank Management System

A modern desktop application built in **C# Windows Forms** with **.NET 8.0** and **SQL Server (MS-SQL)** to streamline and automate the operations of a Blood Bank. 

## Features

- 🔐 **Secure Authentication**: User SignUp and Login modules to safeguard patient and donor information.
- 🩸 **Donor Management**: Add, update, search, and view blood donors and track their donation history.
- 🧑‍🤝‍🧑 **Recipient Management**: Track blood receivers, hospital requests, referred doctors, and requested blood units.
- 📊 **Inventory Tracking**: Real-time status reporting of blood stock levels categorized by blood groups.
- 📆 **Daily Summary & Reports**: Search and review donor and recipient transactions within custom date ranges.

## Technology Stack

- **Frontend**: C# Windows Forms (.NET 8.0 MDI Architecture)
- **Database**: Microsoft SQL Server (MS-SQL)
- **Data Access**: ADO.NET (`Microsoft.Data.SqlClient`)

## Database Configuration

The application expects a local SQL Server instance with a database named `dbBloodBank`. Ensure your connection string in the codebase aligns with your configuration:
```csharp
"Data Source=YOUR_SERVER_NAME;Initial Catalog=dbBloodBank;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
```
