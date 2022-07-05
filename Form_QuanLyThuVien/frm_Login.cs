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
using Form_QuanLyThuVien.Model;

namespace Form_QuanLyThuVien
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTendn.Text))
            {
                if (!string.IsNullOrEmpty(txtMk.Text))
                {
                    f_taikhoan f = new f_taikhoan();
                    var stt = f.Login(txtTendn.Text,txtMk.Text);
                    if (!stt)
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                    }
                    else
                    {
                        frm_Menu frm = new frm_Menu(txtTendn.Text);
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }    
                }
                else
                    MessageBox.Show("Vui lòng nhập mật khẩu");
            }
            else
                MessageBox.Show("Vui lòng nhập tên đăng nhập");
        }
    }
}
