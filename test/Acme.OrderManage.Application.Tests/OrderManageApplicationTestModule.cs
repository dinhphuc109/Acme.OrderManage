using Volo.Abp.Modularity;

namespace Acme.OrderManage;

[DependsOn(
    typeof(OrderManageApplicationModule),
    typeof(OrderManageDomainTestModule)
    )]
public class OrderManageApplicationTestModule : AbpModule
{

}
