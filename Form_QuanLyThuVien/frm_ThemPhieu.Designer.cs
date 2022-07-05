
namespace Form_QuanLyThuVien
{
    partial class frm_ThemPhieu
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
            this.btn = new System.Windows.Forms.GroupBox();
            this.txtNgaymuon = new System.Windows.Forms.TextBox();
            this.dpNgaytra = new System.Windows.Forms.DateTimePicker();
            this.cbNhanvien = new System.Windows.Forms.ComboBox();
            this.cbDocgia = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.BackColor = System.Drawing.Color.DarkCyan;
            this.btn.Controls.Add(this.txtNgaymuon);
            this.btn.Controls.Add(this.dpNgaytra);
            this.btn.Controls.Add(this.cbNhanvien);
            this.btn.Controls.Add(this.cbDocgia);
            this.btn.Controls.Add(this.btnOk);
            this.btn.Controls.Add(this.btnBack);
            this.btn.Controls.Add(this.label6);
            this.btn.Controls.Add(this.label5);
            this.btn.Controls.Add(this.label3);
            this.btn.Controls.Add(this.label2);
            this.btn.Controls.Add(this.label1);
            this.btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn.Location = new System.Drawing.Point(1, -6);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(473, 487);
            this.btn.TabIndex = 4;
            this.btn.TabStop = false;
            // 
            // txtNgaymuon
            // 
            this.txtNgaymuon.Enabled = false;
            this.txtNgaymuon.Location = new System.Drawing.Point(152, 272);
            this.txtNgaymuon.Name = "txtNgaymuon";
            this.txtNgaymuon.Size = new System.Drawing.Size(288, 22);
            this.txtNgaymuon.TabIndex = 27;
            // 
            // dpNgaytra
            // 
            this.dpNgaytra.Location = new System.Drawing.Point(152, 369);
            this.dpNgaytra.Name = "dpNgaytra";
            this.dpNgaytra.Size = new System.Drawing.Size(288, 22);
            this.dpNgaytra.TabIndex = 26;
            // 
            // cbNhanvien
            // 
            this.cbNhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhanvien.FormattingEnabled = true;
            this.cbNhanvien.Location = new System.Drawing.Point(152, 177);
            this.cbNhanvien.Name = "cbNhanvien";
            this.cbNhanvien.Size = new System.Drawing.Size(288, 24);
            this.cbNhanvien.TabIndex = 25;
            // 
            // cbDocgia
            // 
            this.cbDocgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocgia.FormattingEnabled = true;
            this.cbDocgia.Location = new System.Drawing.Point(152, 84);
            this.cbDocgia.Name = "cbDocgia";
            this.cbDocgia.Size = new System.Drawing.Size(288, 24);
            this.cbDocgia.TabIndex = 24;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOk.Location = new System.Drawing.Point(343, 432);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 36);
            this.btnOk.TabIndex = 21;
            this.btnOk.Text = "Tạo phiếu";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.ForeColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(213, 432);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 36);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ngày mượn sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày trả sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhân viên tạo phiếu ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Người mượn";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(145, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo phiếu mượn sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_ThemPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 474);
            this.Controls.Add(this.btn);
            this.Name = "frm_ThemPhieu";
            this.Text = "Tạo phiếu";
            this.btn.ResumeLayout(false);
            this.btn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox btn;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNgaymuon;
        private System.Windows.Forms.DateTimePicker dpNgaytra;
        private System.Windows.Forms.ComboBox cbNhanvien;
        private System.Windows.Forms.ComboBox cbDocgia;
    }
}