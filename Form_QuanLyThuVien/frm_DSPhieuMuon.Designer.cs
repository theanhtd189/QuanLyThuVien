
namespace Form_QuanLyThuVien
{
    partial class frm_DSPhieuMuon
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbTimkiem = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.dgDS = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nguoimuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaymuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách phiếu mượn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.btnTong);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.cbTimkiem);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Controls.Add(this.dgDS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(-1, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1317, 560);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTong.Location = new System.Drawing.Point(293, 30);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(262, 37);
            this.btnTong.TabIndex = 16;
            this.btnTong.Text = "Tổng số";
            this.btnTong.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReset.Location = new System.Drawing.Point(1028, 497);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 41);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbTimkiem
            // 
            this.cbTimkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimkiem.FormattingEnabled = true;
            this.cbTimkiem.Location = new System.Drawing.Point(868, 33);
            this.cbTimkiem.Name = "cbTimkiem";
            this.cbTimkiem.Size = new System.Drawing.Size(154, 24);
            this.cbTimkiem.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.Gray;
            this.btnThem.Location = new System.Drawing.Point(21, 497);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 41);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.Coral;
            this.btnSua.Location = new System.Drawing.Point(149, 497);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 41);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Xem chi tiết";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.LightGray;
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(277, 497);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 41);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBack.Location = new System.Drawing.Point(1178, 497);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 41);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.AutoSize = true;
            this.btnTimkiem.BackColor = System.Drawing.Color.FloralWhite;
            this.btnTimkiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTimkiem.Location = new System.Drawing.Point(1224, 31);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(76, 27);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimkiem.Location = new System.Drawing.Point(1028, 33);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(190, 22);
            this.txtTimkiem.TabIndex = 4;
            // 
            // dgDS
            // 
            this.dgDS.AllowUserToAddRows = false;
            this.dgDS.AllowUserToDeleteRows = false;
            this.dgDS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDS.BackgroundColor = System.Drawing.Color.White;
            this.dgDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DisplayID,
            this.Nhanvien,
            this.Nguoimuon,
            this.Ngaymuon,
            this.Ngaytra,
            this.Trangthai});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDS.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgDS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgDS.Location = new System.Drawing.Point(21, 96);
            this.dgDS.Name = "dgDS";
            this.dgDS.ReadOnly = true;
            this.dgDS.RowHeadersVisible = false;
            this.dgDS.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.dgDS.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDS.RowTemplate.Height = 24;
            this.dgDS.Size = new System.Drawing.Size(1279, 375);
            this.dgDS.TabIndex = 1;
            this.dgDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDS_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Maphieu";
            this.ID.HeaderText = "Mã";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // DisplayID
            // 
            this.DisplayID.DataPropertyName = "DisplayID";
            this.DisplayID.HeaderText = "Mã phiếu";
            this.DisplayID.MinimumWidth = 6;
            this.DisplayID.Name = "DisplayID";
            this.DisplayID.ReadOnly = true;
            // 
            // Nhanvien
            // 
            this.Nhanvien.DataPropertyName = "Nhanvien";
            this.Nhanvien.HeaderText = "Nhân viên";
            this.Nhanvien.MinimumWidth = 6;
            this.Nhanvien.Name = "Nhanvien";
            this.Nhanvien.ReadOnly = true;
            // 
            // Nguoimuon
            // 
            this.Nguoimuon.DataPropertyName = "Nguoimuon";
            this.Nguoimuon.HeaderText = "Người mượn";
            this.Nguoimuon.MinimumWidth = 6;
            this.Nguoimuon.Name = "Nguoimuon";
            this.Nguoimuon.ReadOnly = true;
            // 
            // Ngaymuon
            // 
            this.Ngaymuon.DataPropertyName = "Ngaymuon";
            this.Ngaymuon.HeaderText = "Ngày mượn";
            this.Ngaymuon.MinimumWidth = 6;
            this.Ngaymuon.Name = "Ngaymuon";
            this.Ngaymuon.ReadOnly = true;
            // 
            // Ngaytra
            // 
            this.Ngaytra.DataPropertyName = "Ngaytra";
            this.Ngaytra.HeaderText = "Ngày trả";
            this.Ngaytra.MinimumWidth = 6;
            this.Ngaytra.Name = "Ngaytra";
            this.Ngaytra.ReadOnly = true;
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "Trangthai";
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.MinimumWidth = 6;
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.ReadOnly = true;
            // 
            // frm_DSPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 545);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_DSPhieuMuon";
            this.Text = "Phiếu mượn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbTimkiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridView dgDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nguoimuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaymuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.Button btnTong;
    }
}