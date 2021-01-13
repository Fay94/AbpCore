using Volo.Abp.Settings;

namespace AbpCore.Settings
{
    public class AbpCoreSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpCoreSettings.MySetting1));
        }
    }
}
