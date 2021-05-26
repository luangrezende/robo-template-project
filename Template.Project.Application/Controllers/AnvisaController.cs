using Amazon.Lambda.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Project.Application.Lambda.Controllers
{
    public class AnvisaController
    {
        public AnvisaController()
        {

        }

        public async void WriteSomething(ILambdaContext context)
        {
            context.Logger.LogLine("Test log!");
        }
    }
}
