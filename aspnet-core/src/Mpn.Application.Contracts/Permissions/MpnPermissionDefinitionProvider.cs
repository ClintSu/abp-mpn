using Mpn.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Mpn.Permissions
{
    public class MpnPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MpnPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(MpnPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MpnResource>(name);
        }
    }
}
