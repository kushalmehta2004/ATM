# ATM Management System

Welcome to the ATM Management System project! This system is designed to handle common ATM operations such as deposit, withdraw, fast cash, mini statement, change PIN, balance inquiry, and account signup.

## Table of Contents

- [Getting Started](#getting-started)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Features](#features)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

These instructions will help you set up the project on your local machine for development and testing purposes.

## Prerequisites

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) (version 4.7.2 or later)
- A suitable IDE such as [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- SQL Server for the backend database

## Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/kushalmehta2004/ATM.git
   cd ATM
   ```

2. **Open the project:**
   Open the solution file (`ATM.sln`) in your IDE.

3. **Restore NuGet packages:**
   In Visual Studio, go to `Tools` > `NuGet Package Manager` > `Package Manager Console` and run:
   ```bash
   Update-Package -reinstall
   ```

4. **Set up the database:**
   - Create a new database in SQL Server.
   - Run the SQL scripts provided in the `Database` folder to set up the required tables and initial data.

5. **Update the connection string:**
   In the `appsettings.json` file, update the connection string to match your SQL Server configuration.

## Features

1. **Deposit:**
   - Allows users to deposit money into their accounts.

2. **Withdraw:**
   - Enables users to withdraw money from their accounts.

3. **Fast Cash:**
   - Provides predefined quick withdrawal options for users.

4. **Mini Statement:**
   - Displays a summary of the last few transactions.

5. **Change PIN:**
   - Allows users to change their account PIN.

6. **Balance Inquiry:**
   - Displays the current balance of the user's account.

7. **Account Signup:**
   - Facilitates the creation of a new account if one does not exist.

## Usage

1. **Launch the application:**
   Press `F5` in Visual Studio to build and run the application.

2. **Login:**
   Use your account credentials to log in. If you do not have an account, use the signup feature.

3. **Navigate the menu:**
   Use the menu options to perform various operations such as deposit, withdraw, fast cash, etc.

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -am 'Add some feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Open a pull request.


Thank you for using the ATM Management System! If you have any questions or feedback, please feel free to reach out.
