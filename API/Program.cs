using DAL.Context;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//Inyeccion de dependencia del context
builder.Services.AddDbContext<BibliotecaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BibliotecaConnection")));


//Inyeccion de dependencia del LibroRepositorio
builder.Services.AddScoped<ILibroRepository, LibroRepository>();

//builder.Services.AddTransient<ILibroRepository, LibroRepository>();





//builder.Services.AddDbContext<BibliotecaContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("BibliotecaConnection"),
//        sqlServerOptionsAction: sqlOptions =>
//        {
//            sqlOptions.EnableRetryOnFailure(
//                maxRetryCount: 5,  // Número máximo de intentos
//                maxRetryDelay: TimeSpan.FromSeconds(30), // Tiempo máximo de espera entre intentos
//                errorNumbersToAdd: null);
//        })
//);


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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


