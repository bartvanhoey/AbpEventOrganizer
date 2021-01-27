using Volo.Abp.Settings;

namespace AbpEventOrganizer.Settings
{
    public class AbpEventOrganizerSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpEventOrganizerSettings.MySetting1));
        }
    }
}
