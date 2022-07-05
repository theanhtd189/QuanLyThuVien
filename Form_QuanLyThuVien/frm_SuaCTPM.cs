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
    public partial class frm_SuaCTPM : Form
    {
        int current_row = -1;
        PhieuMuon p = new PhieuMuon();
        f_phieumuon fp = new f_phieumuon();
        f_nhanvien fn = new f_nhanvien();
        f_docgia fd = new f_docgia();
        f_sach fs = new f_sach();
        f_theloai ft = new f_theloai();
        int runtime = 0;
        
        public frm_SuaCTPM(int id_phieu)
        {
            InitializeComponent();

            if (fp.Get(id_phieu) != null)
            {
                LoadCombobox();
                this.p = fp.Get(id_phieu);
                cbDocgia.SelectedValue = p.Madocgia;
                cbNhanvien.SelectedValue = p.Manhanvien;
                dpNgaymuon.Value = (DateTime)p.Ngaytao;
                dpNgaytra.Value = (DateTime)p.Ngaytra;
                var tt = (p.Trangthai == true) ? "Tình trạng: ĐÃ TRẢ" : "Tình trạng: CHƯA TRẢ";
                btnStt.Text = tt;
                if (fp.GetListDetail(id_phieu) != null)
                {
                    F5();
                }
                runtime++;
            }
        }
        public void F5()
        {
            lbTongtien.Text = fp.TinhTien(p.Maphieu).ToString() + " VND";
            LoadGrid(fp.GetListDetail(p.Maphieu));
        }
        private void LoadGrid(List<CTPM> list)
        {
            var bd = new BindingList<CTPM>(list);
            var source = new BindingSource(bd, null);
            dgDS.DataSource = source;
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

        private void btn_Enter(object sender, EventArgs e)
        {

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
                            TongTien= frm.soluong*s.Giatien
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
                            Soluong = ct.Soluong+frm.soluong,
                            TongTien = s.Giatien*s.Soluong
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
            LoadGrid(new Context().CTPMs.Where(x => x.Maphieu == p.Maphieu).ToList());
            F5();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            var tt = p.Trangthai==true?"CHƯA TRẢ":"ĐÃ TRẢ";
            var confirmResult = MessageBox.Show("Bạn xác nhận muốn đổi trạng thái sang "+tt+" không ??",
                                     "Xác nhận!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var stt = fp.ChangeStt(p.Maphieu,(bool)!p.Trangthai);
                if (stt)
                {
                    MessageBox.Show("Thành công");
                    var ttt = (p.Trangthai == true) ? "Tình trạng: ĐÃ TRẢ" : "Tình trạng: CHƯA TRẢ";
                    btnStt.Text = ttt;
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void ChangeNguoiMuon(object sender, EventArgs e)
        {
            if(runtime>0)
            {
                var o = p;
                o.Madocgia = int.Parse(cbDocgia.SelectedValue.ToString());
                var stt = fp.Edit(o);
                if (stt)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                    MessageBox.Show("Lỗi");
            }    
            
        }
        private void ChangeNhanVien(object sender, EventArgs e)
        {
            if (runtime > 0)
            {
                var o = p;
                o.Manhanvien = int.Parse(cbNhanvien.SelectedValue.ToString());
                var stt = fp.Edit(o);
                if (stt)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                    MessageBox.Show("Lỗi");
            }
            
        }
        private void ChangeNgayMuon(object sender, EventArgs e)
        {
            if (runtime > 0)
            {
                var o = p;
                o.Ngaytao = dpNgaymuon.Value;
                var stt = fp.Edit(o);
                if (stt)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                    MessageBox.Show("Lỗi");
            }
           
        }
        private void ChangeNgayTra(object sender, EventArgs e)
        {
            if (runtime > 0)
            {
                if (dpNgaytra.Value <= dpNgaymuon.Value)
                {
                    MessageBox.Show("Ngày trả không hợp lệ");
                }
                else
                {
                    var o = p;
                    o.Ngaytra = dpNgaytra.Value;
                    var stt = fp.Edit(o);
                    if (stt)
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                        MessageBox.Show("Lỗi");
                }
            }
              
        }
    }
}
