using Microsoft.EntityFrameworkCore;
using TodoApi.Model;
using TodoApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlServer<DbContextApi>(builder.Configuration.GetConnectionString("cnClientes"));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
