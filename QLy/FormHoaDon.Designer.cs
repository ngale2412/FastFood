namespace QLy
{
    partial class FormHoaDon
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
            this.dateTimePickerNGLAP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbNgSinh = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnChitiet = new System.Windows.Forms.ToolStripButton();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.rdoMaKH = new System.Windows.Forms.RadioButton();
            this.rdoMaNV = new System.Windows.Forms.RadioButton();
            this.rdoMaDH = new System.Windows.Forms.RadioButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapNhatTong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerNGLAP
            // 
            this.dateTimePickerNGLAP.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerNGLAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerNGLAP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNGLAP.Location = new System.Drawing.Point(158, 424);
            this.dateTimePickerNGLAP.Name = "dateTimePickerNGLAP";
            this.dateTimePickerNGLAP.Size = new System.Drawing.Size(193, 24);
            this.dateTimePickerNGLAP.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(49, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 103;
            this.label1.Text = "Ngày lập :";
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Location = new System.Drawing.Point(393, 110);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.Size = new System.Drawing.Size(401, 351);
            this.dgvDonHang.TabIndex = 98;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Cyan;
            this.label10.Location = new System.Drawing.Point(49, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 24);
            this.label10.TabIndex = 96;
            this.label10.Text = "Tổng tiền :";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.Color.Cyan;
            this.lbTen.Location = new System.Drawing.Point(51, 289);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(77, 24);
            this.lbTen.TabIndex = 95;
            this.lbTen.Text = "Mã KH :";
            // 
            // lbNgSinh
            // 
            this.lbNgSinh.AutoSize = true;
            this.lbNgSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgSinh.ForeColor = System.Drawing.Color.Cyan;
            this.lbNgSinh.Location = new System.Drawing.Point(51, 336);
            this.lbNgSinh.Name = "lbNgSinh";
            this.lbNgSinh.Size = new System.Drawing.Size(78, 24);
            this.lbNgSinh.TabIndex = 94;
            this.lbNgSinh.Text = "Mã NV :";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.ForeColor = System.Drawing.Color.Cyan;
            this.lbMaNV.Location = new System.Drawing.Point(51, 240);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(78, 24);
            this.lbMaNV.TabIndex = 93;
            this.lbMaNV.Text = "Mã ĐH :";
            // 
            // txtTong
            // 
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTong.Location = new System.Drawing.Point(158, 383);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(193, 24);
            this.txtTong.TabIndex = 91;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDH.Location = new System.Drawing.Point(158, 240);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(193, 24);
            this.txtMaDH.TabIndex = 90;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnLuu,
            this.btnXoa,
            this.btnCapNhat,
            this.btnChitiet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(840, 57);
            this.toolStrip1.TabIndex = 107;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.Image = global::QLy.Properties.Resources.user_add_icon;
            this.btnThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 54);
            this.btnThem.Text = " Thêm ";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSua.Image = global::QLy.Properties.Resources.Text_Edit_icon;
            this.btnSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 54);
            this.btnSua.Text = "  Sửa   ";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLuu.Image = global::QLy.Properties.Resources.Save_as_icon;
            this.btnLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 54);
            this.btnLuu.Text = "  Lưu   ";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.Image = global::QLy.Properties.Resources.delete;
            this.btnXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 54);
            this.btnXoa.Text = "  Xóa   ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCapNhat.Image = global::QLy.Properties.Resources.Button_Load_icon;
            this.btnCapNhat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(111, 54);
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnChitiet
            // 
            this.btnChitiet.BackColor = System.Drawing.Color.Yellow;
            this.btnChitiet.Image = global::QLy.Properties.Resources.Actions_view_list_details_icon;
            this.btnChitiet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChitiet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.Size = new System.Drawing.Size(164, 54);
            this.btnChitiet.Text = "Chi Tiết Hóa Đơn";
            this.btnChitiet.Click += new System.EventHandler(this.btnChitiet_Click);
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(158, 289);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(193, 24);
            this.cbbMaKH.TabIndex = 108;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(158, 337);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(193, 24);
            this.cbbMaNV.TabIndex = 109;
            // 
            // rdoMaKH
            // 
            this.rdoMaKH.AutoSize = true;
            this.rdoMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoMaKH.ForeColor = System.Drawing.Color.Yellow;
            this.rdoMaKH.Location = new System.Drawing.Point(162, 155);
            this.rdoMaKH.Name = "rdoMaKH";
            this.rdoMaKH.Size = new System.Drawing.Size(66, 20);
            this.rdoMaKH.TabIndex = 115;
            this.rdoMaKH.TabStop = true;
            this.rdoMaKH.Text = "Mã KH";
            this.rdoMaKH.UseVisualStyleBackColor = true;
            // 
            // rdoMaNV
            // 
            this.rdoMaNV.AutoSize = true;
            this.rdoMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoMaNV.ForeColor = System.Drawing.Color.Yellow;
            this.rdoMaNV.Location = new System.Drawing.Point(253, 155);
            this.rdoMaNV.Name = "rdoMaNV";
            this.rdoMaNV.Size = new System.Drawing.Size(67, 20);
            this.rdoMaNV.TabIndex = 114;
            this.rdoMaNV.TabStop = true;
            this.rdoMaNV.Text = "Mã NV";
            this.rdoMaNV.UseVisualStyleBackColor = true;
            // 
            // rdoMaDH
            // 
            this.rdoMaDH.AutoSize = true;
            this.rdoMaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoMaDH.ForeColor = System.Drawing.Color.Yellow;
            this.rdoMaDH.Location = new System.Drawing.Point(71, 155);
            this.rdoMaDH.Name = "rdoMaDH";
            this.rdoMaDH.Size = new System.Drawing.Size(67, 20);
            this.rdoMaDH.TabIndex = 113;
            this.rdoMaDH.TabStop = true;
            this.rdoMaDH.Text = "Mã ĐH";
            this.rdoMaDH.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(88, 121);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(223, 20);
            this.txtTimkiem.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(26, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 111;
            this.label3.Text = "Tìm  :";
            // 
            // btnCapNhatTong
            // 
            this.btnCapNhatTong.BackColor = System.Drawing.Color.MistyRose;
            this.btnCapNhatTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhatTong.Image = global::QLy.Properties.Resources.update_icon;
            this.btnCapNhatTong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatTong.Location = new System.Drawing.Point(670, 479);
            this.btnCapNhatTong.Name = "btnCapNhatTong";
            this.btnCapNhatTong.Size = new System.Drawing.Size(124, 45);
            this.btnCapNhatTong.TabIndex = 116;
            this.btnCapNhatTong.Text = "Cập Nhật  \r\nThanh Toán";
            this.btnCapNhatTong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatTong.UseVisualStyleBackColor = false;
            this.btnCapNhatTong.Click += new System.EventHandler(this.btnCapNhatTong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(572, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 118;
            this.label2.Text = "Nhấn vào cột \r\ncần cập nhật";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTimkiem.BackgroundImage = global::QLy.Properties.Resources.Zoom_icon;
            this.btnTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiem.Location = new System.Drawing.Point(309, 112);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(42, 37);
            this.btnTimkiem.TabIndex = 110;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(816, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 18);
            this.label4.TabIndex = 136;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCapNhatTong);
            this.Controls.Add(this.rdoMaKH);
            this.Controls.Add(this.rdoMaNV);
            this.Controls.Add(this.rdoMaDH);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.cbbMaKH);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dateTimePickerNGLAP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbNgSinh);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.txtMaDH);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDonHang";
            this.Load += new System.EventHandler(this.FormDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerNGLAP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbNgSinh;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.RadioButton rdoMaKH;
        private System.Windows.Forms.RadioButton rdoMaNV;
        private System.Windows.Forms.RadioButton rdoMaDH;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ToolStripButton btnChitiet;
        private System.Windows.Forms.Button btnCapNhatTong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}