using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Form_QuanLyThuVien.Model;

namespace Form_QuanLyThuVien.Function
{
    public class f_taikhoan
    {
        Context db = new Context();
        public bool Login(string u, string p)
        {
            if (!string.IsNullOrEmpty(u) && !string.IsNullOrEmpty(p))
            {
                var o = db.TaiKhoans.FirstOrDefault(x=>x.UserID.ToLower()==u.ToLower() && x.Matkhau == p);
                return o != null;
            }
            else
                return false;
        }
        public List<TaiKhoan> GetList()
        {
            return db.TaiKhoans.ToList();
        }
        public int GetID(string id)
        {
            var r = -1;
            var uid = int.Parse(id.Substring(2));
            if (id.Substring(0, 2).ToLower() == "dg")
            {
                var o = db.DocGias.FirstOrDefault(x=>x.Madocgia==uid);
                if (o != null)
                    r = o.Madocgia;

            }
            else
            if (id.Substring(0, 2).ToLower() == "nv")
            {
                var o = db.NhanViens.FirstOrDefault(x => x.Manhanvien == uid);
                if (o != null)
                    r = o.Manhanvien;
            }
            else
            {
                var o = db.NguoiQuanLies.FirstOrDefault(x => x.Manguoiquanly == uid);
                if (o != null)
                    r = o.Manguoiquanly;
            }
            return r;
        }
        public string GetName(string id)
        {
            var r = "Name";
            var uid = int.Parse(id.Substring(2));
            if (id.Substring(0, 2).ToLower() == "dg")
            {
                var o = db.DocGias.FirstOrDefault(x => x.Madocgia == uid);
                if (o != null)
                    r = o.Ten;

            }
            else
            if (id.Substring(0, 2).ToLower() == "nv")
            {
                var o = db.NhanViens.FirstOrDefault(x => x.Manhanvien == uid);
                if (o != null)
                    r = o.Ten;
            }
            else
            {
                var o = db.NguoiQuanLies.FirstOrDefault(x => x.Manguoiquanly == uid);
                if (o != null)
                    r = o.Ten;
            }
            return r;
        }


    }
}
