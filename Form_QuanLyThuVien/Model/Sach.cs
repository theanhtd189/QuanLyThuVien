namespace Form_QuanLyThuVien.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [Key]
        public int Masach { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }

        [Required]
        [StringLength(50)]
        public string Tacgia { get; set; }

        [Required]
        [StringLength(50)]
        public string NXB { get; set; }

        [Required]
        [StringLength(10)]
        public string Namxuatban { get; set; }

        public int Matheloai { get; set; }

        public double Giatien { get; set; }

        public int Soluong { get; set; }

        public string Mota { get; set; }
    }
}
