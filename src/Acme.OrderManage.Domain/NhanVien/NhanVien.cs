using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.OrderManage.NhanViens
{
    public class NhanVien : AuditedAggregateRoot<Guid>
    {
        public string Ten { get; set; }
        public String Tuoi { get; set; }
        public Boolean GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public String QueQuan { get; set; }
    }
}
