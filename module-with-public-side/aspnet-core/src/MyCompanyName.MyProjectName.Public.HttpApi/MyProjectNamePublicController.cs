using MyCompanyName.MyProjectName.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyCompanyName.MyProjectName;

public abstract class MyProjectNamePublicController : AbpControllerBase
{
    protected MyProjectNamePublicController()
    {
        LocalizationResource = typeof(MyProjectNameResource);
    }
}
