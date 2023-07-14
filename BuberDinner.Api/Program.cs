using BuberDinner.Application;
using BuberDinner.Infrastructure;

// Add services to the container.
var builder = WebApplication.CreateBuilder(args);
ConfigureServices(builder);

// Http Pipeline
var app = builder.Build();
Configure(app);

#region Private Methods
void ConfigureServices(WebApplicationBuilder builder)
{
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);

    builder.Services.AddControllers();
}

void Configure(WebApplication app)
{
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
#endregion