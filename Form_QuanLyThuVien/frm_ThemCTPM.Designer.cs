
namespace Form_QuanLyThuVien
{
    partial class frm_ThemCTPM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgDS = new System.Windows.Forms.DataGridView();
            this.Masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.Gray;
            this.btnThem.Location = new System.Drawing.Point(61, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 36);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm sách";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.Chocolate;
            this.btnXoa.Location = new System.Drawing.Point(153, 38);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 36);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa sách";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.ForeColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(61, 392);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 36);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgDS
            // 
            this.dgDS.AllowUserToAddRows = false;
            this.dgDS.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.dgDS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgDS.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
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
            this.dgDS.Location = new System.Drawing.Point(61, 83);
            this.dgDS.Name = "dgDS";
            this.dgDS.ReadOnly = true;
            this.dgDS.RowHeadersVisible = false;
            this.dgDS.RowHeadersWidth = 51;
            this.dgDS.RowTemplate.Height = 24;
            this.dgDS.Size = new System.Drawing.Size(679, 284);
            this.dgDS.TabIndex = 36;
            this.dgDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDS_CellContentClick);
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
            this.Giatien.HeaderText = "Giá tiền";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tổng tiền:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(614, 38);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(46, 16);
            this.lbTongTien.TabIndex = 38;
            this.lbTongTien.Text = "0 VND";
            // 
            // frm_ThemCTPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDS);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Name = "frm_ThemCTPM";
            this.Text = "Chi tiết phiếu";
            ((System.ComponentModel.ISupportInitialize)(this.dgDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giatien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTongTien;
    }
}