using Acme.OrderManage.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.OrderManage.Permissions;

public class OrderManagePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OrderManagePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(OrderManagePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OrderManageResource>(name);
    }
}
