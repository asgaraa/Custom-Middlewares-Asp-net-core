using Microsoft.Extensions.Logging;
using Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseMiddleware<CustomMiddleware>();
// Configure the HTTP request pipeline.


app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("1");
    await next.Invoke();
    await context.Response.WriteAsync(" 6");
});
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("2");
    await next.Invoke();
    await context.Response.WriteAsync(" 5.");
});
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("3");
    await next.Invoke();
    await context.Response.WriteAsync("4");
});
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//app.MapControllers();

app.Run();
