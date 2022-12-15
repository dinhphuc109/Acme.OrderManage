using System.Threading.Tasks;
using Acme.OrderManage.Localization;
using Acme.OrderManage.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Acme.OrderManage.Web.Menus;

public class OrderManageMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<OrderManageResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                OrderManageMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );
        context.Menu.AddItem(
    new ApplicationMenuItem(
        "NhanVien",
        l["Menu:NhanVien"],
        icon: "fa fa-book"
    ).AddItem(
        new ApplicationMenuItem(
            "NhanVien.NhanViens",
            l["Menu:NhanVien"],
            url: "/NhanVien"
        )
    )
);


        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
    }
}
