using Acme.OrderManage.MongoDB;
using Volo.Abp.Modularity;

namespace Acme.OrderManage;

[DependsOn(
    typeof(OrderManageMongoDbTestModule)
    )]
public class OrderManageDomainTestModule : AbpModule
{

}
