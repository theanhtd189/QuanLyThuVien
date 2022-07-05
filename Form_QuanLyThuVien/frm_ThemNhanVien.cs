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
    public partial class frm_ThemNhanVien : Form
    {
        f_nhanvien f = new f_nhanvien();
        public frm_ThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTen.Text))
            {
                if (!string.IsNullOrEmpty(txtMk.Text))
                {
                    var o = new NhanVien
                    {
                        Ten=txtTen.Text,
                        Ngaysinh=dpNgay.Value,
                        Ngaytao=DateTime.Now,
                        Gioitinh=(rbNam.Checked==true)?true:false
                    };
                    var stt_ = f.Add(o, txtMk.Text);
                    if (stt_)
                    {                    
                        MessageBox.Show("Thêm thành công");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
                else
                    MessageBox.Show("Vui lòng nhập mật khẩu");
            }
            else
                MessageBox.Show("Vui lòng nhập tên");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
