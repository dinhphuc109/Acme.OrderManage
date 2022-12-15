using System;
using System.Collections.Generic;
using System.Text;
using Acme.OrderManage.Localization;
using Volo.Abp.Application.Services;

namespace Acme.OrderManage;

/* Inherit your application services from this class.
 */
public abstract class OrderManageAppService : ApplicationService
{
    protected OrderManageAppService()
    {
        LocalizationResource = typeof(OrderManageResource);
    }
}
