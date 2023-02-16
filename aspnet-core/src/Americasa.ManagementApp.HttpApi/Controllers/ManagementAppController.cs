using Americasa.ManagementApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Americasa.ManagementApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ManagementAppController : AbpControllerBase
{
    protected ManagementAppController()
    {
        LocalizationResource = typeof(ManagementAppResource);
    }
}
