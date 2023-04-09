namespace WindowsFormsApp1_capNhatThanhVien
{
    partial class CapNhatTV
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.grGioiTinh = new System.Windows.Forms.GroupBox();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.grHonNhan = new System.Windows.Forms.GroupBox();
            this.rbtnChuaKH = new System.Windows.Forms.RadioButton();
            this.rbtnDaKH = new System.Windows.Forms.RadioButton();
            this.grSoThich = new System.Windows.Forms.GroupBox();
            this.cbBoiLoi = new System.Windows.Forms.CheckBox();
            this.cbAmNhac = new System.Windows.Forms.CheckBox();
            this.cbLeoNui = new System.Windows.Forms.CheckBox();
            this.cbDaBong = new System.Windows.Forms.CheckBox();
            this.lstCapNhat = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grGioiTinh.SuspendLayout();
            this.grHonNhan.SuspendLayout();
            this.grSoThich.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(86, 55);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(829, 464);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ho ten:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(226, 83);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(295, 27);
            this.txtHoTen.TabIndex = 2;
            // 
            // grGioiTinh
            // 
            this.grGioiTinh.Controls.Add(this.rbtnNu);
            this.grGioiTinh.Controls.Add(this.rbtnNam);
            this.grGioiTinh.Location = new System.Drawing.Point(121, 137);
            this.grGioiTinh.Name = "grGioiTinh";
            this.grGioiTinh.Size = new System.Drawing.Size(400, 68);
            this.grGioiTinh.TabIndex = 3;
            this.grGioiTinh.TabStop = false;
            this.grGioiTinh.Text = "Gioi tinh";
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(195, 26);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(51, 24);
            this.rbtnNu.TabIndex = 1;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nu";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(15, 27);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(65, 24);
            this.rbtnNam.TabIndex = 0;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // grHonNhan
            // 
            this.grHonNhan.Controls.Add(this.rbtnChuaKH);
            this.grHonNhan.Controls.Add(this.rbtnDaKH);
            this.grHonNhan.Location = new System.Drawing.Point(121, 211);
            this.grHonNhan.Name = "grHonNhan";
            this.grHonNhan.Size = new System.Drawing.Size(400, 72);
            this.grHonNhan.TabIndex = 4;
            this.grHonNhan.TabStop = false;
            this.grHonNhan.Text = "Tinh trang hon nhan";
            // 
            // rbtnChuaKH
            // 
            this.rbtnChuaKH.AutoSize = true;
            this.rbtnChuaKH.Location = new System.Drawing.Point(195, 26);
            this.rbtnChuaKH.Name = "rbtnChuaKH";
            this.rbtnChuaKH.Size = new System.Drawing.Size(128, 24);
            this.rbtnChuaKH.TabIndex = 1;
            this.rbtnChuaKH.TabStop = true;
            this.rbtnChuaKH.Text = "Chua ket hon";
            this.rbtnChuaKH.UseVisualStyleBackColor = true;
            // 
            // rbtnDaKH
            // 
            this.rbtnDaKH.AutoSize = true;
            this.rbtnDaKH.Location = new System.Drawing.Point(15, 26);
            this.rbtnDaKH.Name = "rbtnDaKH";
            this.rbtnDaKH.Size = new System.Drawing.Size(111, 24);
            this.rbtnDaKH.TabIndex = 0;
            this.rbtnDaKH.TabStop = true;
            this.rbtnDaKH.Text = "Da ket hon";
            this.rbtnDaKH.UseVisualStyleBackColor = true;
            // 
            // grSoThich
            // 
            this.grSoThich.Controls.Add(this.cbBoiLoi);
            this.grSoThich.Controls.Add(this.cbAmNhac);
            this.grSoThich.Controls.Add(this.cbLeoNui);
            this.grSoThich.Controls.Add(this.cbDaBong);
            this.grSoThich.Location = new System.Drawing.Point(121, 289);
            this.grSoThich.Name = "grSoThich";
            this.grSoThich.Size = new System.Drawing.Size(398, 138);
            this.grSoThich.TabIndex = 5;
            this.grSoThich.TabStop = false;
            this.grSoThich.Text = "So thich";
            // 
            // cbBoiLoi
            // 
            this.cbBoiLoi.AutoSize = true;
            this.cbBoiLoi.Location = new System.Drawing.Point(195, 85);
            this.cbBoiLoi.Name = "cbBoiLoi";
            this.cbBoiLoi.Size = new System.Drawing.Size(78, 24);
            this.cbBoiLoi.TabIndex = 3;
            this.cbBoiLoi.Text = "Boi loi";
            this.cbBoiLoi.UseVisualStyleBackColor = true;
            // 
            // cbAmNhac
            // 
            this.cbAmNhac.AutoSize = true;
            this.cbAmNhac.Location = new System.Drawing.Point(195, 36);
            this.cbAmNhac.Name = "cbAmNhac";
            this.cbAmNhac.Size = new System.Drawing.Size(97, 24);
            this.cbAmNhac.TabIndex = 2;
            this.cbAmNhac.Text = "Am nhac";
            this.cbAmNhac.UseVisualStyleBackColor = true;
            // 
            // cbLeoNui
            // 
            this.cbLeoNui.AutoSize = true;
            this.cbLeoNui.Location = new System.Drawing.Point(15, 85);
            this.cbLeoNui.Name = "cbLeoNui";
            this.cbLeoNui.Size = new System.Drawing.Size(86, 24);
            this.cbLeoNui.TabIndex = 1;
            this.cbLeoNui.Text = "Leo nui";
            this.cbLeoNui.UseVisualStyleBackColor = true;
            // 
            // cbDaBong
            // 
            this.cbDaBong.AutoSize = true;
            this.cbDaBong.Location = new System.Drawing.Point(15, 36);
            this.cbDaBong.Name = "cbDaBong";
            this.cbDaBong.Size = new System.Drawing.Size(93, 24);
            this.cbDaBong.TabIndex = 0;
            this.cbDaBong.Text = "Bong da";
            this.cbDaBong.UseVisualStyleBackColor = true;
            // 
            // lstCapNhat
            // 
            this.lstCapNhat.FormattingEnabled = true;
            this.lstCapNhat.ItemHeight = 20;
            this.lstCapNhat.Location = new System.Drawing.Point(584, 83);
            this.lstCapNhat.Name = "lstCapNhat";
            this.lstCapNhat.Size = new System.Drawing.Size(291, 344);
            this.lstCapNhat.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(584, 452);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 41);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(758, 452);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 41);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // CapNhatTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lstCapNhat);
            this.Controls.Add(this.grSoThich);
            this.Controls.Add(this.grHonNhan);
            this.Controls.Add(this.grGioiTinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CapNhatTV";
            this.Text = "Form1";
            this.grGioiTinh.ResumeLayout(false);
            this.grGioiTinh.PerformLayout();
            this.grHonNhan.ResumeLayout(false);
            this.grHonNhan.PerformLayout();
            this.grSoThich.ResumeLayout(false);
            this.grSoThich.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox grGioiTinh;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.GroupBox grHonNhan;
        private System.Windows.Forms.RadioButton rbtnChuaKH;
        private System.Windows.Forms.RadioButton rbtnDaKH;
        private System.Windows.Forms.GroupBox grSoThich;
        private System.Windows.Forms.CheckBox cbBoiLoi;
        private System.Windows.Forms.CheckBox cbAmNhac;
        private System.Windows.Forms.CheckBox cbLeoNui;
        private System.Windows.Forms.CheckBox cbDaBong;
        private System.Windows.Forms.ListBox lstCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
    }
}

