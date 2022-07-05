using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_QuanLyThuVien.Function;

namespace Form_QuanLyThuVien
{
    public partial class frm_Menu : Form
    {
        public frm_Menu(string username)
        {
            InitializeComponent();
            lbName.Text = new f_taikhoan().GetName(username);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            frm_ThuVienSach f = new frm_ThuVienSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDg_Click(object sender, EventArgs e)
        {
            frm_DSDocGia f = new frm_DSDocGia();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnNv_Click(object sender, EventArgs e)
        {
            frm_DSNhanVien f = new frm_DSNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_DSTheLoai f = new frm_DSTheLoai();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_DSPhieuMuon f = new frm_DSPhieuMuon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_BaoCao frm = new frm_BaoCao();
            frm.ShowDialog();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnQuanlytk_Click(object sender, EventArgs e)
        {
            frm_DSTaiKhoan frm = new frm_DSTaiKhoan();
            frm.ShowDialog();
        }
    }
}
