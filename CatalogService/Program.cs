using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/books", () => new[]
{
    new { Id = 1, Title = "Clean Code Book", Author = "Robert C. Martin" },
    new { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt" },
    new { Id = 3, Title = "Domain-Driven Design", Author = "Eric Evans" }
});


app.Run();
