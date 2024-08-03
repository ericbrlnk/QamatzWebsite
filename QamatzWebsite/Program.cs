using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using QamatzWebsite.Data;
using QamatzWebsite.Models;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UserDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnUser")));

builder.Services.AddDbContext<PostDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnPost")));

var app = builder.Build();

// allow communication from port 3000
app.UseCors(options => options.WithOrigins("https://localhost:3000")
.AllowAnyMethod()
.AllowAnyHeader()
);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
