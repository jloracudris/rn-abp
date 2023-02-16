using Volo.Abp.Settings;

namespace Americasa.ManagementApp.Settings;

public class ManagementAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ManagementAppSettings.MySetting1));
    }
}
