using Sarah.TrainingHub.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Sarah.TrainingHub.Permissions;

public class StorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TrainingHubPermissions.GroupName);

        var subjectsPermission = myGroup.AddPermission(TrainingHubPermissions.Subjects.Default, L("Permission:Subjects"));
        subjectsPermission.AddChild(TrainingHubPermissions.Subjects.Create, L("Permission:Subjects.Create"));
        subjectsPermission.AddChild(TrainingHubPermissions.Subjects.Edit, L("Permission:Subjects.Edit"));
        subjectsPermission.AddChild(TrainingHubPermissions.Subjects.Delete, L("Permission:Subjects.Delete"));
        //Define your own permissions here. Example:

        var coursesPermission = myGroup.AddPermission(TrainingHubPermissions.Courses.Default, L("Permission:Courses"));
        coursesPermission.AddChild(TrainingHubPermissions.Courses.Create, L("Permission:Courses.Create"));
        coursesPermission.AddChild(TrainingHubPermissions.Courses.Edit, L("Permission:Courses.Edit"));
        coursesPermission.AddChild(TrainingHubPermissions.Courses.Delete, L("Permission:Courses.Delete"));

        var curriculumPermission = myGroup.AddPermission(TrainingHubPermissions.Curriculums.Default, L("Permission:Curriculums"));
        curriculumPermission.AddChild(TrainingHubPermissions.Curriculums.Create, L("Permission:Curriculums.Create"));
        curriculumPermission.AddChild(TrainingHubPermissions.Curriculums.Edit, L("Permission:Curriculums.Edit"));
        curriculumPermission.AddChild(TrainingHubPermissions.Curriculums.Delete, L("Permission:Curriculums.Delete"));
        //myGroup.AddPermission(StorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StoreResource>(name);
    }
}
