using Volo.Abp.Settings;

namespace Mpn.Settings
{
    public class MpnSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MpnSettings.MySetting1));
        }
    }
}
