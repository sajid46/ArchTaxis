using Microsoft.EntityFrameworkCore;
using TaxiBoxAPI.Models.Models;
using TaxiBoxAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "TaxiBoxAPI", Version = "v1" });
//});

builder.Services.AddSwaggerGen();


builder.Services.AddScoped<ITaxiBoxRepository, TaxiBoxRepository>();
builder.Services.AddDbContext<TaxiBoxContext>();
builder.Configuration.GetConnectionString("DefaultConnection");

var policyName = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policyName,
                      builder =>
                      {
                          builder
                            .WithOrigins("http://localhost:4200") // specifying the allowed origin
                            .WithMethods("GET") // defining the allowed HTTP method
                            .AllowAnyHeader(); // allowing any header to be sent
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(policyName);
app.UseAuthorization();

app.MapControllers();

app.Run();
