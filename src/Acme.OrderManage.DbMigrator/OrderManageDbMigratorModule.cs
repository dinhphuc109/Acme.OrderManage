using Acme.OrderManage.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.OrderManage.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OrderManageMongoDbModule),
    typeof(OrderManageApplicationContractsModule)
    )]
public class OrderManageDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
