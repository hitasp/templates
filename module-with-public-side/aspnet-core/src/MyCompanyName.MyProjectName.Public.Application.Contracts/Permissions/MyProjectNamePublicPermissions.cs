using Volo.Abp.Reflection;

namespace MyCompanyName.MyProjectName.Permissions;

public class MyProjectNamePublicPermissions
{
    public const string GroupName = "MyProjectNamePublic";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(MyProjectNamePublicPermissions));
    }
}
