# Kanban Board

```
dotnet new sln -o KanbanBoard

dotnet new webapi -o Web.Api
dotnet new classlib -o Web.Api.Core
dotnet new classlib -o Web.Api.Infrastructure
dotnet new xunit -o Web.Api.Tests

dotnet sln KanbanBoard.sln add ...
```

```
dotnet tool install --global dotnet-ef

dotnet add Web.Api.Core package MySQL.Data.EntityFrameworkCore
dotnet add Web.Api.Core package Microsoft.EntityFrameworkCore.Design
```