
using Data;
using Microsoft.EntityFrameworkCore;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<ApplicationDbContext>(option => {option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultSQLConnection"));});

        // Add services to the container.
        // Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("log/villaLogs.txt", rollingInterval: RollingInterval.Day).CreateLogger();
        // builder.Host.UseSerilog();
        // By installing the Serilog and Extension Nuget packages, we build you own custom instances of serilog.
        builder.Services.AddControllers(option =>
        {
            option.ReturnHttpNotAcceptable = true;
        }).AddNewtonsoftJson().AddXmlSerializerFormatters();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

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
    }
}