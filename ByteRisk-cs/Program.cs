using ByteRisk_cs.Properties.Application.Interfaces;
using ByteRisk_cs.Properties.Application.Services;
using ByteRisk_cs.Properties.Domain.Interfaces;
using ByteRisk_cs.Properties.Infrastructure.Data.AppData;
using ByteRisk_cs.Properties.Infrastructure.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configurando a string de conexão com o Oracle no banco de dados
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Adicionando as interfaces e classes concretas no framework de injeção de dependência
builder.Services.AddTransient<IBeneficiarioRepository, BeneficiarioRepository>();
builder.Services.AddTransient<IBeneficiarioApplicationService, BeneficiarioApplicationService>();

builder.Services.AddTransient<IPlanoRepository, PlanoRepository>();
builder.Services.AddTransient<IPlanoApplicationService, PlanoApplicationService>();

builder.Services.AddTransient<IConsultaRepository, ConsultaRepository>();
builder.Services.AddTransient<IConsultaApplicationService, ConsultaApplicationService>();

builder.Services.AddTransient<IExameRepository, ExameRepository>();
builder.Services.AddTransient<IExameApplicationService, ExameApplicationService>();

builder.Services.AddTransient<IMedicoRepository, MedicoRepository>();
builder.Services.AddTransient<IMedicoApplicationService, MedicoApplicationService>();

builder.Services.AddTransient<ISinistroRepository, SinistroRepository>();
builder.Services.AddTransient<ISinistroApplicationService, SinistroApplicationService>();

// Adicionando os controllers
builder.Services.AddControllers();

// Configurando a exploração dos endpoints
builder.Services.AddEndpointsApiExplorer();

// Configurando e habilitando a documentação do Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API ByteRisk",
        Version = "v1",
        Description = "API para gestão de beneficiários, planos, consultas, exames, médicos e sinistros"
    });
    c.EnableAnnotations(); // Habilitar anotações no Swagger
});

var app = builder.Build();

// Configurando o pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API ByteRisk V1");
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();
