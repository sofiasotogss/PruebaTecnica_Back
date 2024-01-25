using backEnd_Lubee.Data;
using Microsoft.EntityFrameworkCore;
using backEnd_Lubee.Service;

var builder = WebApplication.CreateBuilder(args);

// Configuración de la cadena de conexión para MySQL
var connectionString = builder.Configuration.GetConnectionString("connection");

builder.Services.AddDbContext<DBContexLubee>(options =>
{
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 23)));
});

builder.Services.AddTransient(typeof(IRepositorio<>), typeof(Repositorio<>));

builder.Services.AddScoped<IContratoService, ContratoService>();
//builder.Services.AddScoped<IRepositorio<Contrato>, Repositorio<Contrato>>();
//builder.Services.AddScoped<IRepositorio<DetalleContrato>, Repositorio<DetalleContrato>>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAnyOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
