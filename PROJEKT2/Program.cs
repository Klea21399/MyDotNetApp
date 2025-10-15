using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> f801b07 (Update Program.cs)
=======

>>>>>>> 85c6b79 (Update Program.cs)
// Test commit for GitHub Actions

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

app.UseAuthorization();
app.MapControllers();

<<<<<<< HEAD
app.MapGet("/", () => "Welcome to MyDotnetApp");

<<<<<<< HEAD
app.Urls.Add("http://0.0.0.0:8080");
=======
// Root endpoint
app.MapGet("/", () => "Welcome to MyDotnetApp");
>>>>>>> 85c6b79 (Update Program.cs)
=======
// Detyro portin 8080
app.Urls.Add("http://0.0.0.0:8080");
>>>>>>> 3b6c904 (Update Program.cs)

app.Run();
