using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;


namespace Acme.OrderManage.NhanViens
{
    public class NhanVienAppService :
        CrudAppService<
            NhanVien,
            NhanVienDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateNhanVienDto>, 
        INhanVienAppService 
    {
        public NhanVienAppService(IRepository<NhanVien, Guid> repository)
            : base(repository)
        {

        }
    }
}
