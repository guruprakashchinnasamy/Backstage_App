using Microsoft.OpenApi.Models;
using System;
using System.Net;
using WebApplication1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { 
        Title = "Inventory API",
        Description = "An API to perform Inventory operations",
        Version = "2.10" });

});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.yaml", "Inventory API"));
     
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Lifetime.ApplicationStarted.Register(OnStarted);


app.Run();

void OnStarted()
{

    var wc = new System.Net.WebClient();
    wc.DownloadFile("https://localhost:7175/swagger/v1/swagger.yaml", @"E:\backstage\backstage-dotnet-webapi\Backstage_App\Backstage_docs\SwaggerInventory.yaml");

}