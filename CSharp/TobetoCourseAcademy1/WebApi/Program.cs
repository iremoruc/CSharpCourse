
using Business;
using Business.Mappings;
using Core.DataAccess.Paging;
using DataAccess;
using DataAccess.Abstracts;
using DataAccess.Concretes;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.            
            builder.Services.AddDataAccessServices(builder.Configuration);
            builder.Services.AddBusinessServices();
            builder.Services.AddAutoMapper(typeof(MapProfile));
            //builder.Services.AddScoped(typeof(IPaginate<>),typeof(Paginate<>));
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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}