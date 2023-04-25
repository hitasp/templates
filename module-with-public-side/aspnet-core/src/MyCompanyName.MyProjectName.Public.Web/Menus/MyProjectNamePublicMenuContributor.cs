using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace MyCompanyName.MyProjectName.Public.Web.Menus;

public class MyProjectNamePublicMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == "Public.Main")
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(MyProjectNamePublicMenus.Prefix, displayName: "MyProjectName", "~/MyProjectName", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
