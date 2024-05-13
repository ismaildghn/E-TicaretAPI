﻿
using ETicaret.Application.Abstractions.Storage;
using ETicaret.Application.Abstractions.Token;
using ETicaretAPI.Infrastructure.Services;
using ETicaretAPI.Infrastructure.Services.Storage;
using ETicaretAPI.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Infrastructure
{
    public static class ServiceRegistration
    {

        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
           serviceCollection.AddScoped<IStorageService, StorageService>();
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
        }

        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : Storage, IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
        }
    }
}
