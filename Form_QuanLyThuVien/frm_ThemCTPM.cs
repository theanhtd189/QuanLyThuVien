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
    public partial class frm_ThemCTPM : Form
    {
        int current_row = -1;
        f_phieumuon fp = new f_phieumuon();
        f_theloai ft = new f_theloai();
        f_sach fs = new f_sach();
        PhieuMuon p = new PhieuMuon();
        public frm_ThemCTPM(int id_phieu)
        {
            InitializeComponent();
            if (fp.Get(id_phieu) != null)
            {
                this.p = fp.Get(id_phieu);
                if (fp.GetListDetail(id_phieu).Count > 0)
                {
                    lbTongTien.Text = fp.TinhTien(p.Maphieu).ToString() + " VND";
                    LoadGrid(fp.GetListDetail(id_phieu));
                }
            }
            else
            {
                MessageBox.Show("ID không tồn tại hoặc đã bị xóa");
                DialogResult = DialogResult.Cancel;
            }
        }
        private void dgDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                current_row = int.Parse(dgDS.Rows[e.RowIndex].Cells["Masach"].Value.ToString());
            }
            else
            {
                current_row = -1;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {

        }
        private void LoadGrid(List<CTPM> list)
        {
            var bd = new BindingList<CTPM>(list);
            var source = new BindingSource(bd, null);
            dgDS.DataSource = source;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frm_ThuVienSach frm = new frm_ThuVienSach(0, false, true))
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    var id_sach = frm.current_row;
                    var s = fs.Get(id_sach);
                    var tl = ft.Get((int)s.Matheloai);
                    var ct = fp.GetDetail(p.Maphieu, id_sach);
                    if (ct == null)
                    {
                        var o = new CTPM
                        {
                            Maphieu = p.Maphieu,
                            Masach = s.Masach,
                            Tensach = s.Ten,
                            Giatien = s.Giatien,
                            Theloai = tl != null ? tl.Ten : "Không có",
                            Soluong = frm.soluong,
                            TongTien = s.Giatien * frm.soluong
                        };
                        var stt = fp.AddDetail(o);
                        if (!stt)
                            MessageBox.Show("Lỗi");
                        else
                        {
                            MessageBox.Show("Thêm sách thành công");
                            Reload();
                        }
                    }
                    else
                    {
                        var o = new CTPM
                        {
                            Maphieu = p.Maphieu,
                            Masach = s.Masach,
                            Tensach = s.Ten,
                            Giatien = s.Giatien,
                            Theloai = tl != null ? tl.Ten : "Không có",
                            Soluong = ct.Soluong + frm.soluong
                        };
                        var stt = fp.EditDetail(o);
                        if (!stt)
                            MessageBox.Show("Lỗi");
                        else
                        {
                            MessageBox.Show("Thêm sách thành công");
                            Reload();
                        }
                    }
                }
            }
        }
        public void Reload()
        {
            lbTongTien.Text = fp.TinhTien(p.Maphieu).ToString() + " VND";
            LoadGrid(new Context().CTPMs.Where(x => x.Maphieu == p.Maphieu).ToList());
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
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
                    if (fp.GetDetail(p.Maphieu, id) != null)
                    {
                        var sl = fp.GetDetail(p.Maphieu, id).Soluong;
                        var stt = fp.DeleteSingleDetail(p.Maphieu, id);
                        if (stt)
                        {
                            MessageBox.Show("Xóa thành công");
                            var s = fs.Get(id);
                            var c = s.Soluong;
                            s.Soluong = (int)(c + sl);
                            fs.Edit(s);
                            current_row = -1;
                            Reload();
                        }
                        else
                            MessageBox.Show("Lỗi");
                    }
                    else
                        MessageBox.Show("ID đã bị xóa hoặc không tồn tại");
                }
            }
            else
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa");
        }
    }
}
