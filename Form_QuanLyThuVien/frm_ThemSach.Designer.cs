
namespace Form_QuanLyThuVien
{
    partial class frm_ThemSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.GroupBox();
            this.cbTheloai = new System.Windows.Forms.ComboBox();
            this.txtNxb = new System.Windows.Forms.TextBox();
            this.txtTacgia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNamxb = new System.Windows.Forms.TextBox();
            this.txtGiatien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(310, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBack.Controls.Add(this.txtSoluong);
            this.btnBack.Controls.Add(this.label8);
            this.btnBack.Controls.Add(this.txtGiatien);
            this.btnBack.Controls.Add(this.label7);
            this.btnBack.Controls.Add(this.txtNamxb);
            this.btnBack.Controls.Add(this.cbTheloai);
            this.btnBack.Controls.Add(this.txtNxb);
            this.btnBack.Controls.Add(this.txtTacgia);
            this.btnBack.Controls.Add(this.label3);
            this.btnBack.Controls.Add(this.label6);
            this.btnBack.Controls.Add(this.label5);
            this.btnBack.Controls.Add(this.label4);
            this.btnBack.Controls.Add(this.txtTen);
            this.btnBack.Controls.Add(this.label2);
            this.btnBack.Controls.Add(this.btnOk);
            this.btnBack.Controls.Add(this.button2);
            this.btnBack.Controls.Add(this.label1);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.Location = new System.Drawing.Point(-106, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(660, 642);
            this.btnBack.TabIndex = 4;
            this.btnBack.TabStop = false;
            // 
            // cbTheloai
            // 
            this.cbTheloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheloai.FormattingEnabled = true;
            this.cbTheloai.Location = new System.Drawing.Point(315, 355);
            this.cbTheloai.Name = "cbTheloai";
            this.cbTheloai.Size = new System.Drawing.Size(263, 24);
            this.cbTheloai.TabIndex = 23;
            // 
            // txtNxb
            // 
            this.txtNxb.Location = new System.Drawing.Point(315, 210);
            this.txtNxb.Name = "txtNxb";
            this.txtNxb.Size = new System.Drawing.Size(263, 22);
            this.txtNxb.TabIndex = 22;
            // 
            // txtTacgia
            // 
            this.txtTacgia.Location = new System.Drawing.Point(315, 148);
            this.txtTacgia.Name = "txtTacgia";
            this.txtTacgia.Size = new System.Drawing.Size(263, 22);
            this.txtTacgia.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tác giả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nhà xuất bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Thể loại";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Năm xuất bản";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(315, 91);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(263, 22);
            this.txtTen.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOk.Location = new System.Drawing.Point(481, 559);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 36);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Xác Nhận";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(193, 559);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Trở Về";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtNamxb
            // 
            this.txtNamxb.Location = new System.Drawing.Point(315, 282);
            this.txtNamxb.Name = "txtNamxb";
            this.txtNamxb.Size = new System.Drawing.Size(263, 22);
            this.txtNamxb.TabIndex = 24;
            // 
            // txtGiatien
            // 
            this.txtGiatien.Location = new System.Drawing.Point(315, 424);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(263, 22);
            this.txtGiatien.TabIndex = 26;
            this.txtGiatien.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Giá tiền";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(315, 490);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(263, 22);
            this.txtSoluong.TabIndex = 28;
            this.txtSoluong.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Số lượng";
            // 
            // frm_ThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 641);
            this.Controls.Add(this.btnBack);
            this.Name = "frm_ThemSach";
            this.Text = "Sách";
            this.btnBack.ResumeLayout(false);
            this.btnBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox btnBack;
        private System.Windows.Forms.ComboBox cbTheloai;
        private System.Windows.Forms.TextBox txtNxb;
        private System.Windows.Forms.TextBox txtTacgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNamxb;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiatien;
        private System.Windows.Forms.Label label7;
    }
}