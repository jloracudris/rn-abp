using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Americasa.ManagementApp.Data;

/* This is used if database provider does't define
 * IManagementAppDbSchemaMigrator implementation.
 */
public class NullManagementAppDbSchemaMigrator : IManagementAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
