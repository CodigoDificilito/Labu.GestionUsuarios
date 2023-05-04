using Application.Interfaces.IAspirante;
using Application.Interfaces.IEmpresa;
using Application.Interfaces.IPersona;
using Application.Interfaces.IRecruiter;
using Application.Interfaces.IUsuario;
using Application.UseCase.Services;
using Application.UseCase.Services.SAspirante;
using Application.UseCase.Services.SEmpresa;
using Application.UseCase.Services.SPersona;
using Application.UseCase.Services.SRecruiter;
using Application.UseCase.Services.SUsuario;
using Domain.Entities;
using Infrastructure.Commands;
using Infrastructure.Persistence;
using Infrastructure.Querys;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//custom
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));



builder.Services.AddScoped<IAspiranteCommandService, AspiranteCommandService>();
builder.Services.AddScoped<IAspiranteQueryService, AspiranteQueryService>();
builder.Services.AddScoped<IAspiranteCommand, AspiranteCommand>();
builder.Services.AddScoped<IAspiranteQuery, AspiranteQuery>();

builder.Services.AddScoped<IEmpresaCommandService, EmpresaCommandService>();
builder.Services.AddScoped<IEmpresaQueryService, EmpresaQueryService>();
builder.Services.AddScoped<IEmpresaCommand, EmpresaCommand>();
builder.Services.AddScoped<IEmpresaQuery, EmpresaQuery>();

builder.Services.AddScoped<IPersonaCommandService, PersonaCommandService>();
builder.Services.AddScoped<IPersonaQueryService, PersonaQueryService>();
builder.Services.AddScoped<IPersonaCommand, PersonaCommand>();
builder.Services.AddScoped<IPersonaQuery, PersonaQuery>();

builder.Services.AddScoped<IRecruiterCommandService,RecruiterCommandService>();
builder.Services.AddScoped<IRecuiterQueryService, RecruiterQueryService>();
builder.Services.AddScoped<IRecruiterCommand, RecruiterCommand>();
builder.Services.AddScoped<IRecruiterQuery, RecruiterQuery>();

builder.Services.AddScoped<IUsuarioCommandService, UsuarioCommandService>();
builder.Services.AddScoped<IUsuarioQueryService, UsuarioQueryService>();
builder.Services.AddScoped<IUsuarioCommand, UsuarioCommand>();
builder.Services.AddScoped<IUsuarioQuery, UsuarioQuery>();



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

app.Run();
