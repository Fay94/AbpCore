using AbpCore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpCore.Permissions
{
    public class AbpCorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpCorePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpCorePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpCoreResource>(name);
        }
    }
}
