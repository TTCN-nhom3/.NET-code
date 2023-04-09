namespace WindowsFormsApp1_ptb2
{
    partial class PTB2
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
            this.xtxA = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.tx = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtNghiem = new System.Windows.Forms.TextBox();
            this.btnGiaiPT = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xtxA
            // 
            this.xtxA.AutoSize = true;
            this.xtxA.Location = new System.Drawing.Point(67, 68);
            this.xtxA.Name = "xtxA";
            this.xtxA.Size = new System.Drawing.Size(25, 16);
            this.xtxA.TabIndex = 0;
            this.xtxA.Text = "a =";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(67, 119);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(25, 16);
            this.lable.TabIndex = 1;
            this.lable.Text = "b =";
            // 
            // tx
            // 
            this.tx.AutoSize = true;
            this.tx.Location = new System.Drawing.Point(67, 167);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(24, 16);
            this.tx.TabIndex = 2;
            this.tx.Text = "c =";
            // 
            // txtN
            // 
            this.txtN.AutoSize = true;
            this.txtN.Location = new System.Drawing.Point(67, 213);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(54, 16);
            this.txtN.TabIndex = 3;
            this.txtN.Text = "Nghiem";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(197, 62);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(313, 22);
            this.txtA.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(197, 113);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(313, 22);
            this.txtB.TabIndex = 5;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(197, 161);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(313, 22);
            this.txtC.TabIndex = 6;
            // 
            // txtNghiem
            // 
            this.txtNghiem.Location = new System.Drawing.Point(197, 207);
            this.txtNghiem.Name = "txtNghiem";
            this.txtNghiem.Size = new System.Drawing.Size(432, 22);
            this.txtNghiem.TabIndex = 7;
            // 
            // btnGiaiPT
            // 
            this.btnGiaiPT.Location = new System.Drawing.Point(197, 255);
            this.btnGiaiPT.Name = "btnGiaiPT";
            this.btnGiaiPT.Size = new System.Drawing.Size(106, 43);
            this.btnGiaiPT.TabIndex = 8;
            this.btnGiaiPT.Text = "Giai PT";
            this.btnGiaiPT.UseVisualStyleBackColor = true;
            this.btnGiaiPT.Click += new System.EventHandler(this.btnGiaiPT_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(523, 255);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 43);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // PTB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiaiPT);
            this.Controls.Add(this.txtNghiem);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.xtxA);
            this.Name = "PTB2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PTB2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xtxA;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label tx;
        private System.Windows.Forms.Label txtN;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtNghiem;
        private System.Windows.Forms.Button btnGiaiPT;
        private System.Windows.Forms.Button btnThoat;
    }
}

