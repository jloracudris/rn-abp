using Volo.Abp.Modularity;

namespace Americasa.ManagementApp;

[DependsOn(
    typeof(ManagementAppApplicationModule),
    typeof(ManagementAppDomainTestModule)
    )]
public class ManagementAppApplicationTestModule : AbpModule
{

}
