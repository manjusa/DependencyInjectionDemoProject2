using DependencyInjectionDemoProject2.BusinessDomain;
using DependencyInjectionDemoProject2.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<Dog>();
builder.Services.AddScoped<Duck>();
builder.Services.AddScoped<Cat>();
builder.Services.AddTransient<Func<MakeSoundEnum, IMakeSound>>
    (soundProvider => key =>
    {
        switch (key)
        {
            case MakeSoundEnum.Cat:
                return soundProvider.GetService<Cat>();
            case MakeSoundEnum.Dog:
                return soundProvider.GetService<Dog>();
            case MakeSoundEnum.Duck:
                return soundProvider.GetService<Duck>();
            default:
                return null;
        }

    });
var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
