using Amazon.Lambda.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Project.Domain.Application.Dtos.Responses;

namespace Template.Project.Domain.Application.Services.Interfaces
{
    public interface IAnvisaService
    {
        void WriteSomething(ILambdaContext context);

        Task<IEnumerable<TemplateResponse>> GetAllAsync();
    }
}
