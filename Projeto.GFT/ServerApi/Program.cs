using ServerApi.Domain.Interfaces;
using ServerApi.Domain.Services;
using ServerApi.Infra.Repositories;
using System.Diagnostics.CodeAnalysis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IInvestimentoService, InvestimentoServices>();

builder.Services.AddScoped<ICDIRepository, CDIRepository>();
builder.Services.AddScoped<ITBRepository, TBRepository>();
builder.Services.AddScoped<IImpostoRepository, ImpostoRepository>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
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

app.UseAuthorization();

app.MapControllers();

app.UseCors();

app.Run();


[ExcludeFromCodeCoverage]
public partial class Program() { }
