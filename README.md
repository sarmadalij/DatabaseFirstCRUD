# Steps To Recreate this CRUD Application using Database First Approach

#### First Create a ASP Core MVC based Project.
#### Then add these dependencies
###### Microsoft.EntityFrameworkCore.Design
###### Microsoft.EntityFrameworkCore.SqlServer
###### Microsoft.EntityFrameworkCore.Tools
#### After this make sure we have Database created in our Microsoft SQL Server with some Tables and fields.
#### Then Run this command in the project terminal
###### Scaffold-DbContext "server=DESKTOP-F83RJ08\SQLEXPRESS; database=CodeFirstDB; Trusted_Connection=True; TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
#### If you have made some modification in Database tables and fields then Run This command
###### Scaffold-DbContext "server=DESKTOP-F83RJ08\SQLEXPRESS; database=CodeFirstDB; Trusted_Connection=True; TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force
#### After we are done with this, then Add your connection string in the "appettings.json" file
#### Also make sure to configure the program.cs file for database connectivity and connection string registration
#### Then Delete your Existing Controller and Also You can delete Home View As well, then create the Controller with EntityFramework Template it will create controller and configure all the function like create, delete, details, edit in it and also it will create the necessary views for it.
### WE can add some custom Bootstrap for alert messages in our Index View and Some modification in Controller class.

## That's It, Now we have our CRUD Web App READY!
