using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using ShippingApi.Infrastructure;
using ShippingApi.Infrastructure.Extensions;
using ShippingApi.Services;
using ShippingApi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MapperConfig));
builder.Services.AddTransient<IShipmentService, ShipmentService>();
builder.Services.AddDbContext<ShippingDbContext>(options =>
    options
        .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(
        policy => policy
            .WithOrigins(builder.Configuration.GetValue<string>("AllowedCorsOrigins").Split(';'))
            .AllowAnyMethod()
            .AllowAnyHeader()
    )
);

var app = builder.Build();

await app.Services.MigrateAsync();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.UseCors();
app.Run();