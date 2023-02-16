using Americasa.ManagementApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Americasa.ManagementApp.Permissions;

public class ManagementAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ManagementAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ManagementAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ManagementAppResource>(name);
    }
}
