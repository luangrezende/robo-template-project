using Amazon.Lambda.DynamoDBEvents;
using Amazon.Lambda.Core;
using System;
using Amazon.DynamoDBv2.Model;
using System.IO;
using System.Text;
using Template.Project.Application.Lambda.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Template.Project.Domain.Application.Services.Interfaces;
using Template.Project.Domain.Application.Services;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Template.Project.Application.Lambda
{
    public class Function
    {
        public IConfigurationService ConfigService { get; }
        private readonly AnvisaController _anvisaController;

        public Function()
        {
            // Set up Dependency Injection
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Get Configuration Service from DI system
            ConfigService = serviceProvider.GetService<IConfigurationService>();

            _anvisaController = new AnvisaController();
        }

        private void ConfigureServices(IServiceCollection serviceCollection)
        {
            // Register services with DI system
            serviceCollection.AddTransient<IEnvironmentService, EnvironmentService>();
            serviceCollection.AddTransient<IConfigurationService, ConfigurationService>();
        }

        public string FunctionHandler(string input, ILambdaContext context)
        {
            _anvisaController.WriteSomething(context);
            return ConfigService.GetConfiguration()[input] ?? "None";
        }

    }
}