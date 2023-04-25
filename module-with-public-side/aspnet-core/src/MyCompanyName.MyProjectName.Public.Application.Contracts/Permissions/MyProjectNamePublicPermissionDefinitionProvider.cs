using MyCompanyName.MyProjectName.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyCompanyName.MyProjectName.Permissions;

public class MyProjectNamePublicPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MyProjectNamePublicPermissions.GroupName, L("Permission:MyProjectName:Public"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MyProjectNameResource>(name);
    }
}
