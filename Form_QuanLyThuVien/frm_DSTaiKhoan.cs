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
    public partial class frm_DSTaiKhoan : Form
    {
        public frm_DSTaiKhoan()
        {
            InitializeComponent();
            LoadGrid(new f_taikhoan().GetList());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void LoadGrid(List<TaiKhoan> list)
        {
            var nlist = list;
            var bd = new BindingList<TaiKhoan>(nlist);
            var source = new BindingSource(bd, null);
            dgDS.DataSource = source;
            btnTong.Text = nlist.Count + " Tài khoản";
        }
    }
}
