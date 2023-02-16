using System.Threading.Tasks;

namespace Americasa.ManagementApp.Data;

public interface IManagementAppDbSchemaMigrator
{
    Task MigrateAsync();
}
