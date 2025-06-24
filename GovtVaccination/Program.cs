using Microsoft.AspNetCore.Mvc;
using GovtVaccination.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); 

// inject database configurations
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    ));

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapGet("/debug/routes", (IEnumerable<EndpointDataSource> endpointSources) =>
        string.Join("\n", endpointSources.SelectMany(source => source.Endpoints)
                .OfType<RouteEndpoint>() // Filter for endpoints with routing information
                .Select(e =>
                {
                    var routePattern = e.RoutePattern.RawText;
                    var httpMethods = e.Metadata.OfType<HttpMethodMetadata>().FirstOrDefault()?.HttpMethods;
                    var controllerAction = e.Metadata.OfType<Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor>().FirstOrDefault();

                    return $"Route: {routePattern ?? "(No Pattern)"} " +
                           $"Methods: {(httpMethods != null ? string.Join(", ", httpMethods) : "ANY")} " +
                           $"Action: {(controllerAction != null ? $"{controllerAction.ControllerName}.{controllerAction.ActionName}" : "(Non-MVC)")}";
                })
                .OrderBy(s => s) // Optional: sort for readability
        )
    );
}

app.UseHttpsRedirection();

app.MapControllers(); 
app.Run();
