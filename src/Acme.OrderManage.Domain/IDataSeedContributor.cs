using Acme.OrderManage.NhanViens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.OrderManage
{
    public class OrderManageDataSeederContributor
            : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<NhanVien, Guid> _productRepository;

        public OrderManageDataSeederContributor(IRepository<NhanVien, Guid> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _productRepository.GetCountAsync() <= 0)
            {
                await _productRepository.InsertAsync(
                    new NhanVien
                    {
                        Ten = "abc",
                        Tuoi = "18",
                        
                        NgaySinh = new DateTime(2000, 6, 8),

                        QueQuan = "Da Nang"
                    },
                    autoSave: true
                );

                await _productRepository.InsertAsync(
                    new NhanVien
                    {
                        Ten = "abcd",
                        Tuoi = "20",

                        NgaySinh = new DateTime(1998, 6, 8),

                        QueQuan = "Da Nang"
                    },
                    autoSave: true
                );
            }
        }
    }
}
