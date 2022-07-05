namespace Form_QuanLyThuVien.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        public int Manhanvien { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        public bool? Gioitinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaysinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaytao { get; set; }
    }
}
