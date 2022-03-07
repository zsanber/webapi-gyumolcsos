using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Solution.Core.Conext;
using Solution.Core.Interfaces.IRepositories;
using Solution.Core.Interfaces.IServices;
using Solution.Repository;
using Solution.Services;

namespace Solution.Middleware
{
    public static class DipendencyInjection
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>  options.UseSqlServer("Server=.\\SQLEXPRESS;Database=AoVDb;Trusted_Connection=True"));

            services.AddTransient<IFruitService, FruitService>();
            services.AddTransient<IFruitRepository, FruitRepository>();

            services.AddTransient<INutritionInfoService, NutritionInfoService>();
            services.AddTransient<INutritionInfoRepository, NutritionInfoRepository>();

            // Add useful interface for accessing the ActionContext outside a controller.
            services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();

            // Add useful interface for accessing the HttpContext outside a controller.
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Add useful interface for accessing the IUrlHelper outside a controller.
            services.AddScoped<IUrlHelper>(x => x.GetRequiredService<IUrlHelperFactory>()
                            .GetUrlHelper(x.GetRequiredService<IActionContextAccessor>().ActionContext));

        }
    }
}
