namespace Form_QuanLyThuVien.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiQuanLy")]
    public partial class NguoiQuanLy
    {
        [Key]
        public int Manguoiquanly { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }
    }
}
