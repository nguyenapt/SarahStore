using Sarah.Store.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Sarah.Store.Permissions;

public class StorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StorePermissions.GroupName);

        var booksPermission = myGroup.AddPermission(StorePermissions.Subjects.Default, L("Permission:Subjects"));
        booksPermission.AddChild(StorePermissions.Subjects.Create, L("Permission:Subjects.Create"));
        booksPermission.AddChild(StorePermissions.Subjects.Edit, L("Permission:Subjects.Edit"));
        booksPermission.AddChild(StorePermissions.Subjects.Delete, L("Permission:Subjects.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(StorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StoreResource>(name);
    }
}
