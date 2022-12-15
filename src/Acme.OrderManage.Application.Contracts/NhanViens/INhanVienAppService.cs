using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.OrderManage.NhanViens
{
    public interface INhanVienAppService :
        ICrudAppService< 
            NhanVienDto,
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateNhanVienDto> 
    {

    }
}
