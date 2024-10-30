using JW.WCS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace JW.WCS.Permissions;

public class WCSPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(WCSPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(WCSPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<WCSResource>(name);
    }
}
