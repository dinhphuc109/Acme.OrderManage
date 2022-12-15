using Acme.OrderManage.NhanViens;
using AutoMapper;

namespace Acme.OrderManage;

public class OrderManageApplicationAutoMapperProfile : Profile
{
    public OrderManageApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<NhanVien, NhanVienDto>();
        CreateMap<CreateUpdateNhanVienDto, NhanVien>();
    }
}
