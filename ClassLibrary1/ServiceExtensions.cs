using FluentValidation;
using BusinessLogic;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using data_access.Data;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using AutoMapper;
using BusinessLogic.Profiles;

namespace BusinessLogic
{
    public static class ServiceExtensions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddSingleton(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ApplicationProfile(provider.CreateScope().ServiceProvider.GetService<IFileService>()!));
            }).CreateMapper());
        }

        public static void AddFluentValidators(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            // enable client-side validation
            services.AddFluentValidationClientsideAdapters();
            // Load an assembly reference rather than using a marker type.
            services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        }

        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IProductsService, ProductsService>();
            services.AddScoped<IFileService, LocalFileService>();
        }
    }
}