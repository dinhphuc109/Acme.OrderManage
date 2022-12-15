using Acme.OrderManage.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.OrderManage.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OrderManageController : AbpControllerBase
{
    protected OrderManageController()
    {
        LocalizationResource = typeof(OrderManageResource);
    }
}
