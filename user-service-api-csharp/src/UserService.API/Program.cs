using UserService.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false)
    .AddJsonFile("resources.json", false);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddResources(builder.Configuration);
builder.Services.AddServices();
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