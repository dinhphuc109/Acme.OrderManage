using Acme.OrderManage.NhanViens;
using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Acme.OrderManage.MongoDB;

[ConnectionStringName("Default")]
public class OrderManageMongoDbContext : AbpMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */
    public class BookStoreMongoDbContext : AbpMongoDbContext
    {
        public IMongoCollection<NhanVien> NhanVien => Collection<NhanVien>();
        //...
    }


    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //builder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});
    }
}
