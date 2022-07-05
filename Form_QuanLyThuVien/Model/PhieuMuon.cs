namespace Form_QuanLyThuVien.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuMuon")]
    public partial class PhieuMuon
    {
        [Key]
        public int Maphieu { get; set; }

        public int? Manhanvien { get; set; }

        public int Madocgia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaytao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaytra { get; set; }

        public bool? Trangthai { get; set; }
    }
}
