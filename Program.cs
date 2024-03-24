using Data;
using Microsoft.EntityFrameworkCore;
using Services; 
using Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


var connectionString = builder.Configuration.GetConnectionString("DbConnection") ?? throw new InvalidOperationException("Could not find connection string 'DbConnection'.");

builder.Services.AddDbContext<MyWorldDbContext>(options =>
{
    options.UseSqlServer(connectionString, sqlOptions => sqlOptions.EnableRetryOnFailure());
});

// Register your services with the dependency injection container
builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<StudentRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.UseAuthorization();

app.Run();
