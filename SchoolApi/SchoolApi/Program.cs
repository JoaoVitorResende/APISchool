using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddJsonOptions(options =>
    {
        // Aqui definimos as op��es de serializa��o JSON
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;  // Habilita preserva��o de refer�ncias
        options.JsonSerializerOptions.MaxDepth = 32; // Ajusta a profundidade m�xima da serializa��o
    });
builder.Services.AddScoped<IRepository,Repository>();
string connectionString = "Data Source=ProjectSchool.db";
builder.Services.AddDbContext<DataContext>(
    sql => sql.UseSqlite(connectionString));

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
