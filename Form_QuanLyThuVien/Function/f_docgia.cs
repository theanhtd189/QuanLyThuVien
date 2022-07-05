using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Form_QuanLyThuVien.Model;

namespace Form_QuanLyThuVien.Function
{
    public class f_docgia
    {
        Context db = new Context();
        public DocGia Get(int id)
        {
            return db.DocGias.FirstOrDefault(x=>x.Madocgia == id);
        }
        public DocGia Get(string name)
        {
            return db.DocGias.FirstOrDefault(x=>x.Ten==name);
        }
        public List<DocGia> GetList()
        {
            return db.DocGias.ToList();
        }
        public List<DocGia> GetListByName(string name)
        {
            return db.DocGias.Where(x=>x.Ten.Contains(name)).ToList();
        }
        public List<DocGia> GetListByLop(string name)
        {
            return db.DocGias.Where(x => x.Lop.Contains(name)).ToList();
        }
        public List<DocGia> GetListByNamSinh(string name)
        {
            return db.DocGias.Where(x => (x.Namsinh).ToString().Contains(name)).ToList();
        }
        public List<DocGia> GetListByNguoiThem(string name)
        {
            try
            {
                if (name.ToLower() == "admin")
                    return db.DocGias.Where(x => x.Manhanvien == null || x.Manhanvien == 0).ToList();
                else
                {
                    var f = db.NhanViens.FirstOrDefault(x => x.Ten.ToLower() == name || x.Ten.ToUpper() == name);
                    if (f != null)
                    {

                        return db.DocGias.Where(x => x.Manhanvien == f.Manhanvien).ToList();
                    }
                    else
                        return new List<DocGia>();
                }    
            }
            catch
            {
                return new List<DocGia>();
            }
            
        }
        public bool Add(DocGia e,string password="123456")
        {
                var i = db.DocGias.Add(e);
                db.SaveChanges();
                var o = new TaiKhoan();
                o.Loai = "docgia";
                o.UserID = "DG" + i.Madocgia;
                o.Matkhau = password;
                db.TaiKhoans.Add(o);
                db.SaveChanges();
                return i.Madocgia > 0;
        }
        public TaiKhoan GetTK(int id)
        {
            var uid = id.ToString();
            return db.TaiKhoans.FirstOrDefault(x=>x.UserID.Substring(2)==uid && x.Loai=="docgia");
        }
        public void DeleteTK(int id)
        {
            if (GetTK(id) != null)
            {
                db.TaiKhoans.Remove(GetTK(id));
                db.SaveChanges();
            }             
        }
        public bool Edit(DocGia e,string password)
        {
            var o = Get(e.Madocgia);
            var tk = GetTK(e.Madocgia);
            if (o != null && tk!=null)
            {
                if (o.Ten != e.Ten)
                    o.Ten = e.Ten;
                if (o.Gioitinh != e.Gioitinh)
                    o.Gioitinh = e.Gioitinh;
                if (o.Lop != e.Lop)
                    o.Lop = e.Lop;
                if (o.Manhanvien != e.Manhanvien)
                    o.Manhanvien = e.Manhanvien;
                if (o.Namsinh != e.Namsinh)
                    o.Namsinh = e.Namsinh;
                if (o.Ngaytao != e.Ngaytao)
                    o.Ngaytao = e.Ngaytao;
                if(!string.IsNullOrEmpty(password))
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
        public bool Delete(int id)
        {
            if(Get(id)!=null)
            {
                db.DocGias.Remove(Get(id));
                db.SaveChanges();
                DeleteTK(id);
                return true;
            }   
            else
            return false;
        }
    }
}
