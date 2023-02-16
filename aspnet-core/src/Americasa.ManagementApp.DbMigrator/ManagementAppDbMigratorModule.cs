using Americasa.ManagementApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Americasa.ManagementApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ManagementAppEntityFrameworkCoreModule),
    typeof(ManagementAppApplicationContractsModule)
    )]
public class ManagementAppDbMigratorModule : AbpModule
{

}
