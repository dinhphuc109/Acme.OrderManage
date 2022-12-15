using Acme.OrderManage.NhanViens;
using AutoMapper;

namespace Acme.OrderManage.Web;

public class OrderManageWebAutoMapperProfile : Profile
{
    public OrderManageWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<NhanVienDto, CreateUpdateNhanVienDto>();
    }
}
