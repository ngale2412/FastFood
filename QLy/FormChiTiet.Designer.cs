namespace QLy
{
    partial class FormChiTiet
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
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbNgSinh = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.cbbMaDH = new System.Windows.Forms.ComboBox();
            this.cbbMaSP = new System.Windows.Forms.ComboBox();
            this.rdoMakh = new System.Windows.Forms.RadioButton();
            this.rdoMasp = new System.Windows.Forms.RadioButton();
            this.rdoMaDH = new System.Windows.Forms.RadioButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(31, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 119;
            this.label1.Text = "Số lượng :";
            // 
            // dgvCT
            // 
            this.dgvCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT.Location = new System.Drawing.Point(369, 145);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.Size = new System.Drawing.Size(442, 353);
            this.dgvCT.TabIndex = 114;
            this.dgvCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCT_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(31, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 21);
            this.label10.TabIndex = 113;
            this.label10.Text = "Thành tiền";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.Color.Yellow;
            this.lbTen.Location = new System.Drawing.Point(27, 286);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(85, 21);
            this.lbTen.TabIndex = 112;
            this.lbTen.Text = "Mã KH :";
            // 
            // lbNgSinh
            // 
            this.lbNgSinh.AutoSize = true;
            this.lbNgSinh.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgSinh.ForeColor = System.Drawing.Color.Yellow;
            this.lbNgSinh.Location = new System.Drawing.Point(27, 331);
            this.lbNgSinh.Name = "lbNgSinh";
            this.lbNgSinh.Size = new System.Drawing.Size(78, 21);
            this.lbNgSinh.TabIndex = 111;
            this.lbNgSinh.Text = "Mã SP :";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.ForeColor = System.Drawing.Color.Yellow;
            this.lbMaNV.Location = new System.Drawing.Point(30, 238);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(82, 21);
            this.lbMaNV.TabIndex = 110;
            this.lbMaNV.Text = "Mã ĐH :";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKH.Location = new System.Drawing.Point(142, 285);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(193, 24);
            this.txtMaKH.TabIndex = 109;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGia.Location = new System.Drawing.Point(142, 422);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(193, 24);
            this.txtGia.TabIndex = 108;
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSL.Location = new System.Drawing.Point(142, 378);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(193, 24);
            this.txtSL.TabIndex = 123;
            // 
            // txtTien
            // 
            this.txtTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTien.Location = new System.Drawing.Point(142, 465);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(193, 24);
            this.txtTien.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(31, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 125;
            this.label3.Text = "Giá :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnLuu,
            this.btnXoa,
            this.btnCapNhat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(840, 62);
            this.toolStrip1.TabIndex = 126;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = global::QLy.Properties.Resources.Bookmark_add_icon;
            this.btnThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 59);
            this.btnThem.Text = "  Thêm  ";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Image = global::QLy.Properties.Resources.Text_Edit_icon;
            this.btnSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 59);
            this.btnSua.Text = "  Sửa   ";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Image = global::QLy.Properties.Resources.Save;
            this.btnLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 59);
            this.btnLuu.Text = "  Lưu   ";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Image = global::QLy.Properties.Resources.delete;
            this.btnXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 59);
            this.btnXoa.Text = "  Xóa   ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.Image = global::QLy.Properties.Resources.Button_Load_icon;
            this.btnCapNhat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(119, 59);
            this.btnCapNhat.Text = " Cập Nhật ";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cbbMaDH
            // 
            this.cbbMaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMaDH.FormattingEnabled = true;
            this.cbbMaDH.Location = new System.Drawing.Point(142, 237);
            this.cbbMaDH.Name = "cbbMaDH";
            this.cbbMaDH.Size = new System.Drawing.Size(193, 26);
            this.cbbMaDH.TabIndex = 127;
            this.cbbMaDH.SelectedIndexChanged += new System.EventHandler(this.cbbMaDH_SelectedIndexChanged);
            // 
            // cbbMaSP
            // 
            this.cbbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMaSP.FormattingEnabled = true;
            this.cbbMaSP.Location = new System.Drawing.Point(142, 330);
            this.cbbMaSP.Name = "cbbMaSP";
            this.cbbMaSP.Size = new System.Drawing.Size(193, 26);
            this.cbbMaSP.TabIndex = 128;
            this.cbbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbbMaSP_SelectedIndexChanged);
            // 
            // rdoMakh
            // 
            this.rdoMakh.AutoSize = true;
            this.rdoMakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoMakh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rdoMakh.Location = new System.Drawing.Point(166, 161);
            this.rdoMakh.Name = "rdoMakh";
            this.rdoMakh.Size = new System.Drawing.Size(71, 20);
            this.rdoMakh.TabIndex = 134;
            this.rdoMakh.TabStop = true;
            this.rdoMakh.Text = "Mã KH";
            this.rdoMakh.UseVisualStyleBackColor = true;
            // 
            // rdoMasp
            // 
            this.rdoMasp.AutoSize = true;
            this.rdoMasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoMasp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rdoMasp.Location = new System.Drawing.Point(257, 161);
            this.rdoMasp.Name = "rdoMasp";
            this.rdoMasp.Size = new System.Drawing.Size(71, 20);
            this.rdoMasp.TabIndex = 133;
            this.rdoMasp.TabStop = true;
            this.rdoMasp.Text = "Mã SP";
            this.rdoMasp.UseVisualStyleBackColor = true;
            // 
            // rdoMaDH
            // 
            this.rdoMaDH.AutoSize = true;
            this.rdoMaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoMaDH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rdoMaDH.Location = new System.Drawing.Point(75, 161);
            this.rdoMaDH.Name = "rdoMaDH";
            this.rdoMaDH.Size = new System.Drawing.Size(72, 20);
            this.rdoMaDH.TabIndex = 132;
            this.rdoMaDH.TabStop = true;
            this.rdoMaDH.Text = "Mã ĐH";
            this.rdoMaDH.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(82, 120);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(223, 20);
            this.txtTimkiem.TabIndex = 131;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(18, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 130;
            this.label2.Text = "Tìm  :";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Azure;
            this.btnTimKiem.BackgroundImage = global::QLy.Properties.Resources.Look_icon;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.Location = new System.Drawing.Point(303, 111);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(42, 37);
            this.btnTimKiem.TabIndex = 129;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(815, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 18);
            this.label4.TabIndex = 135;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdoMakh);
            this.Controls.Add(this.rdoMasp);
            this.Controls.Add(this.rdoMaDH);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbbMaSP);
            this.Controls.Add(this.cbbMaDH);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbNgSinh);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtGia);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChiTiet";
            this.Load += new System.EventHandler(this.FormChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbNgSinh;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ComboBox cbbMaDH;
        private System.Windows.Forms.ComboBox cbbMaSP;
        private System.Windows.Forms.RadioButton rdoMakh;
        private System.Windows.Forms.RadioButton rdoMasp;
        private System.Windows.Forms.RadioButton rdoMaDH;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label4;
    }
}