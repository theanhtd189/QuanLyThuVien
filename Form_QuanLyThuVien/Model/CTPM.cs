namespace Form_QuanLyThuVien.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPM")]
    public partial class CTPM
    {
        public int ID { get; set; }

        public int? Maphieu { get; set; }

        public int? Masach { get; set; }

        [StringLength(50)]
        public string Tensach { get; set; }

        public double? Giatien { get; set; }

        [StringLength(50)]
        public string Theloai { get; set; }

        public int? Soluong { get; set; }

        public double? TongTien { get; set; }
    }
}
