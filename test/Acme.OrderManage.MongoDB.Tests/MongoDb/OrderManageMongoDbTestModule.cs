using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace Acme.OrderManage.MongoDB;

[DependsOn(
    typeof(OrderManageTestBaseModule),
    typeof(OrderManageMongoDbModule)
    )]
public class OrderManageMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var stringArray = OrderManageMongoDbFixture.ConnectionString.Split('?');
        var connectionString = stringArray[0].EnsureEndsWith('/') +
                                   "Db_" +
                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = connectionString;
        });
    }
}
