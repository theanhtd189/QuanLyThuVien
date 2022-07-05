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
    public partial class frm_DSPhieuMuon : Form
    {
        int current_row = -1;
        f_phieumuon f = new f_phieumuon();
        public frm_DSPhieuMuon()
        {
            InitializeComponent();
            LoadCombobox();
            LoadGrid(f.GetList());
        }
        private void LoadCombobox()
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("dg", "Người mượn");
            test.Add("nv", "Nhân viên tạo phiếu");
            test.Add("nm", "Ngày mượn");
            test.Add("nt", "Ngày trả");       
            cbTimkiem.DataSource = new BindingSource(test, null);
            cbTimkiem.DisplayMember = "Value";
            cbTimkiem.ValueMember = "Key";
        }
        private void LoadGrid(List<PhieuMuon> list)
        {
            var nlist = new List<Phieu_Common>();
            foreach (var x in list)
            {
                var dg = new f_docgia().Get(x.Madocgia);
                var nv = new f_nhanvien().Get((int)x.Manhanvien);

                var o = new Phieu_Common
                {
                    Maphieu=x.Maphieu,
                    DisplayID= "PH"+x.Maphieu,
                    Nguoimuon =(dg!=null)?dg.Ten:"Độc giả",
                    Nhanvien=(nv!=null)?nv.Ten:"Nhân viên",
                    Ngaymuon= (DateTime)x.Ngaytao,
                    Ngaytra= (DateTime)x.Ngaytra,
                    Trangthai=(x.Trangthai==true)?"Đã trả":"Chưa trả"
                };
                nlist.Add(o);
            }
            var bd = new BindingList<Phieu_Common>(nlist);
            var source = new BindingSource(bd, null);
            dgDS.DataSource = source;
            btnTong.Text = nlist.Count + " phiếu";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frm_ThemPhieu frm = new frm_ThemPhieu())
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK || frm.DialogResult == DialogResult.Cancel)
                {
                    Reload();
                }
            }
            this.Show();
        }
        public void Reload()
        {
            LoadGrid(new Context().PhieuMuons.ToList());
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (current_row > -1)
            {
                frm_SuaCTPM frm = new frm_SuaCTPM(current_row);
                frm.ShowDialog();
                if(frm.DialogResult==DialogResult.OK || frm.DialogResult == DialogResult.Cancel)
                {
                    Reload();
                }
            }
            else
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa");
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
                        current_row = -1;
                        MessageBox.Show("Thành công");
                        LoadGrid(f.GetList());
                    }
                    else
                        MessageBox.Show("Lỗi");

                }
            }
            else
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa");
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                string value = ((KeyValuePair<string, string>)cbTimkiem.SelectedItem).Key;
                var input = txtTimkiem.Text;
                var list = new List<PhieuMuon>();
                if (value == "dg")
                {
                    list = f.GetListByDocGia(input);
                }
                else
                if (value == "nv")
                {
                    list = f.GetListByNhanVien(input);
                }
                else
                    if (value == "nm")
                {
                    list = f.GetListByNgayMuon(input);
                }
                else
                    if (value == "nt")
                {
                    list = f.GetListByNgayTra(input);
                }
                LoadGrid(list);
            }
            else
                MessageBox.Show("Vui lòng nhập vào ô tìm kiếm");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadGrid(new Context().PhieuMuons.ToList());
        }
    }
}
