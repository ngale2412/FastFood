namespace QLy
{
    partial class FormKHOtim
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
            this.dgvTimKho = new System.Windows.Forms.DataGridView();
            this.rdonxs = new System.Windows.Forms.RadioButton();
            this.rdohsd = new System.Windows.Forms.RadioButton();
            this.rdotensp = new System.Windows.Forms.RadioButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimKho
            // 
            this.dgvTimKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKho.Location = new System.Drawing.Point(73, 176);
            this.dgvTimKho.Name = "dgvTimKho";
            this.dgvTimKho.Size = new System.Drawing.Size(510, 242);
            this.dgvTimKho.TabIndex = 32;
            this.dgvTimKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimKho_CellClick);
            // 
            // rdonxs
            // 
            this.rdonxs.AutoSize = true;
            this.rdonxs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdonxs.Location = new System.Drawing.Point(283, 126);
            this.rdonxs.Name = "rdonxs";
            this.rdonxs.Size = new System.Drawing.Size(47, 17);
            this.rdonxs.TabIndex = 30;
            this.rdonxs.TabStop = true;
            this.rdonxs.Text = "NXS";
            this.rdonxs.UseVisualStyleBackColor = true;
            // 
            // rdohsd
            // 
            this.rdohsd.AutoSize = true;
            this.rdohsd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdohsd.Location = new System.Drawing.Point(374, 126);
            this.rdohsd.Name = "rdohsd";
            this.rdohsd.Size = new System.Drawing.Size(48, 17);
            this.rdohsd.TabIndex = 29;
            this.rdohsd.TabStop = true;
            this.rdohsd.Text = "HSD";
            this.rdohsd.UseVisualStyleBackColor = true;
            // 
            // rdotensp
            // 
            this.rdotensp.AutoSize = true;
            this.rdotensp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdotensp.Location = new System.Drawing.Point(192, 126);
            this.rdotensp.Name = "rdotensp";
            this.rdotensp.Size = new System.Drawing.Size(61, 17);
            this.rdotensp.TabIndex = 26;
            this.rdotensp.TabStop = true;
            this.rdotensp.Text = "Tên SP";
            this.rdotensp.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(183, 59);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(223, 20);
            this.txtTimkiem.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(134, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tìm  :";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(508, 120);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(412, 56);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 22;
            this.btnTimkiem.Text = "Tìm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // FormKHOtim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(662, 462);
            this.Controls.Add(this.dgvTimKho);
            this.Controls.Add(this.rdonxs);
            this.Controls.Add(this.rdohsd);
            this.Controls.Add(this.rdotensp);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTimkiem);
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormKHOtim";
            this.Text = "FormKHOtim";
            this.Load += new System.EventHandler(this.FormKHOtim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimKho;
        private System.Windows.Forms.RadioButton rdonxs;
        private System.Windows.Forms.RadioButton rdohsd;
        private System.Windows.Forms.RadioButton rdotensp;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTimkiem;
    }
}