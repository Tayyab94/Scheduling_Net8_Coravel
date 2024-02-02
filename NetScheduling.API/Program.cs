using Coravel;
using Coravel.Scheduling.Schedule.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using NetScheduling;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScheduler();
builder.Services.AddTransient<MyRepeatableTask>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Once we hit This (endpoint)
app.MapGet("/emample", (IScheduler scheduler) =>
{

   // Invoking the Scheduler
    scheduler.Schedule<MyRepeatableTask>().EverySeconds(3);

    return Results.Ok("Done");
}).WithName("Example").WithOpenApi();

app.Run();

