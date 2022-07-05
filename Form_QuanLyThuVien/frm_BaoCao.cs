using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_QuanLyThuVien.Model;
using Form_QuanLyThuVien.Function;

namespace Form_QuanLyThuVien
{
    public partial class frm_BaoCao : Form
    {
        f_sach fs = new f_sach();
        f_theloai ft = new f_theloai();
        f_phieumuon fp = new f_phieumuon();
        f_docgia fd = new f_docgia();
        public frm_BaoCao()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            var sachtv = 0;
            foreach(var item in fs.GetList())
            {
                sachtv = sachtv + item.Soluong;
            }
            lbSosachcon.Text = sachtv.ToString();
            var sachmuon = 0;
            foreach(var item in fp.GetListDetail())
            {
                sachmuon = (int)(sachmuon + item.Soluong);
            }
            lbSosachmuon.Text = sachmuon.ToString();
            lbSosach.Text = (sachmuon + sachtv).ToString();
            lbSotheloaisach.Text = ft.GetList().Count.ToString();
            var dgmuonsach = new Context().PhieuMuons.Select(x => x.Madocgia).Distinct().ToList().Count;
            lbSodgmuon.Text = dgmuonsach.ToString();
            var dgchuatra = new Context().PhieuMuons.Where(x=>x.Trangthai==false).Select(x => x.Madocgia).Distinct().ToList().Count;
            lbSodgchuatra.Text = dgchuatra.ToString();
            lbTongsophieu.Text = fp.GetList().Count.ToString();
            lbSophieutra.Text = fp.GetList().Where(x=>x.Trangthai==true).ToList().Count.ToString();
            lbSophieuchuatra.Text = fp.GetList().Where(x => x.Trangthai == false).ToList().Count.ToString();
        }
    }
}
