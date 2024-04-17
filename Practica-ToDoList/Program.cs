using Microsoft.EntityFrameworkCore;
using To_Do_List_LC4.Context;
using To_Do_List_LC4.Interfaces;
using To_Do_List_LC4.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region DBConfig
// Configuración de la base de datos
builder.Services.AddDbContext<ToDoContext>(dbContextOptions => dbContextOptions.UseSqlite(builder.Configuration["DB:ConnectionString"]));
#endregion
// Configuración de controladores
builder.Services.AddControllers();

// Configuración de inyección de dependencias para los servicios
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IToDoItemService, ToDoItemService>();


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
