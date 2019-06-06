namespace QLy
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageNV = new System.Windows.Forms.TabPage();
            this.tabPageKH = new System.Windows.Forms.TabPage();
            this.tabPageSP = new System.Windows.Forms.TabPage();
            this.tabPageKho = new System.Windows.Forms.TabPage();
            this.tabPageDonHang = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPageThongKe = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageNV);
            this.tabControl1.Controls.Add(this.tabPageKH);
            this.tabControl1.Controls.Add(this.tabPageSP);
            this.tabControl1.Controls.Add(this.tabPageKho);
            this.tabControl1.Controls.Add(this.tabPageDonHang);
            this.tabControl1.Controls.Add(this.tabPageThongKe);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(48, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 586);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Tag = "6";
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::QLy.Properties.Resources.bakery;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(833, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "0";
            this.tabPage1.Text = "   Home   ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageNV
            // 
            this.tabPageNV.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageNV.BackgroundImage = global::QLy.Properties.Resources.macaron;
            this.tabPageNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageNV.Location = new System.Drawing.Point(4, 25);
            this.tabPageNV.Name = "tabPageNV";
            this.tabPageNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNV.Size = new System.Drawing.Size(833, 557);
            this.tabPageNV.TabIndex = 1;
            this.tabPageNV.Tag = "1";
            this.tabPageNV.Text = "   Nhân Viên   ";
            // 
            // tabPageKH
            // 
            this.tabPageKH.BackgroundImage = global::QLy.Properties.Resources._2_cach_lam_banh_mousse_don_gian_ngot_mat_cho_ngay_he_22_jpeg;
            this.tabPageKH.Location = new System.Drawing.Point(4, 25);
            this.tabPageKH.Name = "tabPageKH";
            this.tabPageKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKH.Size = new System.Drawing.Size(833, 557);
            this.tabPageKH.TabIndex = 2;
            this.tabPageKH.Tag = "2";
            this.tabPageKH.Text = "  Khách Hàng  ";
            this.tabPageKH.UseVisualStyleBackColor = true;
            // 
            // tabPageSP
            // 
            this.tabPageSP.BackgroundImage = global::QLy.Properties.Resources.m_c;
            this.tabPageSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageSP.Location = new System.Drawing.Point(4, 25);
            this.tabPageSP.Name = "tabPageSP";
            this.tabPageSP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSP.Size = new System.Drawing.Size(833, 557);
            this.tabPageSP.TabIndex = 3;
            this.tabPageSP.Tag = "3";
            this.tabPageSP.Text = "  Sản Phẩm  ";
            this.tabPageSP.UseVisualStyleBackColor = true;
            this.tabPageSP.Click += new System.EventHandler(this.tabPageSP_Click);
            // 
            // tabPageKho
            // 
            this.tabPageKho.BackgroundImage = global::QLy.Properties.Resources.banh_macaron_1;
            this.tabPageKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPageKho.Location = new System.Drawing.Point(4, 25);
            this.tabPageKho.Name = "tabPageKho";
            this.tabPageKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKho.Size = new System.Drawing.Size(833, 557);
            this.tabPageKho.TabIndex = 4;
            this.tabPageKho.Text = "  Loại Sản Phẩm   ";
            this.tabPageKho.UseVisualStyleBackColor = true;
            this.tabPageKho.Click += new System.EventHandler(this.tabPageKho_Click);
            // 
            // tabPageDonHang
            // 
            this.tabPageDonHang.BackgroundImage = global::QLy.Properties.Resources._4_oz_Strawberry_Cheesecake;
            this.tabPageDonHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageDonHang.Location = new System.Drawing.Point(4, 25);
            this.tabPageDonHang.Name = "tabPageDonHang";
            this.tabPageDonHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDonHang.Size = new System.Drawing.Size(833, 557);
            this.tabPageDonHang.TabIndex = 5;
            this.tabPageDonHang.Tag = "5";
            this.tabPageDonHang.Text = "    Đơn Hàng   ";
            this.tabPageDonHang.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(34, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "GIN\'S HOUSE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 35);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(911, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLy.Properties.Resources.cake;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(-1, 648);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 39);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QLy.Properties.Resources.info;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(897, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tabPageThongKe
            // 
            this.tabPageThongKe.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPageThongKe.BackgroundImage = global::QLy.Properties.Resources.tiramisu;
            this.tabPageThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageThongKe.Location = new System.Drawing.Point(4, 25);
            this.tabPageThongKe.Name = "tabPageThongKe";
            this.tabPageThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThongKe.Size = new System.Drawing.Size(833, 557);
            this.tabPageThongKe.TabIndex = 6;
            this.tabPageThongKe.Text = "   Thống Kê   ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(934, 685);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageNV;
        private System.Windows.Forms.TabPage tabPageKH;
        private System.Windows.Forms.TabPage tabPageSP;
        private System.Windows.Forms.TabPage tabPageKho;
        private System.Windows.Forms.TabPage tabPageDonHang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPageThongKe;
    }
}