using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_QuanLyThuVien.Model
{
    public class ChiTietPhieu_Common
    {
        public int Masach { set; get; }
        public string Tensach { get; set; }
        public string Tacgia { set; get; }
        public string Theloai { get; set; }
    }
    public class Phieu_Common
    {
        public string DisplayID { get; set; }
        public int Maphieu { set; get; }
        public string Nguoimuon { get; set; }
        public string Nhanvien { get; set; }
        public DateTime Ngaymuon { set; get; }
        public DateTime Ngaytra { get; set; }
        public string Trangthai { set; get; }
    }
    public class Sach_Common
    {
        public int Masach { get; set; }
        public string Ten { get; set; }
        public string Tacgia { get; set; }
        public string NXB { get; set; }
        public string Namxuatban { get; set; }
        public int Matheloai { get; set; }
        public int? Soluong { get; set; }
        public double? Giatien { set; get; }
        public string TenTheLoai { get; set; }
        public string Mota { get;set; }
    }
    public class Nhanvien_Common
    {
        public int Manhanvien { get; set; }
        public string Ten { get; set; }

        public string Gioitinh { get; set; }

        public DateTime? Ngaysinh { get; set; }

        public DateTime? Ngaytao { get; set; }
    }
    public class Docgia_Common
    {
        public int Madocgia { get; set; }

        public string Ten { get; set; }

        public DateTime? Namsinh { get; set; }

        public string Gioitinh { get; set; }

        public string Lop { get; set; }

        public DateTime? Ngaytao { get; set; }

        public int? Manhanvien { get; set; }
        public string Tennhanvien { get; set; }
    }
}
