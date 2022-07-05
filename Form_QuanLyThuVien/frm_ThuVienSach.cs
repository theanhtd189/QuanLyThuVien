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
    public partial class frm_ThuVienSach : Form
    {
        f_sach f = new f_sach();
        f_theloai ft = new f_theloai();
        public int runtime = 0, current_row = -1, soluong = 0;
        bool select = false;
        public frm_ThuVienSach(int id = -1, bool edit = true, bool select = false)
        {
            InitializeComponent();
            var list = f.GetList();
            LoadCombobox();

            runtime++;
            this.select = select;
            if (!edit)
            {
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
            if (select)
            {
                btnThem.Text = "XÁC NHẬN";
                btnThem.Enabled = false;
                LoadGrid(f.GetList("on"));
            }
            else
            {
                LoadGrid(list);
            }

        }
        private void LoadGrid(List<Sach> list)
        {
            var nlist = new List<Sach_Common>();
            foreach (var x in list)
            {
                var tl = "Không có";
                if (ft.Get((int)x.Matheloai) != null)
                {
                    tl = ft.Get((int)x.Matheloai).Ten;
                }
                var o = new Sach_Common
                {
                    Masach = x.Masach,
                    Ten = x.Ten,
                    Tacgia = x.Tacgia,
                    NXB = x.NXB,
                    Namxuatban = x.Namxuatban,
                    Matheloai = (int)x.Matheloai,
                    TenTheLoai = tl,
                    Giatien = x.Giatien,
                    Soluong = x.Soluong,
                    Mota= x.Mota
                };
                nlist.Add(o);
            }
            var bd = new BindingList<Sach_Common>(nlist);
            var source = new BindingSource(bd, null);
            dgDS.DataSource = source;
            btnTong.Text = nlist.Count + " đầu sách";
        }
        private void LoadCombobox()
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("ten", "Tên");
            test.Add("nxb", "Nhà xuất bản");
            test.Add("tg", "Tác giả");
            test.Add("tl", "Thể loại");
            test.Add("namxb", "Năm xuất bản");
            cbTimkiem.DataSource = new BindingSource(test, null);
            cbTimkiem.DisplayMember = "Value";
            cbTimkiem.ValueMember = "Key";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                string value = ((KeyValuePair<string, string>)cbTimkiem.SelectedItem).Key;
                var input = txtTimkiem.Text;
                var list = new List<Sach>();
                if (value == "ten")
                {
                    list = f.GetListByName(input);
                }
                else
                if (value == "nxb")
                {
                    list = f.GetByNXB(input);
                }
                else
                    if (value == "tg")
                {
                    list = f.GetByTacGia(input);
                }
                else
                    if (value == "tl")
                {
                    list = f.GetByTheLoai(input);
                }
                else
                if (value == "namxb")
                {
                    list = f.GetByNamxb(input);
                }
                LoadGrid(list);
            }
            else
                MessageBox.Show("Vui lòng nhập vào ô tìm kiếm");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (current_row > -1)
            {
                var id = current_row;
                var stt = f.Delete(id);
                if (stt)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadGrid(f.GetList());
                }
                else
                    MessageBox.Show("Lỗi");
            }
            else
                MessageBox.Show("Vui lòng chọn dòng muốn xóa");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (current_row > -1)
            {
                this.Hide();
                using (frm_SuaSach frm = new frm_SuaSach(current_row))
                {
                    frm.ShowDialog();
                    if (frm.stt)
                    {
                        LoadGrid(new Context().Saches.ToList());
                    }
                }
                this.Show();
            }
            else
                MessageBox.Show("Vui lòng chọn dòng muốn sửa");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (select)
            {
                if (soluong > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Vui lòng chọn số lượng");
            }
            else
            {
                this.Hide();
                using (frm_ThemSach frm = new frm_ThemSach())
                {
                    frm.ShowDialog();
                    if (frm.stt)
                    {
                        LoadGrid(new Context().Saches.ToList());
                    }
                }
                this.Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadGrid(f.GetList());
        }

        private void dgDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                current_row = int.Parse(dgDS.Rows[e.RowIndex].Cells["Masach"].Value.ToString());
                if (select)
                {
                    string input = "";
                    var sl = f.Get(current_row).Soluong;
                    while (true)
                    {
                        try
                        {
                            input = Microsoft.VisualBasic.Interaction.InputBox("Số lượng ",
                           "",
                           "1",
                           0,
                           0);
                            if (int.Parse(input) > 0 && int.Parse(input) <= sl)
                            {
                                this.soluong = int.Parse(input);
                                MessageBox.Show("Chọn số lượng thành công, mời bạn xác nhận chọn sách");
                                break;
                            }
                            else
                                MessageBox.Show("Số lượng phải lớn hơn 0 và nhỏ hơn hoặc bằng số sách trong thư viện");
                        }
                        catch
                        {
                            MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập lại");
                        }
                    }
                }
                btnThem.Enabled = true;
            }
            else
            {
                current_row = -1;
                if (select)
                    btnThem.Enabled = false;
            }
        }
    }
}
