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
    public partial class frm_SuaSach : Form
    {
        public bool stt = false;
        f_sach f = new f_sach();
        f_theloai ft = new f_theloai();
        Sach s = new Sach();
        public frm_SuaSach(int id=-1)
        {
            InitializeComponent();
            if (f.Get(id) != null)
            {
                LoadCombobox();
                this.s = f.Get(id);
                txtTen.Text = s.Ten;
                txtTacgia.Text = s.Tacgia;
                txtNxb.Text = s.NXB;
                txtNamxb.Text = s.Namxuatban;
                txtGiatien.Text = s.Giatien.ToString();
                txtSoluong.Text = s.Soluong.ToString();
                if (s.Matheloai != 0)
                {
                    cbTheloai.SelectedValue = s.Matheloai;
                }
            }
            else
            {
                MessageBox.Show("Sách không tồn tại hoặc đã bị xóa");
                DialogResult = DialogResult.Cancel;
            }    
        }
        private void LoadCombobox()
        {
            var list = ft.GetList();
            cbTheloai.ValueMember = "Matheloai";
            cbTheloai.DisplayMember = "Ten";
            cbTheloai.DataSource = list;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
                                        Masach = s.Masach,
                                        Matheloai = cbTheloai.SelectedValue!=null?int.Parse(cbTheloai.SelectedValue.ToString()):0,
                                        Ten = txtTen.Text,
                                        Tacgia = txtTacgia.Text,
                                        NXB = txtNxb.Text,
                                        Namxuatban = txtNamxb.Text,
                                        Soluong = int.Parse(txtSoluong.Text),
                                        Giatien = float.Parse(txtGiatien.Text)
                                    };

                                    var stt_ = f.Edit(o);
                                    if (stt_)
                                    {
                                        this.stt = true;
                                        MessageBox.Show("Cập nhật thành công");
                                        DialogResult = DialogResult.OK;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Lỗi");
                                    }
                                }
                                else
                                    MessageBox.Show("Vui lòng nhập số lượng");
                            }
                            else
                                MessageBox.Show("Vui lòng nhập giá tiền");
                        }
                        catch
                        {
                            MessageBox.Show("Vui lòng nhập giá trị hợp lệ");
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
    }
}
