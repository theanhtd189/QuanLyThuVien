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
    public partial class frm_ThemPhieu : Form
    {
        f_docgia fd = new f_docgia();
        f_nhanvien fn = new f_nhanvien();
        f_theloai ft = new f_theloai();
        int current_row = -1;

        public frm_ThemPhieu()
        {
            InitializeComponent();
            LoadCombobox();
            txtNgaymuon.Text = DateTime.Now.ToString();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void LoadCombobox()
        {
            var list = fn.GetList();
            cbNhanvien.ValueMember = "Manhanvien";
            cbNhanvien.DisplayMember = "Ten";
            cbNhanvien.DataSource = list;

            var list2 = fd.GetList();
            cbDocgia.ValueMember = "Madocgia";
            cbDocgia.DisplayMember = "Ten";
            cbDocgia.DataSource = list2;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((dpNgaytra.Value > DateTime.Now))
            {
                var o = new PhieuMuon
                {
                    Madocgia = int.Parse(cbDocgia.SelectedValue.ToString()),
                    Manhanvien = int.Parse(cbNhanvien.SelectedValue.ToString()),
                    Ngaytao = DateTime.Now,
                    Ngaytra = dpNgaytra.Value,
                    Trangthai = false
                };
                var stt = new f_phieumuon().Add(o);
                if (stt)
                {
                    MessageBox.Show("Thành công");
                    this.Hide();
                    frm_ThemCTPM frm = new frm_ThemCTPM(o.Maphieu);
                    frm.ShowDialog();               
                    this.DialogResult = DialogResult.OK;

                }
                else
                    MessageBox.Show("Lỗi");
            }
            else
                MessageBox.Show("Ngày trả không hợp lệ");     
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (current_row > -1)
            {

            }
            else
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa");
        }
    }
}
