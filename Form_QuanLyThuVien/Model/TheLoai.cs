namespace Form_QuanLyThuVien.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TheLoai")]
    public partial class TheLoai
    {
        [Key]
        public int Matheloai { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }
    }
}
