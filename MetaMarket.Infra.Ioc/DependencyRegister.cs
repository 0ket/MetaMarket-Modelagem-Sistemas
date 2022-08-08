using MetaMarket.Application.AutoMapper;
using MetaMarket.Application.Interfaces;
using MetaMarket.Application.Services;
using MetaMarket.Domain.Interfaces;
using MetaMarket.Infra.Data.Context;
using MetaMarket.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MetaMarket.Infra.Ioc;

/// <summary>
/// 
/// </summary>
public static class DependencyRegister
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection AddInfraStructure(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
        ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        //Repositorios 
        services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
        //services.AddScoped<IProductRepository, ProductRepository>();

        //Serviços
        services.AddScoped<IProductCategoryService, ProductCategoryService>();

        services.AddAutoMapper(typeof(DomainToDtoMappingProfile));

        return services;
    }
}
