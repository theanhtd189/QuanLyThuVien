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
    public partial class frm_SuaNhanVien : Form
    {
        f_nhanvien f = new f_nhanvien();
        NhanVien nv = new NhanVien();
        public frm_SuaNhanVien(int id)
        {
            InitializeComponent();
            this.nv = f.Get(id);
            txtTen.Text = nv.Ten;
            dpNgay.Value = (DateTime)nv.Ngaysinh;
            if ((bool)nv.Gioitinh)
                rbNam.Checked = true;
            else
                rbNu.Checked = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTen.Text))
            {

                NhanVien o = nv;
                o.Ten = txtTen.Text;
                o.Gioitinh = (rbNam.Checked) ? true : false;
                o.Ngaysinh = dpNgay.Value;
                var stt_ = f.Edit(o, txtMk.Text);
                if (stt_)
                {
                    MessageBox.Show("Sửa thành công");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
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
