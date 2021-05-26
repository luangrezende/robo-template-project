﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Project.Domain.Application.Services.Interfaces
{
    public interface IConfigurationService
    {
        IConfiguration GetConfiguration();
    }
}