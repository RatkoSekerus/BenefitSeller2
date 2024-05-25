# BenefitSeller

## BenefitSeller Web API

### Overview

BenefitSeller is a web API designed to process transactions made by BenefitSeller cardholders. The API tracks transaction information, validates transactions, and verifies card funds.

### Getting Started

#### Prerequisites

- Visual Studio 2022
- .NET SDK and .NET Runtime
- SQL Server 2022 Developer Edition
- SQL Server Management Studio (Opional - if you want to check state in the database)

#### Installation

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio 2022.
3. Ensure SQL Server is installed and running on your machine. (When installed - copy connection string, it contains needed server name)
4. Connect SQL Server Management Studio to your SQL Server instance (Optional) using the following steps:
   - Launch SQL Server Management Studio.
   - In the "Connect to Server" dialog, enter the server name provided when starting SQL Server (usually `localhost` for a local instance).
   - Click "Connect" to establish the connection.
5. Update the connection string (if server name in code is different that yours) in `appsettings.json` under `ConnectionStrings` to match your SQL Server instance:
   "BenefitSellerConnectionString": "Server=*yourServerName*;Database=BenefitSellerDb;Trusted_Connection=True;TrustServerCertificate=True"

### Build a Solution
1. Open Visual Studio: Launch Visual Studio 2022 on your computer.
2. Navigate to Build Menu: In the top menu bar of Visual Studio, click on "Build" to access the Build menu.
3. Select "Build Solution": From the Build menu, choose "Build Solution" to compile all projects within the solution.
4. Shortcut: Alternatively, you can use the keyboard shortcut `Ctrl + Shift + B` to build the solution.

### Database Migration and Seeding
1. Open Visual Studio: Launch Visual Studio 2022 on your computer.
2. Navigate to the Tools Menu: Look for the top menu bar at the top of the Visual Studio window. It typically contains menu items like File, Edit, View, Project, etc. Click on the "Tools" menu item.
3. Access NuGet Package Manager: After clicking on the "Tools" menu, a dropdown menu will appear. Scroll down in this menu to find the "NuGet Package Manager" option. Hover over it, and another dropdown menu will appear.
4. Open Package Manager Console: In the dropdown menu that appears when hovering over "NuGet Package Manager," click on "Package Manager Console" to open it. This action will open the Package Manager Console window within Visual Studio.
5. Run command: Add-Migration "Name of migration"
6. Run command: Update-Database

### Running Application
1. Launch Visual Studio 2022.
2. Open the BenefitSeller solution.
4. Click the green "Start" button located in the middle of the top toolbar. This will build the solution and start the application.
5. Once the application has started, you can interact with it by sending HTTP requests to the API endpoints using a tool like Postman or Swagger.

### Running Tests
1. Open Visual Studio: Launch Visual Studio 2022 on your computer.
2. Navigate to Tests Menu: In the top menu bar of Visual Studio, click on "Test" to access the Tests menu.
3. Select "Run all tests": From the Tests menu, choose "Run all tests" to execute all tests in the solution.

### About Implementation

#### Structure
Controller - Manager - Repository

1. **TransactionsController**: This controller is responsible for handling client requests related to transactions. It contains action methods that receive data from clients and pass it to the TransactionsManager for processing.

2. **TransactionsManager**: The TransactionsManager is the core component responsible for managing transactions within the system. It encapsulates all the business logic related to transaction processing. Here's an overview of its functionality:
    - **Transaction Creation**: The `CreateAsync` method is responsible for creating new transactions based on the data received from clients. It validates the transaction, checks user and merchant information, and ensures that the transaction amount is within the user's balance and subscription plan limits.
    - **Transaction Retrieval**: The `GetAllByUserId` method retrieves transactions associated with a specific user. It allows filtering transactions based on whether they were successful or failed, and supports pagination for large result sets.
    - **Private Methods**: The TransactionsManager also contains several private helper methods that handle specific tasks, such as checking transaction validity, applying discounts, charging users, and retrieving user and merchant information from repositories.

3. **Repositories**: TransactionsManager interacts with various repository interfaces (`ITransactionsRepository`, `IUserRepository`, `IMerchantRepository`, `ICompanyRepository`, `IMerchantCategoryGroupRepository`) to retrieve and persist data in the database.

This structure follows the Manager-Repository pattern, where the manager layer contains the business logic, and the repository layer handles data access and persistence.
