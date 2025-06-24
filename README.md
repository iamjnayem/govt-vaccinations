# Name : Govt Vaccination
# Description: Vaccine Registration API


# Project Creation Commands

- `mkdir GovtVaccination`
- `cd GovtVaccination`
- `dotnet new sln -n GovtVaccination`
- `dotnet new webapi -n GovtVaccination -o GovtVaccination`
- `dotnet sln add GovtVaccination/GovtVaccination.csproj`

# Database Related Package Installation

 - `dotnet add package Pomelo.EntityFrameworkCore.MySql`
 - `dotnet add package Microsoft.EntityFrameworkCore.Design`

# Database Scaffolding Commands
- `dotnet ef dbcontext scaffold "server=localhost;database=vaccinations;user=root;password=lolipop1" Pomelo.EntityFrameworkCore.MySql --context-dir Data --output-dir Models --context AppDbContext --no-pluralize --force --no-onconfiguring`
