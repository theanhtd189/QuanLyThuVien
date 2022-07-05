
namespace Form_QuanLyThuVien
{
    partial class frm_SuaCTPM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn = new System.Windows.Forms.GroupBox();
            this.btnStt = new System.Windows.Forms.Button();
            this.dpNgaymuon = new System.Windows.Forms.DateTimePicker();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgDS = new System.Windows.Forms.DataGridView();
            this.dpNgaytra = new System.Windows.Forms.DateTimePicker();
            this.cbNhanvien = new System.Windows.Forms.ComboBox();
            this.cbDocgia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.Masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.BackColor = System.Drawing.Color.DarkCyan;
            this.btn.Controls.Add(this.lbTongtien);
            this.btn.Controls.Add(this.label4);
            this.btn.Controls.Add(this.btnStt);
            this.btn.Controls.Add(this.dpNgaymuon);
            this.btn.Controls.Add(this.btnXacnhan);
            this.btn.Controls.Add(this.btnBack);
            this.btn.Controls.Add(this.btnThem);
            this.btn.Controls.Add(this.btnXoa);
            this.btn.Controls.Add(this.dgDS);
            this.btn.Controls.Add(this.dpNgaytra);
            this.btn.Controls.Add(this.cbNhanvien);
            this.btn.Controls.Add(this.cbDocgia);
            this.btn.Controls.Add(this.label6);
            this.btn.Controls.Add(this.label5);
            this.btn.Controls.Add(this.label3);
            this.btn.Controls.Add(this.label2);
            this.btn.Controls.Add(this.label1);
            this.btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(1237, 491);
            this.btn.TabIndex = 5;
            this.btn.TabStop = false;
            this.btn.Enter += new System.EventHandler(this.btn_Enter);
            // 
            // btnStt
            // 
            this.btnStt.BackColor = System.Drawing.Color.Tomato;
            this.btnStt.Location = new System.Drawing.Point(781, 426);
            this.btnStt.Name = "btnStt";
            this.btnStt.Size = new System.Drawing.Size(423, 36);
            this.btnStt.TabIndex = 42;
            this.btnStt.Text = "Tình trạng: CHƯA TRẢ";
            this.btnStt.UseVisualStyleBackColor = false;
            // 
            // dpNgaymuon
            // 
            this.dpNgaymuon.Location = new System.Drawing.Point(152, 272);
            this.dpNgaymuon.Name = "dpNgaymuon";
            this.dpNgaymuon.Size = new System.Drawing.Size(288, 22);
            this.dpNgaymuon.TabIndex = 41;
            this.dpNgaymuon.ValueChanged += new System.EventHandler(this.ChangeNgayMuon);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXacnhan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXacnhan.Location = new System.Drawing.Point(525, 426);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(187, 36);
            this.btnXacnhan.TabIndex = 40;
            this.btnXacnhan.Text = "Đổi trạng thái";
            this.btnXacnhan.UseVisualStyleBackColor = false;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.ForeColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(343, 426);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 36);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.Gray;
            this.btnThem.Location = new System.Drawing.Point(525, 72);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 36);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Thêm sách";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.Chocolate;
            this.btnXoa.Location = new System.Drawing.Point(617, 72);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 36);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa sách";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgDS
            // 
            this.dgDS.AllowUserToAddRows = false;
            this.dgDS.AllowUserToDeleteRows = false;
            this.dgDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masach,
            this.Maphieu,
            this.ID,
            this.Tensach,
            this.Theloai,
            this.Soluong,
            this.Giatien,
            this.TongTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDS.Location = new System.Drawing.Point(525, 107);
            this.dgDS.Name = "dgDS";
            this.dgDS.ReadOnly = true;
            this.dgDS.RowHeadersVisible = false;
            this.dgDS.RowHeadersWidth = 51;
            this.dgDS.RowTemplate.Height = 24;
            this.dgDS.Size = new System.Drawing.Size(679, 284);
            this.dgDS.TabIndex = 35;
            this.dgDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDS_CellContentClick);
            // 
            // dpNgaytra
            // 
            this.dpNgaytra.Location = new System.Drawing.Point(152, 369);
            this.dpNgaytra.Name = "dpNgaytra";
            this.dpNgaytra.Size = new System.Drawing.Size(288, 22);
            this.dpNgaytra.TabIndex = 26;
            this.dpNgaytra.ValueChanged += new System.EventHandler(this.ChangeNgayTra);
            // 
            // cbNhanvien
            // 
            this.cbNhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhanvien.FormattingEnabled = true;
            this.cbNhanvien.Location = new System.Drawing.Point(152, 177);
            this.cbNhanvien.Name = "cbNhanvien";
            this.cbNhanvien.Size = new System.Drawing.Size(288, 24);
            this.cbNhanvien.TabIndex = 25;
            this.cbNhanvien.SelectedIndexChanged += new System.EventHandler(this.ChangeNhanVien);
            // 
            // cbDocgia
            // 
            this.cbDocgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocgia.FormattingEnabled = true;
            this.cbDocgia.Location = new System.Drawing.Point(152, 84);
            this.cbDocgia.Name = "cbDocgia";
            this.cbDocgia.Size = new System.Drawing.Size(288, 24);
            this.cbDocgia.TabIndex = 24;
            this.cbDocgia.SelectedIndexChanged += new System.EventHandler(this.ChangeNguoiMuon);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ngày mượn sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày trả sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhân viên tạo phiếu ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Người mượn";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết phiếu mượn sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Tổng tiền: ";
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.Location = new System.Drawing.Point(597, 25);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(46, 16);
            this.lbTongtien.TabIndex = 44;
            this.lbTongtien.Text = "0 VND";
            // 
            // Masach
            // 
            this.Masach.DataPropertyName = "Masach";
            this.Masach.HeaderText = "Mã sách";
            this.Masach.MinimumWidth = 6;
            this.Masach.Name = "Masach";
            this.Masach.ReadOnly = true;
            this.Masach.Visible = false;
            // 
            // Maphieu
            // 
            this.Maphieu.DataPropertyName = "Maphieu";
            this.Maphieu.HeaderText = "Mã phiếu";
            this.Maphieu.MinimumWidth = 6;
            this.Maphieu.Name = "Maphieu";
            this.Maphieu.ReadOnly = true;
            this.Maphieu.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Tensach
            // 
            this.Tensach.DataPropertyName = "Tensach";
            this.Tensach.HeaderText = "Tên sách";
            this.Tensach.MinimumWidth = 6;
            this.Tensach.Name = "Tensach";
            this.Tensach.ReadOnly = true;
            // 
            // Theloai
            // 
            this.Theloai.DataPropertyName = "Theloai";
            this.Theloai.HeaderText = "Thể loại";
            this.Theloai.MinimumWidth = 6;
            this.Theloai.Name = "Theloai";
            this.Theloai.ReadOnly = true;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            // 
            // Giatien
            // 
            this.Giatien.DataPropertyName = "Giatien";
            this.Giatien.HeaderText = "Đơn giá";
            this.Giatien.MinimumWidth = 6;
            this.Giatien.Name = "Giatien";
            this.Giatien.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // frm_SuaCTPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 494);
            this.Controls.Add(this.btn);
            this.Name = "frm_SuaCTPM";
            this.Text = "Sửa phiếu";
            this.btn.ResumeLayout(false);
            this.btn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox btn;
        private System.Windows.Forms.DateTimePicker dpNgaytra;
        private System.Windows.Forms.ComboBox cbNhanvien;
        private System.Windows.Forms.ComboBox cbDocgia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgDS;
        private System.Windows.Forms.DateTimePicker dpNgaymuon;
        private System.Windows.Forms.Button btnStt;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giatien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}