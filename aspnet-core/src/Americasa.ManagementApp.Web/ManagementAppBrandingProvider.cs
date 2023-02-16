using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Americasa.ManagementApp.Web;

[Dependency(ReplaceServices = true)]
public class ManagementAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ManagementApp";
}
