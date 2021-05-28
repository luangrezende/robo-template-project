﻿using Template.Project.Domain.Application.Services.Interfaces;
using Template.Project.Domain.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Template.Project.CrossCutting.DI
{
    public static class Service
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IAnvisaService, AnvisaService>();

            return serviceCollection;
        }
    }
}
