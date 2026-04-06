using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBP.DATA
{
    [Table("Log")]
    public class Log
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime ThoiGian { get; set; }

        [Required]
        [StringLength(100)]
        public string NguoiDung { get; set; }

        [Required]
        [StringLength(100)]
        public string HanhDong { get; set; }

        [Required]
        public string NoiDung { get; set; }

        [StringLength(20)]
        public string LoaiLog { get; set; } // Info, Warning, Error
    }
}
