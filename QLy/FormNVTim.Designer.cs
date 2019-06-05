namespace QLy
{
    partial class FormNVTim
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
            this.dgvTimNV = new System.Windows.Forms.DataGridView();
            this.rdoLuong = new System.Windows.Forms.RadioButton();
            this.rdoTen = new System.Windows.Forms.RadioButton();
            this.rdoGT = new System.Windows.Forms.RadioButton();
            this.rdoDC = new System.Windows.Forms.RadioButton();
            this.rdoCV = new System.Windows.Forms.RadioButton();
            this.rdoMaNV = new System.Windows.Forms.RadioButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimNV
            // 
            this.dgvTimNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimNV.Location = new System.Drawing.Point(63, 186);
            this.dgvTimNV.Name = "dgvTimNV";
            this.dgvTimNV.Size = new System.Drawing.Size(510, 242);
            this.dgvTimNV.TabIndex = 21;
            this.dgvTimNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimNV_CellClick);
            // 
            // rdoLuong
            // 
            this.rdoLuong.AutoSize = true;
            this.rdoLuong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoLuong.Location = new System.Drawing.Point(519, 122);
            this.rdoLuong.Name = "rdoLuong";
            this.rdoLuong.Size = new System.Drawing.Size(55, 17);
            this.rdoLuong.TabIndex = 20;
            this.rdoLuong.TabStop = true;
            this.rdoLuong.Text = "Lương";
            this.rdoLuong.UseVisualStyleBackColor = true;
            // 
            // rdoTen
            // 
            this.rdoTen.AutoSize = true;
            this.rdoTen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoTen.Location = new System.Drawing.Point(155, 122);
            this.rdoTen.Name = "rdoTen";
            this.rdoTen.Size = new System.Drawing.Size(44, 17);
            this.rdoTen.TabIndex = 19;
            this.rdoTen.TabStop = true;
            this.rdoTen.Text = "Tên";
            this.rdoTen.UseVisualStyleBackColor = true;
            // 
            // rdoGT
            // 
            this.rdoGT.AutoSize = true;
            this.rdoGT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoGT.Location = new System.Drawing.Point(246, 122);
            this.rdoGT.Name = "rdoGT";
            this.rdoGT.Size = new System.Drawing.Size(65, 17);
            this.rdoGT.TabIndex = 18;
            this.rdoGT.TabStop = true;
            this.rdoGT.Text = "Giới tính";
            this.rdoGT.UseVisualStyleBackColor = true;
            // 
            // rdoDC
            // 
            this.rdoDC.AutoSize = true;
            this.rdoDC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoDC.Location = new System.Drawing.Point(337, 122);
            this.rdoDC.Name = "rdoDC";
            this.rdoDC.Size = new System.Drawing.Size(58, 17);
            this.rdoDC.TabIndex = 17;
            this.rdoDC.TabStop = true;
            this.rdoDC.Text = "Địa chỉ";
            this.rdoDC.UseVisualStyleBackColor = true;
            // 
            // rdoCV
            // 
            this.rdoCV.AutoSize = true;
            this.rdoCV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoCV.Location = new System.Drawing.Point(428, 122);
            this.rdoCV.Name = "rdoCV";
            this.rdoCV.Size = new System.Drawing.Size(73, 17);
            this.rdoCV.TabIndex = 16;
            this.rdoCV.TabStop = true;
            this.rdoCV.Text = "Công việc";
            this.rdoCV.UseVisualStyleBackColor = true;
            // 
            // rdoMaNV
            // 
            this.rdoMaNV.AutoSize = true;
            this.rdoMaNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoMaNV.Location = new System.Drawing.Point(64, 122);
            this.rdoMaNV.Name = "rdoMaNV";
            this.rdoMaNV.Size = new System.Drawing.Size(58, 17);
            this.rdoMaNV.TabIndex = 15;
            this.rdoMaNV.TabStop = true;
            this.rdoMaNV.Text = "Mã NV";
            this.rdoMaNV.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(115, 49);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(223, 20);
            this.txtTimkiem.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(61, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tìm NV :";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(479, 49);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(364, 47);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 11;
            this.btnTimkiem.Text = "Tìm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // FormNVTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(662, 462);
            this.Controls.Add(this.dgvTimNV);
            this.Controls.Add(this.rdoLuong);
            this.Controls.Add(this.rdoTen);
            this.Controls.Add(this.rdoGT);
            this.Controls.Add(this.rdoDC);
            this.Controls.Add(this.rdoCV);
            this.Controls.Add(this.rdoMaNV);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTimkiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormNVTim";
            this.Text = "FormNVTim";
            this.Load += new System.EventHandler(this.FormNVTim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimNV;
        private System.Windows.Forms.RadioButton rdoLuong;
        private System.Windows.Forms.RadioButton rdoTen;
        private System.Windows.Forms.RadioButton rdoGT;
        private System.Windows.Forms.RadioButton rdoDC;
        private System.Windows.Forms.RadioButton rdoCV;
        private System.Windows.Forms.RadioButton rdoMaNV;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTimkiem;
    }
}