using MediatR;
using Microsoft.EntityFrameworkCore;
using SgbdProject.Application.Interfaces;
using SgbdProject.Infrastructure;
using SgbdProject.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();

// Register ApplicationDbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register repositories
builder.Services.AddScoped<IUniversityRepository, UniversityRepository>();
// Register other repositories similarly

// Register MediatR
builder.Services.AddMediatR(typeof(Program));

// Register AutoMapper
builder.Services.AddAutoMapper(typeof(Program));

// Build the app
var app = builder.Build();

// Configure the HTTP request pipeline
app.UseRouting();
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.Run();