using Americasa.ManagementApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Americasa.ManagementApp;

[DependsOn(
    typeof(ManagementAppEntityFrameworkCoreTestModule)
    )]
public class ManagementAppDomainTestModule : AbpModule
{

}
