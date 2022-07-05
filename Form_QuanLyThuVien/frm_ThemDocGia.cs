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
    
    public partial class frm_ThemDocGia : Form
    {
        public bool stt = false;
        int nguoitao;
        f_docgia f = new f_docgia();
        public frm_ThemDocGia(int creator=0)
        {
            InitializeComponent();
            this.nguoitao = creator;
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
                    if (!string.IsNullOrEmpty(txtMk.Text))
                    {
                        var o = new DocGia
                        {
                            Madocgia=0,
                            Manhanvien=this.nguoitao,
                            Lop=txtLop.Text,
                            Ten=txtTen.Text,
                            Gioitinh=(rbNam.Checked)?true:false,
                            Namsinh=dpNgay.Value,
                            Ngaytao=DateTime.Now
                        };
                        var stt_ = f.Add(o,txtMk.Text);
                        if (stt_)
                        {
                            this.stt = true;
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
                    MessageBox.Show("Vui lòng nhập lớp học");
            }
            else
                MessageBox.Show("Vui lòng nhập tên");
        }
    }
}
