
namespace Form_QuanLyThuVien
{
    partial class frm_Menu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDg = new System.Windows.Forms.Button();
            this.btnNv = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuanlytk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(-2, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 754);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbName.Location = new System.Drawing.Point(215, 82);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 24);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "XIN CHÀO:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Brown;
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(358, 673);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 51);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Thoát";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.btnQuanlytk);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btnDg);
            this.groupBox2.Controls.Add(this.btnNv);
            this.groupBox2.Controls.Add(this.btnSach);
            this.groupBox2.Location = new System.Drawing.Point(102, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 512);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.ForeColor = System.Drawing.Color.BlueViolet;
            this.button1.Location = new System.Drawing.Point(68, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 86);
            this.button1.TabIndex = 9;
            this.button1.Text = "Quản lý phiếu mượn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.ForeColor = System.Drawing.Color.BlueViolet;
            this.button2.Location = new System.Drawing.Point(346, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 86);
            this.button2.TabIndex = 8;
            this.button2.Text = "Báo cáo, tổng hợp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.ForeColor = System.Drawing.Color.BlueViolet;
            this.button4.Location = new System.Drawing.Point(346, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 86);
            this.button4.TabIndex = 7;
            this.button4.Text = "Quản lý thể loại sách";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDg
            // 
            this.btnDg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDg.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnDg.Location = new System.Drawing.Point(346, 49);
            this.btnDg.Name = "btnDg";
            this.btnDg.Size = new System.Drawing.Size(222, 86);
            this.btnDg.TabIndex = 6;
            this.btnDg.Text = "Quản lý độc giả";
            this.btnDg.UseVisualStyleBackColor = true;
            this.btnDg.Click += new System.EventHandler(this.btnDg_Click);
            // 
            // btnNv
            // 
            this.btnNv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNv.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnNv.Location = new System.Drawing.Point(68, 182);
            this.btnNv.Name = "btnNv";
            this.btnNv.Size = new System.Drawing.Size(217, 86);
            this.btnNv.TabIndex = 5;
            this.btnNv.Text = "Quản lý nhân viên";
            this.btnNv.UseVisualStyleBackColor = true;
            this.btnNv.Click += new System.EventHandler(this.btnNv_Click);
            // 
            // btnSach
            // 
            this.btnSach.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnSach.Location = new System.Drawing.Point(68, 49);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(217, 86);
            this.btnSach.TabIndex = 4;
            this.btnSach.Text = "Quản lý sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(159, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ THƯ VIỆN SÁCH THCS";
            // 
            // btnQuanlytk
            // 
            this.btnQuanlytk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQuanlytk.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnQuanlytk.Location = new System.Drawing.Point(205, 426);
            this.btnQuanlytk.Name = "btnQuanlytk";
            this.btnQuanlytk.Size = new System.Drawing.Size(222, 86);
            this.btnQuanlytk.TabIndex = 10;
            this.btnQuanlytk.Text = "Quản lý tài khoản";
            this.btnQuanlytk.UseVisualStyleBackColor = true;
            this.btnQuanlytk.Click += new System.EventHandler(this.btnQuanlytk_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(771, 745);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Menu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNv;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuanlytk;
    }
}

