using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Form_QuanLyThuVien.Model;
using Form_QuanLyThuVien.Function;

namespace Form_QuanLyThuVien.Function
{
    public class f_phieumuon
    {
        Context db = new Context();
        public List<PhieuMuon> GetList()
        {
            return db.PhieuMuons.ToList();
        }
        public PhieuMuon Get(int id)
        {
            return db.PhieuMuons.FirstOrDefault(x=>x.Maphieu==id);
        }

        public List<CTPM> GetListDetail(int id)
        {
            return db.CTPMs.Where(x => x.Maphieu == id).ToList();
        }
        public List<CTPM> GetListDetail()
        {
            return db.CTPMs.ToList();
        }
        public CTPM GetDetail(int id_p, int id_sach)
        {
            return db.CTPMs.FirstOrDefault(x=>x.Maphieu==id_p && x.Masach==id_sach);
        }
        public bool ChangeStt(int id, bool stt)
        {
            var o = Get(id);
            if(o!=null)
            {
                o.Trangthai = stt;
                db.SaveChanges();
                return true;
            }
            return
                false;
        }
        public bool AddDetail(CTPM e)
        {
            if (GetDetail((int)e.Maphieu, (int)e.Masach) == null)
            {
                db.CTPMs.Add(e);
                db.SaveChanges();
                var bd = db.Saches.FirstOrDefault(x => x.Masach == e.Masach).Soluong;
                db.Saches.FirstOrDefault(x=>x.Masach==e.Masach).Soluong = (int)(bd - e.Soluong);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public List<PhieuMuon> GetListByNhanVien(int manv)
        {
            return db.PhieuMuons.Where(x=>x.Manhanvien==manv).ToList();
        }
        public List<PhieuMuon> GetListByNhanVien(string name)
        {
            var l = new List<PhieuMuon>();
                try
                {
                    var f = db.NhanViens.FirstOrDefault(x => x.Ten == name);
                    if (f != null)
                        return db.PhieuMuons.Where(x => x.Manhanvien == f.Manhanvien).ToList();
                    else
                        return l;
                }
                catch
                {
                    return l;
                }
        }
        public List<PhieuMuon> GetListByDocGia(string name)
        {
            var l = new List<PhieuMuon>();
            try
            {
                var f = db.DocGias.FirstOrDefault(x => x.Ten == name);
                if (f != null)
                    return db.PhieuMuons.Where(x => x.Madocgia == f.Madocgia).ToList();
                else
                    return l;
            }
            catch
            {
                return l;
            }
        }
        public List<PhieuMuon> GetListByNgayMuon(string name)
        {
            return db.PhieuMuons.Where(x => (x.Ngaytao).ToString().Contains(name)).ToList();
        }
        public List<PhieuMuon> GetListByNgayTra(string name)
        {
            return db.PhieuMuons.Where(x => (x.Ngaytra).ToString().Contains(name)).ToList();
        }
        public List<PhieuMuon> GetListByDocGia(int madg)
        {
            return db.PhieuMuons.Where(x=>x.Madocgia==madg).ToList();
        }
        public bool Add(PhieuMuon e)
        {
            try
            {
                db.PhieuMuons.Add(e);
                var i = db.SaveChanges();
                return i > 0;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Edit(PhieuMuon e)
        {
            var o = Get(e.Maphieu);
            if (o != null)
            {
                if (o.Manhanvien != e.Manhanvien)
                    o.Manhanvien = e.Manhanvien;
                if (o.Madocgia != e.Madocgia)
                    o.Madocgia = e.Madocgia;
                if (o.Ngaytao != e.Ngaytao)
                    o.Ngaytao = e.Ngaytao;
                if (o.Ngaytra != e.Ngaytra)
                    o.Ngaytra = e.Ngaytra;
                if (o.Trangthai != e.Trangthai)
                    o.Trangthai = e.Trangthai;
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool EditDetail(CTPM e)
        {
            var o = GetDetail((int)e.Maphieu, (int)e.Masach);
            if (o != null)
            {
                if (o.Tensach != e.Tensach)
                    o.Tensach = e.Tensach;
                if (o.Giatien != e.Giatien)
                    o.Giatien = e.Giatien;
                if (o.Theloai != e.Theloai)
                    o.Theloai = e.Theloai;
                if (o.Soluong != e.Soluong)
                    o.Soluong = e.Soluong;
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool Delete(int e)
        {
            var o = Get(e);
            if (o != null)
            {
                db.PhieuMuons.Remove(o);
                db.SaveChanges();
                DeleteListDetail(e);
                return true;
            }
            else
                return false;
        }
        public bool DeleteSingleDetail(int id,int id_sach)
        {
            try
            {
                var o = GetDetail(id,id_sach);
                if (o != null)
                {
                    var stt =  db.CTPMs.Remove(o);
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeleteListDetail(int id)
        {
            try
            {
                var list = GetListDetail(id);
                if (list != null)
                    if (list.Count > 0)
                        foreach (var item in list)
                        {
                            db.CTPMs.Remove(item);
                        }
                db.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }       
        }
        public double TinhTien(int id)
        {
            var o = GetListDetail(id);
            double t = 0;
            foreach(var item in o)
            {
                t = (double)(t + item.TongTien); 
            }
            return t;
            
        }
    }
}
