using DotnetCore.BestPractices.Core.Interfaces.Repositories;
using DotnetCore.BestPractices.Core.Interfaces.Services;
using DotnetCore.BestPractices.Core.Interfaces.UnitOfWorks;
using DotnetCore.BestPractices.Data.Concrete.EntityFrameworkCore.Repositories;
using DotnetCore.BestPractices.Data.Concrete.EntityFrameworkCore.UnitOfWorks;
using DotnetCore.BestPractices.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetCore.BestPractices.Service.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepositoryGeneric<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IServiceGeneric<>), typeof(GenericService<>));

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
