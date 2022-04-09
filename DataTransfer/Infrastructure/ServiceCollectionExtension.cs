using DataTransfer.Application;
using DataTransfer.Domain.Interfaces;
using DataTransfer.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        
        public static IServiceCollection AddDataTransfer(this IServiceCollection services)
        {
       
            services.AddScoped<IExcelManager, ExcelManagerService>();
            services.AddScoped<IRedisCache, RedisCacheService>();
            services.AddScoped<IDataTransformer, DataTransformer>();
            var multiplexer = ConnectionMultiplexer.Connect("localhost: 9191, password = 123456");
            services.AddSingleton<IConnectionMultiplexer>(multiplexer);
            

            return services;
        }
    }
}
