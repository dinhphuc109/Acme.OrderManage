using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;

namespace Acme.OrderManage.NhanViens
{
    public class NhanVienDto : AuditedEntityDto<Guid>
    {
        public string Ten { get; set; }
        public String Tuoi { get; set; }
        public Boolean GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public String QueQuan { get; set; }
    }
}
