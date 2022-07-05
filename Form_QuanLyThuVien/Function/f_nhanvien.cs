using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Form_QuanLyThuVien.Model;

namespace Form_QuanLyThuVien.Function
{
    public class f_nhanvien
    {
        Context db = new Context();
        public NhanVien Get(int id)
        {
            return db.NhanViens.FirstOrDefault(x=>x.Manhanvien==id);
        }
        public List<NhanVien> GetList()
        {
            return db.NhanViens.ToList();
        }
        public NhanVien Get(string name)
        {
            return db.NhanViens.FirstOrDefault(x=>x.Ten==name);
        }
        public List<NhanVien> GetListByName(string name)
        {
            return db.NhanViens.Where(x => x.Ten.Contains(name)).ToList();
        }
        public List<NhanVien> GetListByNamSinh(string name)
        {
            return db.NhanViens.Where(x => (x.Ngaysinh).ToString().Contains(name)).ToList();
        }
        public List<NhanVien> GetListByNgayTao(string name)
        {
            return db.NhanViens.Where(x => (x.Ngaytao).ToString().Contains(name)).ToList();
        }
        public bool Add(NhanVien e,string password="123456")
        {
            if (Get(e.Ten)==null)
            {
                var i = db.NhanViens.Add(e);
                db.SaveChanges();
                var o = new TaiKhoan();
                o.Loai = "nhanvien";
                o.UserID = "NV" + i.Manhanvien;
                o.Matkhau = password;
                db.TaiKhoans.Add(o);
                db.SaveChanges();
                return i.Manhanvien > 0;
            }
            else
                return false;
        }
        public bool Edit(NhanVien e, string password)
        {
            var o = Get(e.Manhanvien);
            var tk = GetTK(e.Manhanvien);
            if (o != null && tk!=null)
            {
                if (o.Ten != e.Ten)
                    o.Ten = e.Ten;
                if (o.Gioitinh == e.Gioitinh)
                    o.Gioitinh = e.Gioitinh;
                if (o.Ngaysinh == e.Ngaysinh)
                    o.Ngaysinh = e.Ngaysinh;
                if (o.Ngaytao == e.Ngaytao)
                    o.Ngaytao = e.Ngaytao;
                if (!string.IsNullOrEmpty(password))
                    if (tk.Matkhau != password)
                    {
                        tk.Matkhau = password;
                    }

                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public TaiKhoan GetTK(int id)
        {
            var uid = id.ToString();
            return db.TaiKhoans.FirstOrDefault(x => x.UserID.Substring(2) == uid && x.Loai == "nhanvien");
        }
        public void DeleteTK(int id)
        {
            if (GetTK(id) != null)
            {
                db.TaiKhoans.Remove(GetTK(id));
                db.SaveChanges();
            }
        }
        public bool Delete(int id)
        {
            var o = Get(id);
            if (o != null)
            {
                db.NhanViens.Remove(o);
                db.SaveChanges();
                DeleteTK(id);
                return true;
            }
            else
            return false;
        }
    }
}
