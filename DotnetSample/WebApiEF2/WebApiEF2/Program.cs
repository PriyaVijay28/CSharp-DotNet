using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using WebApiEF2;
using WebApiEF2.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PETDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("PetConnectionString")));
builder.Services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<PetValidator>());

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
