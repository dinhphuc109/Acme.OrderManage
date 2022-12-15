using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.OrderManage.Web;

[Dependency(ReplaceServices = true)]
public class OrderManageBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "OrderManage";
}
