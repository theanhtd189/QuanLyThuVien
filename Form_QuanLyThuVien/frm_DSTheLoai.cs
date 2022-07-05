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
    public partial class frm_DSTheLoai : Form
    {
        int current_row = -1;
        f_theloai f = new f_theloai();
        public frm_DSTheLoai()
        {
            InitializeComponent();
            LoadGrid(f.GetList());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void LoadGrid(List<TheLoai> list)
        {
            var nlist = new List<TheLoai>();
            foreach (var x in list)
            {
                var o = new TheLoai
                {
                    Matheloai=x.Matheloai,
                    Ten=x.Ten
                };
                nlist.Add(o);
            }
            var bd = new BindingList<TheLoai>(nlist);
            var source = new BindingSource(bd, null);
            dgDS.DataSource = source;
        }
        private void dgDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                current_row = int.Parse(dgDS.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                if (f.Get(current_row) != null)
                    txtSua.Text = f.Get(current_row).Ten;
                else
                    MessageBox.Show("ID đã bị xóa hoặc không tồn tại");
            }
            else
            {
                current_row = -1;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtThem.Text))
            {
                var o = new TheLoai
                {
                    Ten= txtThem.Text
                };
                var stt = f.Add(o);
                if (stt)
                {
                    MessageBox.Show("Thêm thành công");
                    txtThem.Text = "";
                    LoadGrid(new Context().TheLoais.ToList());
                    current_row = -1;
                }
                else
                    MessageBox.Show("Thể loại này đã tồn tại, vui lòng nhập tên khác");

            }
            else
                MessageBox.Show("Vui lòng nhập tên vào");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (current_row > -1)
            {
                if (!string.IsNullOrEmpty(txtSua.Text))
                {
                    var o = new TheLoai
                    {
                        Ten = txtSua.Text,
                        Matheloai = current_row
                    };
                    var stt = f.Edit(o);
                    if (stt)
                    {
                        MessageBox.Show("Sửa thành công");
                        txtSua.Text = "";
                        LoadGrid(new Context().TheLoais.ToList());
                        current_row = -1;
                    }
                }
                else
                    MessageBox.Show("Vui lòng chọn dòng muốn sửa");
            }
            else
                MessageBox.Show("Vui lòng chọn dòng để sửa");
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
                    var stt = f.Delete(current_row);
                    if (stt)
                    {
                        MessageBox.Show("Xóa thành công");
                        current_row = -1;
                        LoadGrid(f.GetList());
                    }
                    else
                        MessageBox.Show("Lỗi");
                }
            }
            else
                MessageBox.Show("Vui lòng chọn dòng muốn xóa");
        }
    }
}
