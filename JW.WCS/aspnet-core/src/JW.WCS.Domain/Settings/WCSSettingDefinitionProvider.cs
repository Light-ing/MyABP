using Volo.Abp.Settings;

namespace JW.WCS.Settings;

public class WCSSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(WCSSettings.MySetting1));
    }
}
