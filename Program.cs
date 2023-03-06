using LocationAPI.DbContexts;
using LocationAPI.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("Data/Logs/app.log", rollingInterval: RollingInterval.Day)
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

// Serilog Logging Service
builder.Host.UseSerilog();

builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddControllers().AddNewtonsoftJson();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// TODO Add DB Contexts
builder.Services.AddDbContext<LocationDbContext>(DbContextOptions => DbContextOptions.UseSqlite(builder.Configuration["ConnectionStrings:LocationDbConnectionString"]));

builder.Services.AddScoped<ILocationRepository, LocationRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
