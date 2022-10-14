using SignalRBackend.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSignalR().AddAzureSignalR("Endpoint=https://tgexamplesignalr.service.signalr.net;AccessKey=lV8Gwks+PvbVuSzT+la08zNI8C3enLZBx6UxQO9UuH4=;Version=1.0;");

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<ActivityImportHub>("/hub/activity-import");
});

app.Run();

