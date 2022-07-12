# sale-spy

## Setup

1. Create a local MSSQL database
2. Adjust the connection string in appsettings.json
3. Execute the database update script inside SaleSpy.Data project
 `dotnet ef database update --startup-project ../SaleSpy.Api`
4. Run
