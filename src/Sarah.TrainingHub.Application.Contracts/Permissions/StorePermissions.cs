namespace Sarah.TrainingHub.Permissions;

public static class StorePermissions
{
    public const string GroupName = "Store";


    public static class Subjects
    {
        public const string Default = GroupName + ".Subjects";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    
    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
}
