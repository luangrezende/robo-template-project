using Amazon.Lambda.DynamoDBEvents;
using Amazon.Lambda.Core;
using System;
using Amazon.DynamoDBv2.Model;
using System.IO;
using System.Text;
using Template.Project.Application.Lambda.Controllers;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Template.Project.Application.Lambda
{
    public class Function
    {
        private readonly AnvisaController _anvisaController;

        public Function()
        {
            _anvisaController = new AnvisaController();
        }

        public void FunctionHandler(DynamoDBEvent dynamoEvent, ILambdaContext context)
        {
            _anvisaController.WriteSomething(context);
        }
    }
}