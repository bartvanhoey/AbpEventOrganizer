using AbpEventOrganizer.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpEventOrganizer.Permissions
{
    public class AbpEventOrganizerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpEventOrganizerPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpEventOrganizerPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpEventOrganizerResource>(name);
        }
    }
}
