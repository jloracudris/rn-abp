using System;
using System.Collections.Generic;
using System.Text;
using Americasa.ManagementApp.Localization;
using Volo.Abp.Application.Services;

namespace Americasa.ManagementApp;

/* Inherit your application services from this class.
 */
public abstract class ManagementAppAppService : ApplicationService
{
    protected ManagementAppAppService()
    {
        LocalizationResource = typeof(ManagementAppResource);
    }
}
