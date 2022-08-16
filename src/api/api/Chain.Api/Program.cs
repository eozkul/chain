using Chain.Common;
using Chain.Data.Context;
using Chain.Data.Services.Extensions;
using Chain.Entities;
using Chain.Mapper;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<Settings>(builder.Configuration.GetSection(nameof(Settings)));
var section = builder.Configuration.GetSection($"{nameof(Settings)}");
var settings = section.Get<Settings>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddData(builder.Configuration);
builder.Services.AddIdentity<AppUser, IdentityRole>() //Identity
    .AddEntityFrameworkStores<ChainDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddData(builder.Configuration).AddDataServices().AddAutoMapper();
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddCors(option => { option.AddPolicy(builder.Environment.EnvironmentName, p => { p.AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader(); }); });
}

var app = builder.Build();

// authorization
builder.Services.AddAuthorization();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
public partial class Program
{ }
