using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Form_QuanLyThuVien.Model;

namespace Form_QuanLyThuVien.Function
{
    public class f_sach
    {
        Context db = new Context();
        public Sach Get(int id)
        {
            return db.Saches.FirstOrDefault(x=>x.Masach==id);
        }
        public Sach Get(string name)
        {
            return db.Saches.FirstOrDefault(x => x.Ten == name);
        }
        public List<Sach> GetList(string stt="all")
        {
            if(stt=="on")
            {
                return db.Saches.Where(x=>x.Soluong>0).ToList();
            }   
            else
                if(stt=="out")
            {
                return db.Saches.Where(x => x.Soluong <= 0).ToList();
            }    
            else
            {
                return db.Saches.ToList();
            }    
        }
        public List<Sach> GetListByName(string name)
        {
            return db.Saches.Where(x => x.Ten.Contains(name)).ToList();
        }
        public List<Sach> GetByTacGia(string name)
        {
            return db.Saches.Where(x => x.Tacgia.Contains(name)).ToList();
        }
        public List<Sach> GetByNXB(string name)
        {
            return db.Saches.Where(x => x.NXB.Contains(name)).ToList();
        }
        public List<Sach> GetByTheLoai(int id)
        {
            return db.Saches.Where(x => x.Matheloai==id).ToList();
        }
        public List<Sach> GetByNamxb(string n)
        {
            return db.Saches.Where(x => x.Namxuatban == n).ToList();
        }
        public List<Sach> GetByTheLoai(string name)
        {
            try
            {
                var f = db.TheLoais.FirstOrDefault(x => x.Ten == name);
                if(f!=null)
                return db.Saches.Where(x => x.Matheloai == f.Matheloai).ToList();
                else
                    return new List<Sach>();
            }
            catch
            {
                return new List<Sach>();
            }
            
        }
        public bool Add(Sach e)
        {
            {
                var i = db.Saches.Add(e);
                db.SaveChanges();
                return i.Masach > 0;
            }

        }
        public bool Edit(Sach e)
        {
            var o = Get(e.Masach);
            if (o != null)
            {
                if (o.Ten != e.Ten)
                    o.Ten = e.Ten;
                if (o.Tacgia != e.Tacgia)
                    o.Tacgia = e.Tacgia;
                if (o.NXB != e.NXB)
                    o.NXB = e.NXB;
                if (o.Namxuatban != e.Namxuatban)
                    o.Namxuatban = e.Namxuatban;
                if (o.Matheloai != e.Matheloai)
                    o.Matheloai = e.Matheloai;
                if (o.Giatien != e.Giatien)
                    o.Giatien = e.Giatien;
                if (o.Soluong != e.Soluong)
                    o.Soluong = e.Soluong;
                
                db.SaveChanges();
                return true;
            }
            else
            return false;
        }
        public bool Delete(int id)
        {
            var o = Get(id);
            if (o != null)
            {
                db.Saches.Remove(o);
                db.SaveChanges();
                return true;
            }
            else
            return false;
        }

    }
}
