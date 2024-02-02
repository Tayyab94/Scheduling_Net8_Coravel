

using Coravel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetScheduling;

var builder = Host.CreateApplicationBuilder();

builder.Services.AddScheduler();


//builder.Services.AddTransient<MyRepeatableTask>();
var app = builder.Build();

app.Services.UseScheduler(scheduler =>
{
    //scheduler.ScheduleAsync(async () => {

    //    await Task.Delay(20);
    //    Console.WriteLine("This was scheduled");
    //    }).EverySeconds(2);

    //scheduler.Schedule<MyRepeatableTask>().EverySeconds(3);


    scheduler.ScheduleWithParams<MyRepeatableTask>("http://localhote:9000").EverySeconds(2);
});


app.Run();