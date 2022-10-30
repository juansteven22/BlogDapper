using Core.Interfaces;
using Infraestructura;
using Infraestructura.Repositories;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

builder.Services.AddScoped<IPublicacionRepository, PublicacionRepository>();

builder.Services.AddSingleton<DapperContext>();

app.UseHttpsRedirection();

app.Run();