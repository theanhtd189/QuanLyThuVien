using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Form_QuanLyThuVien.Model;

namespace Form_QuanLyThuVien.Function
{
    public class f_theloai
    {
        Context db = new Context();
        public TheLoai Get(int id)
        {
            return db.TheLoais.FirstOrDefault(x=>x.Matheloai==id);
        }
        public TheLoai Get(string name)
        {
            return db.TheLoais.FirstOrDefault(x=>x.Ten==name);
        }
        public List<TheLoai> GetList()
        {
            return db.TheLoais.ToList();
        }
        public bool Add(TheLoai e)
        {
            if (Get(e.Ten) == null)
            {
                var i = db.TheLoais.Add(e);
                db.SaveChanges();
                return i.Matheloai > 0;
            }
            else
            return false;
        }
        public bool Edit(TheLoai e)
        {
            var o = Get(e.Matheloai);
            if (o != null)
            {
                if (o.Ten != e.Ten)
                    o.Ten = e.Ten;
                db.SaveChanges();
                return true;
            }
            else
            return false;
        }
        public bool Delete(int id)
        {
            if (Get(id) != null)
            {
                db.TheLoais.Remove(Get(id));
                db.SaveChanges();
                return true;
            }
            else
            return false;
        }
    }
}
