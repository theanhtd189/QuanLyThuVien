namespace Form_QuanLyThuVien.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocGia")]
    public partial class DocGia
    {
        [Key]
        public int Madocgia { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Namsinh { get; set; }

        public bool? Gioitinh { get; set; }

        [StringLength(50)]
        public string Lop { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaytao { get; set; }

        public int? Manhanvien { get; set; }
    }
}
