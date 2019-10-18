# Web API + EF Core + SQL Server on Docker - Starter Project

A starter ASP.NET Core Web API project with EF Core, and a development SQL Server database running on a Linux container.

## Quick Start

1. Download or clone the project.
2. Start Docker.
3. Open a terminal and run `docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong@Passw0rd" -p 1433:1433 --name sql-server -d mcr.microsoft.com/mssql/server:2019-CTP3.2-ubuntu`.
4. cd to project-folder/WebApiEfCoreSqlServerStarter.
5. Run `dotnet ef database update`.
6. Run `dotnet run`.
7. Open a browser to `http://localhost:5000/db`.
8. POST to `http://localhost:5000/db` to add entries to the database.
9. (optional) Login with SSMS: `Server: localhost`, `Login:sa`, `Password: YourStrong@Passw0rd` and explore your DevDB.
10. When done developing run in the terminal `Ctrl+C` to kill the proccess.
11. Run `docker ps` to list your containers.
12. Find the CONTAINER ID for image "mcr.microsoft.com/mssql/server:2019-CTP3.2-ubuntu" and NAME "sql-server".
13. Run `docker stop <container id>`.
14. Run `docker rm <container id>`.
