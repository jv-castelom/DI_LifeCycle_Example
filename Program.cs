using Castelom.LifeCycleExample.Interfaces;
using Castelom.LifeCycleExample.Services;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency Injection
builder.Services.AddScoped<IPurchaseOrder, PurcharseOrder>();
builder.Services.AddTransient<IApplicationService, ApplicationService>();
builder.Services.AddTransient<ICustomerService, CustomerService>();
builder.Services.AddTransient<IPriceService, PriceService>();

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
