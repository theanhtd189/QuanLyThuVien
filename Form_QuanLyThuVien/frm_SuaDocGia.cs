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
    public partial class frm_SuaDocGia : Form
    {
        DocGia dg = new DocGia();
        public bool stt = false;
        f_docgia f = new f_docgia();
        int nguoitao;
        public frm_SuaDocGia(int id = -1)
        {
            InitializeComponent();
            if (f.Get(id) != null)
            {
                this.dg = f.Get(id);
                nguoitao = id;
                txtTen.Text = dg.Ten;
                txtLop.Text = dg.Lop;
                if (dg.Namsinh != null)
                    dpNgay.Value = (DateTime)dg.Namsinh;
                if ((bool)dg.Gioitinh)
                    rbNam.Checked = true;
                else
                    rbNu.Checked = true;
            }
            else
            {
                MessageBox.Show("Đọc giả không tồn tại hoặc đã bị xóa");
                DialogResult = DialogResult.Cancel;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTen.Text))
            {
                if (!string.IsNullOrEmpty(txtLop.Text))
                {

                    var o = new DocGia
                    {
                        Madocgia = dg.Madocgia,
                        Manhanvien = dg.Manhanvien,
                        Namsinh = dpNgay.Value,
                        Lop = txtLop.Text,
                        Ngaytao=dg.Ngaytao,
                        Ten = txtTen.Text,
                        Gioitinh = (rbNam.Checked) ? true : false
                    };
                    var stt_ = f.Edit(o, txtMk.Text);
                    if (stt_)
                    {
                        this.stt = true;
                        MessageBox.Show("Sửa thành công");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
                else
                    MessageBox.Show("Vui lòng nhập lớp học");
            }
            else
                MessageBox.Show("Vui lòng nhập tên");
        }
    }
}
