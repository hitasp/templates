using MyCompanyName.MyProjectName.Localization;
using Volo.Abp.Application.Services;

namespace MyCompanyName.MyProjectName;

public abstract class MyProjectNamePublicAppService : ApplicationService
{
    protected MyProjectNamePublicAppService()
    {
        LocalizationResource = typeof(MyProjectNameResource);
        ObjectMapperContext = typeof(MyProjectNamePublicApplicationModule);
    }
}
