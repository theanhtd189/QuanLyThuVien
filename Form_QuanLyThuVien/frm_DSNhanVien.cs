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
    public partial class frm_DSNhanVien : Form
    {
        f_nhanvien f = new f_nhanvien();
        int current_row = -1;
        public frm_DSNhanVien()
        {
            InitializeComponent();
            LoadCombobox();
            LoadGrid(f.GetList());
        }
        private void LoadCombobox()
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("ten", "Tên");
            test.Add("ns", "Năm sinh");
            test.Add("nt", "Ngày tham gia");
            cbTimkiem.DataSource = new BindingSource(test, null);
            cbTimkiem.DisplayMember = "Value";
            cbTimkiem.ValueMember = "Key";
        }
        private void LoadGrid(List<NhanVien> list)
        {
            var nlist = new List<Nhanvien_Common>();
            foreach (var x in list)
            {
                var o = new Nhanvien_Common
                {
                    Manhanvien = x.Manhanvien,
                    Ten = x.Ten,
                    Ngaysinh = x.Ngaysinh,
                    Ngaytao = x.Ngaytao,
                    Gioitinh = (x.Gioitinh == true) ? "Nam" : "Nữ"
                };
                nlist.Add(o);
            }
            var bd = new BindingList<Nhanvien_Common>(nlist);
            var source = new BindingSource(bd, null);
            dgDS.DataSource = source;
            btnTong.Text = nlist.Count+" nhân viên";
        }
        private void dgDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                current_row = int.Parse(dgDS.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            }
            else
            {
                current_row = -1;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (current_row > -1)
            {
                var confirmResult = MessageBox.Show("Bạn xác nhận muốn xóa bản ghi này??",
                                     "Xác nhận xóa!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var id = current_row;
                    var stt = f.Delete(id);
                    if (stt)
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadGrid(f.GetList());
                        current_row = -1;
                    }
                    else
                        MessageBox.Show("Lỗi");
                }
            }
            else
                MessageBox.Show("Vui lòng chọn dòng muốn xóa");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frm_ThemNhanVien frm = new frm_ThemNhanVien())
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK || frm.DialogResult == DialogResult.Cancel)
                {
                    LoadGrid(new Context().NhanViens.ToList());
                }
            }
            this.Show();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                string value = ((KeyValuePair<string, string>)cbTimkiem.SelectedItem).Key;
                var input = txtTimkiem.Text;
                var list = new List<NhanVien>();
                if (value == "ten")
                {
                    list = f.GetListByName(input);
                }
                else
                if (value == "ns")
                {
                    list = f.GetListByNamSinh(input);
                }
                else
                    if(value == "nt")
                {
                    list = f.GetListByNgayTao(input);
                }

                LoadGrid(list);
            }
            else
                MessageBox.Show("Vui lòng nhập vào ô tìm kiếm");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (current_row > -1)
            {
                this.Hide();
                using (frm_SuaNhanVien frm = new frm_SuaNhanVien(current_row))
                {
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK || frm.DialogResult == DialogResult.Cancel)
                    {
                        LoadGrid(new Context().NhanViens.ToList());
                    }
                }
                this.Show();
            }
            else
                MessageBox.Show("Vui lòng chọn dòng muốn sửa");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadGrid(f.GetList());
        }
    }
}
