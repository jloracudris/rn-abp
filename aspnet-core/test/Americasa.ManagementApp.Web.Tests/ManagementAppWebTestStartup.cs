using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Americasa.ManagementApp;

public class ManagementAppWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<ManagementAppWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
