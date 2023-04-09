namespace WindowsFormsApp1_QLNV
{
    partial class QLNV
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cmbPhongBan = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lstDSNV = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ho ten:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gioi Tinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phong ban:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(266, 77);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(374, 27);
            this.txtHoTen.TabIndex = 3;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Location = new System.Drawing.Point(266, 122);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(374, 28);
            this.cmbGioiTinh.TabIndex = 4;
            // 
            // cmbPhongBan
            // 
            this.cmbPhongBan.FormattingEnabled = true;
            this.cmbPhongBan.Location = new System.Drawing.Point(266, 168);
            this.cmbPhongBan.Name = "cmbPhongBan";
            this.cmbPhongBan.Size = new System.Drawing.Size(374, 28);
            this.cmbPhongBan.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(376, 227);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 37);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(529, 227);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 37);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Thoat";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lstDSNV
            // 
            this.lstDSNV.FormattingEnabled = true;
            this.lstDSNV.ItemHeight = 20;
            this.lstDSNV.Location = new System.Drawing.Point(103, 306);
            this.lstDSNV.Name = "lstDSNV";
            this.lstDSNV.Size = new System.Drawing.Size(537, 184);
            this.lstDSNV.Sorted = true;
            this.lstDSNV.TabIndex = 8;
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.lstDSNV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbPhongBan);
            this.Controls.Add(this.cmbGioiTinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QLNV";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QLNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.ComboBox cmbPhongBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox lstDSNV;
    }
}

