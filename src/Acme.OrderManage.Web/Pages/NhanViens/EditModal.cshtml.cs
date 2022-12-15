using Acme.OrderManage.NhanViens;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;

namespace Acme.OrderManage.Web.Pages.NhanViens
{
    public class EditModalModel : OrderManagePageModel
    {

        
            [HiddenInput]
            [BindProperty(SupportsGet = true)]
            public Guid Id { get; set; }

            [BindProperty]
            public CreateUpdateNhanVienDto NnhanVien { get; set; }

            private readonly INhanVienAppService _nhanVienAppService;

            public EditModalModel(INhanVienAppService nhanVienAppService)
            {
                _nhanVienAppService = nhanVienAppService;
            }

            public async Task OnGetAsync()
            {
                var nhanVienDto = await _nhanVienAppService.GetAsync(Id);
            NnhanVien = ObjectMapper.Map<NhanVienDto, CreateUpdateNhanVienDto>(nhanVienDto);
            }

            public async Task<IActionResult> OnPostAsync()
            {
                await _nhanVienAppService.UpdateAsync(Id, NnhanVien);
                return NoContent();
            }
        }
    

}

