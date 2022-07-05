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
    public partial class frm_ThemSach : Form
    {
        public bool stt = false;
        f_sach f = new f_sach();
        f_theloai ft = new f_theloai();
        public frm_ThemSach()
        {
            InitializeComponent();
            LoadCombobox();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTen.Text))
            {
                if (!string.IsNullOrEmpty(txtTacgia.Text))
                {
                    if (!string.IsNullOrEmpty(txtNxb.Text))
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(txtGiatien.Text))
                            {
                                if (!string.IsNullOrEmpty(txtSoluong.Text))
                                {
                                    var o = new Sach
                                    {
                                        Masach = 0,
                                        Matheloai = int.Parse(cbTheloai.SelectedValue.ToString()),
                                        Ten = txtTen.Text,
                                        Tacgia = txtTacgia.Text,
                                        NXB = txtNxb.Text,
                                        Namxuatban = txtNamxb.Text,
                                        Giatien = float.Parse(txtGiatien.Text),
                                        Soluong = int.Parse(txtSoluong.Text)
                                    };
                                    var stt_ = f.Add(o);
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
                                    MessageBox.Show("Vui lòng nhập số lượng sách");
                            }
                            else
                                MessageBox.Show("Vui lòng nhập giá tiền");
                        }
                        catch
                        {
                            MessageBox.Show("Vui lòng nhập số hợp lệ");
                        }
                    }
                    else
                        MessageBox.Show("Vui lòng nhập tên nhà xuất bản");
                }
                else
                    MessageBox.Show("Vui lòng nhập tên tác giả");
            }
            else
                MessageBox.Show("Vui lòng nhập tên");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void LoadCombobox()
        {
            var list = ft.GetList();
            cbTheloai.ValueMember = "Matheloai";
            cbTheloai.DisplayMember = "Ten";
            cbTheloai.DataSource = list;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
