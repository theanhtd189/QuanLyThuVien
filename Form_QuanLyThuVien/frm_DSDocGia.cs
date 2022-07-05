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
    public partial class frm_DSDocGia : Form
    {
        f_docgia f = new f_docgia();
        int current_row = -1;
        public frm_DSDocGia()
        {
            InitializeComponent();
            LoadGrid(f.GetList());
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("ten", "Tên");
            test.Add("lop", "Lớp");
            test.Add("themboi", "Thêm bởi");
            test.Add("ns", "Năm sinh");
            cbTimkiem.DataSource = new BindingSource(test, null);
            cbTimkiem.DisplayMember = "Value";
            cbTimkiem.ValueMember = "Key";
        }
        private void LoadGrid(List<DocGia> list)
        {
            var nlist = new List<Docgia_Common>();
            foreach (var x in list)
            {
                NhanVien nv = new NhanVien();
                if(x.Manhanvien!=null)
                nv = new f_nhanvien().Get((int)x.Manhanvien);
                var o = new Docgia_Common
                {
                    Madocgia = x.Madocgia,
                    Ten = x.Ten,
                    Namsinh  = x.Namsinh,
                    Ngaytao = x.Ngaytao,
                    Gioitinh = (x.Gioitinh==true)?"Nam":"Nữ",
                    Manhanvien = (x.Manhanvien == null || x.Manhanvien == 0)?0:x.Manhanvien,
                    Tennhanvien = (x.Manhanvien==null || x.Manhanvien == 0) ?"ADMIN":nv.Ten,
                    Lop = x.Lop
                };
                nlist.Add(o);
            }
            var bd = new BindingList<Docgia_Common>(nlist);
            var source = new BindingSource(bd, null);
            dgDS.DataSource = source;
            btnTong.Text = nlist.Count +" độc giả";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadGrid(f.GetList());
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (current_row > -1)
            {
                this.Hide();
                using (frm_SuaDocGia frm = new frm_SuaDocGia(current_row))
                {                    
                    frm.ShowDialog();
                    if (frm.stt || frm.DialogResult == DialogResult.OK)
                    {
                        LoadGrid(new Context().DocGias.ToList());
                    }
                }
                this.Show();
            }
            else
                MessageBox.Show("Vui lòng chọn dòng muốn sửa");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frm_ThemDocGia frm = new frm_ThemDocGia())
            {               
                frm.ShowDialog();
                if (frm.stt)
                {
                    LoadGrid(new Context().DocGias.ToList());
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
                var list = new List<DocGia>();
                if (value == "ten")
                {
                    list = f.GetListByName(input);
                }
                else
                if (value == "lop")
                {
                    list = f.GetListByLop(input);
                }
                else
                    if (value == "ns")
                {
                    list = f.GetListByNamSinh(input);
                }
                else
                    if (value == "themboi")
                {
                    list = f.GetListByNguoiThem(input);
                }
                LoadGrid(list);
            }
            else
                MessageBox.Show("Vui lòng nhập vào ô tìm kiếm");
        }
    }
}
