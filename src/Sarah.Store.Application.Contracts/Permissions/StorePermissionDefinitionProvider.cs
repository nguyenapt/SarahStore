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

        var booksPermission = myGroup.AddPermission(StorePermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(StorePermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(StorePermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(StorePermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(StorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StoreResource>(name);
    }
}
