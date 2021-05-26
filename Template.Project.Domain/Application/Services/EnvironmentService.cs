using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Project.Domain.Application.Services.Interfaces;
using static Template.Project.Domain.Application.Services.Constants.Configurations;

namespace Template.Project.Domain.Application.Services
{

    public class EnvironmentService : IEnvironmentService
    {
        public EnvironmentService()
        {
            EnvironmentName = Environment.GetEnvironmentVariable(EnvironmentVariables.AspnetCoreEnvironment)
                ?? Environments.Production;
        }

        public string EnvironmentName { get; set; }
    }
}
