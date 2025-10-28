using ApplicativoTalhonario.Bussines.Interfaces.Repository;
using ApplicativoTalhonario.Bussines.Interfaces.Service;
using ApplicativoTalhonario.Data.Context;
using ApplicativoTalhonario.Data.Repositories;
using ApplicativoTalhonario.Services;
using Microsoft.EntityFrameworkCore;

namespace ApplicativoTalhonario;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<IClientService, ClientService>();
        builder.Services.AddScoped<IOfferderService, OffenderService>();

        builder.Services.AddScoped<IOffenderRepository, OffenderRepository>();
        builder.Services.AddScoped<IClientRepository, ClientRepository>();

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        var mysqlString = "server=localhost; port=3306; database=talhonario_api; user=root; password=toribash; Persist Security Info =False; Convert Zero Datetime=True";
        builder.Services.AddDbContext<BaseContext>(options =>
            options.UseMySql(mysqlString, ServerVersion.AutoDetect(mysqlString)
            ));

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
    }
}