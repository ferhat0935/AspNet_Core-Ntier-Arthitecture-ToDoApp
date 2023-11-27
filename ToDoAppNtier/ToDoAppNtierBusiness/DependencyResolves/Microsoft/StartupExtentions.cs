using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using ToDoAppNtierBusiness.Interfaces;
using ToDoAppNtierBusiness.Mappings.AutoMapper;
using ToDoAppNtierBusiness.Services;
using ToDoAppNtierBusiness.ValidationRules;
using ToDoAppNtierDataAccess.Context;
using ToDoAppNtierDataAccess.UnitOfWork;
using ToDoAppNtierDtos.WorkDtos;

namespace ToDoAppNtierBusiness.DependencyResolves.Microsoft
{
    public static class StartupExtentions
    {
        public static void AddDependencies(this IServiceCollection services)
        {

            services.AddDbContext<ToDoContext>(opt =>
            {
                opt.UseSqlServer("Server=FERHATSOLMAZZ\\SQLEXPRESS; Database=ToDoAppDb; User Id=ferhat; Password=ferhat0935; TrustServerCertificate=True");
                opt.LogTo(Console.WriteLine, LogLevel.Information);
            });
            //auto mapper config
            var configuration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new WorkProfile());
            });
            var mapper=configuration.CreateMapper();


            services.AddSingleton(mapper);
            services.AddScoped<IUOW, UOW>();
            services.AddScoped<IWorkService, WorkManager>();
            services.AddTransient<IValidator<WorkCreateDto>,WorkCreateDtoValidator>();
            services.AddTransient<IValidator<WorkUpdateDto>, WorkUpdateDtoValidator>();

        }
    }
}
