namespace WindowsFormsApp1_ChonSach
{
    partial class ChonSach
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
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.lstSachChon = new System.Windows.Forms.ListBox();
            this.btnThem1 = new System.Windows.Forms.Button();
            this.btnThemNhieu = new System.Windows.Forms.Button();
            this.btxXoa1 = new System.Windows.Forms.Button();
            this.btnXoaNhieu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sach";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sach da chon";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 20;
            this.lstDanhSach.Location = new System.Drawing.Point(136, 114);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(301, 324);
            this.lstDanhSach.TabIndex = 2;
            // 
            // lstSachChon
            // 
            this.lstSachChon.FormattingEnabled = true;
            this.lstSachChon.ItemHeight = 20;
            this.lstSachChon.Location = new System.Drawing.Point(680, 114);
            this.lstSachChon.Name = "lstSachChon";
            this.lstSachChon.Size = new System.Drawing.Size(301, 324);
            this.lstSachChon.TabIndex = 3;
            // 
            // btnThem1
            // 
            this.btnThem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem1.Location = new System.Drawing.Point(497, 135);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(107, 38);
            this.btnThem1.TabIndex = 4;
            this.btnThem1.Text = ">";
            this.btnThem1.UseVisualStyleBackColor = false;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // btnThemNhieu
            // 
            this.btnThemNhieu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemNhieu.Location = new System.Drawing.Point(497, 220);
            this.btnThemNhieu.Name = "btnThemNhieu";
            this.btnThemNhieu.Size = new System.Drawing.Size(107, 38);
            this.btnThemNhieu.TabIndex = 5;
            this.btnThemNhieu.Text = ">>";
            this.btnThemNhieu.UseVisualStyleBackColor = false;
            this.btnThemNhieu.Click += new System.EventHandler(this.btnThemNhieu_Click);
            // 
            // btxXoa1
            // 
            this.btxXoa1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btxXoa1.Location = new System.Drawing.Point(497, 302);
            this.btxXoa1.Name = "btxXoa1";
            this.btxXoa1.Size = new System.Drawing.Size(107, 38);
            this.btxXoa1.TabIndex = 6;
            this.btxXoa1.Text = "<";
            this.btxXoa1.UseVisualStyleBackColor = false;
            this.btxXoa1.Click += new System.EventHandler(this.btxXoa1_Click);
            // 
            // btnXoaNhieu
            // 
            this.btnXoaNhieu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoaNhieu.Location = new System.Drawing.Point(497, 376);
            this.btnXoaNhieu.Name = "btnXoaNhieu";
            this.btnXoaNhieu.Size = new System.Drawing.Size(107, 38);
            this.btnXoaNhieu.TabIndex = 7;
            this.btnXoaNhieu.Text = "<<";
            this.btnXoaNhieu.UseVisualStyleBackColor = false;
            this.btnXoaNhieu.Click += new System.EventHandler(this.btnXoaNhieu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Location = new System.Drawing.Point(874, 474);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 38);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ChonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 744);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaNhieu);
            this.Controls.Add(this.btxXoa1);
            this.Controls.Add(this.btnThemNhieu);
            this.Controls.Add(this.btnThem1);
            this.Controls.Add(this.lstSachChon);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChonSach";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ChonSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.ListBox lstSachChon;
        private System.Windows.Forms.Button btnThem1;
        private System.Windows.Forms.Button btnThemNhieu;
        private System.Windows.Forms.Button btxXoa1;
        private System.Windows.Forms.Button btnXoaNhieu;
        private System.Windows.Forms.Button btnThoat;
    }
}

