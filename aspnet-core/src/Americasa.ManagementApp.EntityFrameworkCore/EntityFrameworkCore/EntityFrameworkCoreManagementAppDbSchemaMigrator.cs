using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Americasa.ManagementApp.Data;
using Volo.Abp.DependencyInjection;

namespace Americasa.ManagementApp.EntityFrameworkCore;

public class EntityFrameworkCoreManagementAppDbSchemaMigrator
    : IManagementAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreManagementAppDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ManagementAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ManagementAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
