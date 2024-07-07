using RealEstate_Dapper_Api.Models.DapperContext;
using RealEstate_Dapper_Api.Repositories.BottomGridRepositories;
using RealEstate_Dapper_Api.Repositories.BottomGridRepository;
using RealEstate_Dapper_Api.Repositories.CategoryRepository;
using RealEstate_Dapper_Api.Repositories.PopularLocationRepositories;
using RealEstate_Dapper_Api.Repositories.ProductRepository;
using RealEstate_Dapper_Api.Repositories.ServiceRepository;
using RealEstate_Dapper_Api.Repositories.TestimonialRepositories;
using RealEstate_Dapper_Api.Repositories.TestimonialRepository;
using RealEstate_Dapper_Api.Repositories.WhoWeAreRepository;

namespace RealEstate_Dapper_Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddTransient<Context>();
            builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
            builder.Services.AddTransient<IProductRepository, ProductRepository>();
            builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
            builder.Services.AddTransient<IServiceReposityory, ServiceRepository>();
            builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
            builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            //builder.Services.AddTransient<IStatisticsRepository,StatisticsRepository>();
            //builder.Services.AddTransient<IEmployeeRepository,EmployeeRepository>();


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
        }
    }
}
