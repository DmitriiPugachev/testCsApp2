using testCsApp2.Application.Services;
using testCsApp2.Application.Services.Interfaces;
using testCsApp2.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace testCsApp2
{
    public class Programm
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddScoped<IHealthService, HealthService>();
        builder.Services.AddScoped<IItemService, ItemService>();

        builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql("name=ConnectionStrings:DatabaseConnection"));

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            using (var scope = app.Services.CreateScope())
            {
                var initialiser = scope.ServiceProvider.GetRequiredService<DataContextInitialiser>();
                await initialiser.InitialiseAsync();
            }
        }

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
        }
    }
}