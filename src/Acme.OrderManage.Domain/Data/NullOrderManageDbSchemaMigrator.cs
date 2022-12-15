using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.OrderManage.Data;

/* This is used if database provider does't define
 * IOrderManageDbSchemaMigrator implementation.
 */
public class NullOrderManageDbSchemaMigrator : IOrderManageDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
