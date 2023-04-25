using MyCompanyName.MyProjectName.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MyCompanyName.MyProjectName.Public.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MyProjectNamePublicPageModel : AbpPageModel
{
    protected MyProjectNamePublicPageModel()
    {
        LocalizationResourceType = typeof(MyProjectNameResource);
        ObjectMapperContext = typeof(MyProjectNamePublicWebModule);
    }
}
