namespace QLy
{
    partial class FormNV
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
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.dateTimePickerNgBD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgSinh = new System.Windows.Forms.DateTimePicker();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.lbHoTendem = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbGT = new System.Windows.Forms.Label();
            this.lbNgSinh = new System.Windows.Forms.Label();
            this.lbDT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDC = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtHotenDem = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtCa = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.rdoLuong = new System.Windows.Forms.RadioButton();
            this.rdoTen = new System.Windows.Forms.RadioButton();
            this.rdoGT = new System.Windows.Forms.RadioButton();
            this.rdoDC = new System.Windows.Forms.RadioButton();
            this.rdoCV = new System.Windows.Forms.RadioButton();
            this.rdoMaNV = new System.Windows.Forms.RadioButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.lbTong = new System.Windows.Forms.Label();
            this.labelt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(74, 305);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.Size = new System.Drawing.Size(693, 224);
            this.dgvNV.TabIndex = 54;
            this.dgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellClick);
            // 
            // dateTimePickerNgBD
            // 
            this.dateTimePickerNgBD.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerNgBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerNgBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgBD.Location = new System.Drawing.Point(641, 152);
            this.dateTimePickerNgBD.Name = "dateTimePickerNgBD";
            this.dateTimePickerNgBD.Size = new System.Drawing.Size(126, 22);
            this.dateTimePickerNgBD.TabIndex = 53;
            // 
            // dateTimePickerNgSinh
            // 
            this.dateTimePickerNgSinh.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerNgSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgSinh.Location = new System.Drawing.Point(384, 153);
            this.dateTimePickerNgSinh.Name = "dateTimePickerNgSinh";
            this.dateTimePickerNgSinh.Size = new System.Drawing.Size(126, 22);
            this.dateTimePickerNgSinh.TabIndex = 52;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoNu.Location = new System.Drawing.Point(231, 263);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(45, 20);
            this.rdoNu.TabIndex = 51;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nu";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoNam.Location = new System.Drawing.Point(164, 263);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(58, 20);
            this.rdoNam.TabIndex = 50;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // lbHoTendem
            // 
            this.lbHoTendem.AutoSize = true;
            this.lbHoTendem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHoTendem.ForeColor = System.Drawing.Color.Gold;
            this.lbHoTendem.Location = new System.Drawing.Point(71, 193);
            this.lbHoTendem.Name = "lbHoTendem";
            this.lbHoTendem.Size = new System.Drawing.Size(94, 16);
            this.lbHoTendem.TabIndex = 49;
            this.lbHoTendem.Text = "Họ-Tên đệm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(556, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "Ca làm :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(556, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "Lương :";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTen.ForeColor = System.Drawing.Color.Gold;
            this.lbTen.Location = new System.Drawing.Point(72, 222);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(35, 16);
            this.lbTen.TabIndex = 46;
            this.lbTen.Text = "Tên";
            // 
            // lbGT
            // 
            this.lbGT.AutoSize = true;
            this.lbGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGT.ForeColor = System.Drawing.Color.Gold;
            this.lbGT.Location = new System.Drawing.Point(72, 259);
            this.lbGT.Name = "lbGT";
            this.lbGT.Size = new System.Drawing.Size(70, 16);
            this.lbGT.TabIndex = 45;
            this.lbGT.Text = "Giới Tính";
            // 
            // lbNgSinh
            // 
            this.lbNgSinh.AutoSize = true;
            this.lbNgSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgSinh.ForeColor = System.Drawing.Color.Gold;
            this.lbNgSinh.Location = new System.Drawing.Point(326, 155);
            this.lbNgSinh.Name = "lbNgSinh";
            this.lbNgSinh.Size = new System.Drawing.Size(62, 16);
            this.lbNgSinh.TabIndex = 44;
            this.lbNgSinh.Text = "NgSinh:";
            // 
            // lbDT
            // 
            this.lbDT.AutoSize = true;
            this.lbDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDT.ForeColor = System.Drawing.Color.Gold;
            this.lbDT.Location = new System.Drawing.Point(326, 238);
            this.lbDT.Name = "lbDT";
            this.lbDT.Size = new System.Drawing.Size(46, 16);
            this.lbDT.TabIndex = 43;
            this.lbDT.Text = "SĐT :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(556, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "NgBatDau:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(556, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Công việc :";
            // 
            // lbDC
            // 
            this.lbDC.AutoSize = true;
            this.lbDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDC.ForeColor = System.Drawing.Color.Gold;
            this.lbDC.Location = new System.Drawing.Point(326, 196);
            this.lbDC.Name = "lbDC";
            this.lbDC.Size = new System.Drawing.Size(48, 16);
            this.lbDC.TabIndex = 40;
            this.lbDC.Text = "ĐChỉ :";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNV.ForeColor = System.Drawing.Color.Gold;
            this.lbMaNV.Location = new System.Drawing.Point(71, 160);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(62, 16);
            this.lbMaNV.TabIndex = 39;
            this.lbMaNV.Text = "Mã NV :";
            // 
            // txtDT
            // 
            this.txtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDT.Location = new System.Drawing.Point(384, 234);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(126, 22);
            this.txtDT.TabIndex = 38;
            // 
            // txtHotenDem
            // 
            this.txtHotenDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHotenDem.Location = new System.Drawing.Point(164, 194);
            this.txtHotenDem.Name = "txtHotenDem";
            this.txtHotenDem.Size = new System.Drawing.Size(116, 22);
            this.txtHotenDem.TabIndex = 37;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Location = new System.Drawing.Point(164, 226);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(116, 22);
            this.txtTen.TabIndex = 36;
            // 
            // txtCV
            // 
            this.txtCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCV.Location = new System.Drawing.Point(642, 188);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(126, 22);
            this.txtCV.TabIndex = 35;
            // 
            // txtDC
            // 
            this.txtDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDC.Location = new System.Drawing.Point(384, 193);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(126, 22);
            this.txtDC.TabIndex = 34;
            // 
            // txtCa
            // 
            this.txtCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCa.Location = new System.Drawing.Point(641, 229);
            this.txtCa.Name = "txtCa";
            this.txtCa.Size = new System.Drawing.Size(126, 22);
            this.txtCa.TabIndex = 33;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLuong.Location = new System.Drawing.Point(641, 268);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(126, 22);
            this.txtLuong.TabIndex = 32;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(164, 157);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(116, 22);
            this.txtMaNV.TabIndex = 31;
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
            this.toolStrip1.Size = new System.Drawing.Size(840, 51);
            this.toolStrip1.TabIndex = 59;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCapNhat.Image = global::QLy.Properties.Resources.Button_Load_icon;
            this.btnCapNhat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(111, 44);
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // rdoLuong
            // 
            this.rdoLuong.AutoSize = true;
            this.rdoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoLuong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoLuong.Location = new System.Drawing.Point(545, 108);
            this.rdoLuong.Name = "rdoLuong";
            this.rdoLuong.Size = new System.Drawing.Size(65, 19);
            this.rdoLuong.TabIndex = 68;
            this.rdoLuong.TabStop = true;
            this.rdoLuong.Text = "Lương";
            this.rdoLuong.UseVisualStyleBackColor = true;
            // 
            // rdoTen
            // 
            this.rdoTen.AutoSize = true;
            this.rdoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoTen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoTen.Location = new System.Drawing.Point(199, 108);
            this.rdoTen.Name = "rdoTen";
            this.rdoTen.Size = new System.Drawing.Size(49, 19);
            this.rdoTen.TabIndex = 67;
            this.rdoTen.TabStop = true;
            this.rdoTen.Text = "Tên";
            this.rdoTen.UseVisualStyleBackColor = true;
            // 
            // rdoGT
            // 
            this.rdoGT.AutoSize = true;
            this.rdoGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoGT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoGT.Location = new System.Drawing.Point(271, 108);
            this.rdoGT.Name = "rdoGT";
            this.rdoGT.Size = new System.Drawing.Size(79, 19);
            this.rdoGT.TabIndex = 66;
            this.rdoGT.TabStop = true;
            this.rdoGT.Text = "Giới tính";
            this.rdoGT.UseVisualStyleBackColor = true;
            // 
            // rdoDC
            // 
            this.rdoDC.AutoSize = true;
            this.rdoDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoDC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoDC.Location = new System.Drawing.Point(364, 108);
            this.rdoDC.Name = "rdoDC";
            this.rdoDC.Size = new System.Drawing.Size(70, 19);
            this.rdoDC.TabIndex = 65;
            this.rdoDC.TabStop = true;
            this.rdoDC.Text = "Địa chỉ";
            this.rdoDC.UseVisualStyleBackColor = true;
            // 
            // rdoCV
            // 
            this.rdoCV.AutoSize = true;
            this.rdoCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoCV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoCV.Location = new System.Drawing.Point(448, 108);
            this.rdoCV.Name = "rdoCV";
            this.rdoCV.Size = new System.Drawing.Size(87, 19);
            this.rdoCV.TabIndex = 64;
            this.rdoCV.TabStop = true;
            this.rdoCV.Text = "Công việc";
            this.rdoCV.UseVisualStyleBackColor = true;
            // 
            // rdoMaNV
            // 
            this.rdoMaNV.AutoSize = true;
            this.rdoMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoMaNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoMaNV.Location = new System.Drawing.Point(122, 108);
            this.rdoMaNV.Name = "rdoMaNV";
            this.rdoMaNV.Size = new System.Drawing.Size(67, 19);
            this.rdoMaNV.TabIndex = 63;
            this.rdoMaNV.TabStop = true;
            this.rdoMaNV.Text = "Mã NV";
            this.rdoMaNV.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(243, 77);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(223, 20);
            this.txtTimkiem.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(178, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Tìm NV :";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimkiem.BackgroundImage = global::QLy.Properties.Resources.Zoom_icon;
            this.btnTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiem.Location = new System.Drawing.Point(465, 70);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(36, 32);
            this.btnTimkiem.TabIndex = 60;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.BackColor = System.Drawing.Color.White;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTong.ForeColor = System.Drawing.Color.Red;
            this.lbTong.Location = new System.Drawing.Point(710, 79);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(46, 18);
            this.lbTong.TabIndex = 69;
            this.lbTong.Text = "label2";
            // 
            // labelt
            // 
            this.labelt.AutoSize = true;
            this.labelt.BackColor = System.Drawing.Color.White;
            this.labelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelt.ForeColor = System.Drawing.Color.Red;
            this.labelt.Location = new System.Drawing.Point(615, 79);
            this.labelt.Name = "labelt";
            this.labelt.Size = new System.Drawing.Size(95, 18);
            this.labelt.TabIndex = 70;
            this.labelt.Text = "Tổng Lương :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(816, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 18);
            this.label7.TabIndex = 139;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // FormNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelt);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.rdoLuong);
            this.Controls.Add(this.rdoTen);
            this.Controls.Add(this.rdoGT);
            this.Controls.Add(this.rdoDC);
            this.Controls.Add(this.rdoCV);
            this.Controls.Add(this.rdoMaNV);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvNV);
            this.Controls.Add(this.dateTimePickerNgBD);
            this.Controls.Add(this.dateTimePickerNgSinh);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.lbHoTendem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbGT);
            this.Controls.Add(this.lbNgSinh);
            this.Controls.Add(this.lbDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbDC);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtHotenDem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtCa);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtMaNV);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNV";
            this.Load += new System.EventHandler(this.FormNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgBD;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgSinh;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label lbHoTendem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbGT;
        private System.Windows.Forms.Label lbNgSinh;
        private System.Windows.Forms.Label lbDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDC;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtHotenDem;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtCa;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.RadioButton rdoLuong;
        private System.Windows.Forms.RadioButton rdoTen;
        private System.Windows.Forms.RadioButton rdoGT;
        private System.Windows.Forms.RadioButton rdoDC;
        private System.Windows.Forms.RadioButton rdoCV;
        private System.Windows.Forms.RadioButton rdoMaNV;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label labelt;
        private System.Windows.Forms.Label label7;
    }
}