using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Form_QuanLyThuVien.Model
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<CTPM> CTPMs { get; set; }
        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<NguoiQuanLy> NguoiQuanLies { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuMuon> PhieuMuons { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.UserID)
                .IsFixedLength();
        }
    }
}
