using Microsoft.EntityFrameworkCore;
using Practica_ToDoList.Data;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region DBConfig
// Configuración de la base de datos
builder.Services.AddDbContext<DataContext>(dbContextOptions => dbContextOptions.UseSqlite(builder.Configuration["DB:ConnectionString"]));
#endregion
// Configuración de controladores
builder.Services.AddControllers();

// Configuración de inyección de dependencias para los servicios
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITodoItemService, TodoItemService>();


var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
