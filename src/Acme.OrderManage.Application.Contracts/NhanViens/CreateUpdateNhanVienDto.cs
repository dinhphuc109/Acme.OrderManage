using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.OrderManage.NhanViens
{
    public class CreateUpdateNhanVienDto
    {
        [Required]
        [StringLength(128)]
        public string Ten { get; set; }
        [Required]
        public string Tuoi { get; set; }
        [Required]
        public Boolean GioiTinh { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; } 
        //[Required]
        //public int Quantity { get; set; }
        [Required]
        public String QueQuan { get; set; }
    }
}
