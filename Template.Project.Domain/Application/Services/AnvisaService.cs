using Amazon.Lambda.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Template.Project.Domain.Application.Dtos.Responses;
using Template.Project.Domain.Application.Services.Interfaces;

namespace Template.Project.Domain.Application.Services
{
    public class AnvisaService : IAnvisaService
    {
        public AnvisaService()
        {

        }

        public Task<IEnumerable<TemplateResponse>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void WriteSomething(ILambdaContext context)
        {
            context.Logger.LogLine("Test log!");
        }
    }
}
