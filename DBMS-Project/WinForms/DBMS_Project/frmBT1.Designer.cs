namespace DBMS_Project
{
    partial class frmBT1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSoA = new System.Windows.Forms.Label();
            this.lblSoB = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(480, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BT1 — Stored Procedure: Tính tổng 2 số nguyên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoA
            // 
            this.lblSoA.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblSoA.Location = new System.Drawing.Point(52, 90);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(108, 28);
            this.lblSoA.TabIndex = 1;
            this.lblSoA.Text = "Số thứ nhất:";
            // 
            // lblSoB
            // 
            this.lblSoB.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblSoB.Location = new System.Drawing.Point(56, 140);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(104, 28);
            this.lblSoB.TabIndex = 3;
            this.lblSoB.Text = "Số thứ hai:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblKetQua.Location = new System.Drawing.Point(80, 255);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(80, 28);
            this.lblKetQua.TabIndex = 6;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // txtSoA
            // 
            this.txtSoA.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtSoA.Location = new System.Drawing.Point(170, 88);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(200, 29);
            this.txtSoA.TabIndex = 2;
            // 
            // txtSoB
            // 
            this.txtSoB.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtSoB.Location = new System.Drawing.Point(170, 138);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(200, 29);
            this.txtSoB.TabIndex = 4;
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtKetQua.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.txtKetQua.Location = new System.Drawing.Point(170, 253);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(200, 29);
            this.txtKetQua.TabIndex = 7;
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinh.FlatAppearance.BorderSize = 0;
            this.btnTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinh.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnTinh.ForeColor = System.Drawing.Color.White;
            this.btnTinh.Location = new System.Drawing.Point(170, 190);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(200, 38);
            this.btnTinh.TabIndex = 5;
            this.btnTinh.Text = "TÍNH TỔNG";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnQuayLai.Location = new System.Drawing.Point(85, 310);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(100, 35);
            this.btnQuayLai.TabIndex = 8;
            this.btnQuayLai.Text = "Quay lai";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // frmBT1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 380);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSoA);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnQuayLai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBT1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BT1 - Tinh Tong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnQuayLai;
    }
}