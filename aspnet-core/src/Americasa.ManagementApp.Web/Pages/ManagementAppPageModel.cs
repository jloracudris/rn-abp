using Americasa.ManagementApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Americasa.ManagementApp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ManagementAppPageModel : AbpPageModel
{
    protected ManagementAppPageModel()
    {
        LocalizationResourceType = typeof(ManagementAppResource);
    }
}
