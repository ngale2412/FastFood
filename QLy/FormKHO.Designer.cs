namespace QLy
{
    partial class FormKHO
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
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.dateTimePickerNXS = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbNgSinh = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.dateTimePickerHSD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.rdonxs = new System.Windows.Forms.RadioButton();
            this.rdohsd = new System.Windows.Forms.RadioButton();
            this.rdotensp = new System.Windows.Forms.RadioButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cbbMaSP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKho
            // 
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Location = new System.Drawing.Point(354, 114);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.Size = new System.Drawing.Size(442, 400);
            this.dgvKho.TabIndex = 82;
            this.dgvKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKho_CellClick);
            // 
            // dateTimePickerNXS
            // 
            this.dateTimePickerNXS.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerNXS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerNXS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNXS.Location = new System.Drawing.Point(142, 366);
            this.dateTimePickerNXS.Name = "dateTimePickerNXS";
            this.dateTimePickerNXS.Size = new System.Drawing.Size(193, 24);
            this.dateTimePickerNXS.TabIndex = 80;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(41, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 21);
            this.label10.TabIndex = 75;
            this.label10.Text = "Số lượng :";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTen.Location = new System.Drawing.Point(43, 319);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(43, 21);
            this.lbTen.TabIndex = 74;
            this.lbTen.Text = "Tên";
            // 
            // lbNgSinh
            // 
            this.lbNgSinh.AutoSize = true;
            this.lbNgSinh.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgSinh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNgSinh.Location = new System.Drawing.Point(43, 366);
            this.lbNgSinh.Name = "lbNgSinh";
            this.lbNgSinh.Size = new System.Drawing.Size(61, 21);
            this.lbNgSinh.TabIndex = 72;
            this.lbNgSinh.Text = "NXS :";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMaNV.Location = new System.Drawing.Point(43, 270);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(78, 21);
            this.lbMaNV.TabIndex = 67;
            this.lbMaNV.Text = "Mã SP :";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Location = new System.Drawing.Point(142, 318);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(193, 24);
            this.txtTen.TabIndex = 64;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoluong.Location = new System.Drawing.Point(142, 464);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(193, 24);
            this.txtSoluong.TabIndex = 60;
            // 
            // dateTimePickerHSD
            // 
            this.dateTimePickerHSD.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerHSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerHSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHSD.Location = new System.Drawing.Point(142, 416);
            this.dateTimePickerHSD.Name = "dateTimePickerHSD";
            this.dateTimePickerHSD.Size = new System.Drawing.Size(193, 24);
            this.dateTimePickerHSD.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 87;
            this.label1.Text = "HSD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(26, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 24);
            this.label2.TabIndex = 89;
            this.label2.Text = "Thông tin phòng bánh :";
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
            this.btnCapNhat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(840, 58);
            this.toolStrip1.TabIndex = 90;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThem.Image = global::QLy.Properties.Resources.user_add_icon;
            this.btnThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 44);
            this.btnThem.Text = " Thêm ";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSua.Image = global::QLy.Properties.Resources.Text_Edit_icon;
            this.btnSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 44);
            this.btnSua.Text = "  Sửa   ";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLuu.Image = global::QLy.Properties.Resources.Save_as_icon;
            this.btnLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 44);
            this.btnLuu.Text = "  Lưu   ";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnXoa.Image = global::QLy.Properties.Resources.delete;
            this.btnXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 44);
            this.btnXoa.Text = "  Xóa   ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCapNhat.Image = global::QLy.Properties.Resources.Button_Load_icon;
            this.btnCapNhat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(111, 44);
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // rdonxs
            // 
            this.rdonxs.AutoSize = true;
            this.rdonxs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdonxs.ForeColor = System.Drawing.Color.LawnGreen;
            this.rdonxs.Location = new System.Drawing.Point(152, 142);
            this.rdonxs.Name = "rdonxs";
            this.rdonxs.Size = new System.Drawing.Size(56, 20);
            this.rdonxs.TabIndex = 96;
            this.rdonxs.TabStop = true;
            this.rdonxs.Text = "NXS";
            this.rdonxs.UseVisualStyleBackColor = true;
            // 
            // rdohsd
            // 
            this.rdohsd.AutoSize = true;
            this.rdohsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdohsd.ForeColor = System.Drawing.Color.LawnGreen;
            this.rdohsd.Location = new System.Drawing.Point(243, 142);
            this.rdohsd.Name = "rdohsd";
            this.rdohsd.Size = new System.Drawing.Size(58, 20);
            this.rdohsd.TabIndex = 95;
            this.rdohsd.TabStop = true;
            this.rdohsd.Text = "HSD";
            this.rdohsd.UseVisualStyleBackColor = true;
            // 
            // rdotensp
            // 
            this.rdotensp.AutoSize = true;
            this.rdotensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdotensp.ForeColor = System.Drawing.Color.LawnGreen;
            this.rdotensp.Location = new System.Drawing.Point(61, 142);
            this.rdotensp.Name = "rdotensp";
            this.rdotensp.Size = new System.Drawing.Size(77, 20);
            this.rdotensp.TabIndex = 94;
            this.rdotensp.TabStop = true;
            this.rdotensp.Text = "Tên SP";
            this.rdotensp.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(80, 101);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(211, 20);
            this.txtTimkiem.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 92;
            this.label3.Text = "Tìm  :";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTimkiem.BackgroundImage = global::QLy.Properties.Resources.Search_icon__1_;
            this.btnTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiem.Location = new System.Drawing.Point(289, 92);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(42, 37);
            this.btnTimkiem.TabIndex = 91;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // cbbMaSP
            // 
            this.cbbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMaSP.FormattingEnabled = true;
            this.cbbMaSP.Location = new System.Drawing.Point(142, 270);
            this.cbbMaSP.Name = "cbbMaSP";
            this.cbbMaSP.Size = new System.Drawing.Size(193, 24);
            this.cbbMaSP.TabIndex = 97;
            this.cbbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbbMaSP_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(815, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 18);
            this.label7.TabIndex = 138;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // FormKHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbMaSP);
            this.Controls.Add(this.rdonxs);
            this.Controls.Add(this.rdohsd);
            this.Controls.Add(this.rdotensp);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerHSD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKho);
            this.Controls.Add(this.dateTimePickerNXS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbNgSinh);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtSoluong);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKHO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKHO";
            this.Load += new System.EventHandler(this.FormKHO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.DateTimePicker dateTimePickerNXS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbNgSinh;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.DateTimePicker dateTimePickerHSD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.RadioButton rdonxs;
        private System.Windows.Forms.RadioButton rdohsd;
        private System.Windows.Forms.RadioButton rdotensp;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cbbMaSP;
        private System.Windows.Forms.Label label7;
    }
}