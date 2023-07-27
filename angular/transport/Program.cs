using Microsoft.EntityFrameworkCore;
using transport.Models;
using transport.services.Customerservice;
using transport.services.Shipservice;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ShipsContext>(optionsAction : options =>
options.UseSqlServer(builder.Configuration.GetConnectionString(name: "SQLConnection")));
builder.Services.AddScoped<ShipInterface, Shipservice>();
builder.Services.AddScoped<CustomerInterface, Customerservice>();
builder.Services.AddCors(option =>
{
    option.AddPolicy("ProductPolicy", builder =>
    {
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
        builder.AllowAnyOrigin();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("ProductPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
