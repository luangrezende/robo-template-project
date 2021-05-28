using Template.Project.Domain.Application.Services.Interfaces;
using Template.Project.Domain.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Template.Project.CrossCutting.DI;
using Amazon.Lambda.Core;
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Template.Project.Application.Lambda
{
    public class Function
    {
        private readonly IServiceCollection _serviceCollection;
        private readonly IAnvisaService _anvisaService;

        public Function()
        {
            _serviceCollection = new ServiceCollection();
            _anvisaService = new AnvisaService();
            _serviceCollection.AddServices();
        }

        /// <summary>
        /// Starts AI
        /// </summary>
        public void FunctionHandler(ILambdaContext context)
        {
            _anvisaService.WriteSomething(context);
        }

        //public APIGatewayProxyResponse Get(APIGatewayProxyRequest request, ILambdaContext context)
        //{
        //    context.Logger.LogLine("Get Request\n");

        //    var response = new APIGatewayProxyResponse
        //    {
        //        StatusCode = (int)HttpStatusCode.OK,
        //        Body = "Hello AWS Serverless",
        //        Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
        //    };

        //    return response;
        //}
    }
}
