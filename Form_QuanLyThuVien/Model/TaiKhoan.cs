namespace Form_QuanLyThuVien.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(10)]
        public string UserID { get; set; }

        [StringLength(50)]
        public string Matkhau { get; set; }

        [StringLength(50)]
        public string Loai { get; set; }
    }
}
