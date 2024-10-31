using modulo_api.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicionar serviços para controladores
builder.Services.AddDbContext<AgendaContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{

  app.UseSwagger();
  app.UseSwaggerUI();

}

app.UseHttpsRedirection();

// Mapear os controladores
app.MapControllers();

app.Run();