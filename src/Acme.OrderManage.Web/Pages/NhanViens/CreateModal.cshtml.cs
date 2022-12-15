using Acme.OrderManage.NhanViens;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Acme.OrderManage.Web.Pages.NhanViens
{
    public class CreateModalModel : OrderManagePageModel
    {
        [BindProperty]
        public CreateUpdateNhanVienDto NhanVien { get; set; }

        private readonly INhanVienAppService _nhanVienAppService;

        public CreateModalModel(INhanVienAppService nhanVienAppService)
        {
            _nhanVienAppService = nhanVienAppService;
        }

        public void OnGet()
        {
            NhanVien = new CreateUpdateNhanVienDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _nhanVienAppService.CreateAsync(NhanVien);
            return NoContent();
        }
    }
}
