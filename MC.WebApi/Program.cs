using MC.Data.Context;
using MC.Data.Interfaces;
using MC.Data.Repository;
using MC.Manager.Interfaces;
using MC.Manager.Mappings;
using MC.Manager.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MCContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase")));

builder.Services.AddAutoMapper(typeof(InputMotorcycleMappingProfile), typeof(InputDeliveryManMappingProfile));

builder.Services.AddScoped<IMotorcycleRepository, MotorcycleRepository>();
builder.Services.AddScoped<IMotorcycleService, MotorcycleService>();

builder.Services.AddScoped<IDeliveryManRepository, DeliveryManRepository>();
builder.Services.AddScoped<IDeliveryManService, DeliveryManService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
