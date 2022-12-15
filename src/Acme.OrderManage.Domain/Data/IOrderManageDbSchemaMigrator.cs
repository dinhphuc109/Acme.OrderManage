using System.Threading.Tasks;

namespace Acme.OrderManage.Data;

public interface IOrderManageDbSchemaMigrator
{
    Task MigrateAsync();
}
