using Acme.OrderManage.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.OrderManage.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class OrderManagePageModel : AbpPageModel
{
    protected OrderManagePageModel()
    {
        LocalizationResourceType = typeof(OrderManageResource);
    }
}
