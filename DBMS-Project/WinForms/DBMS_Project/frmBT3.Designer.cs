namespace DBMS_Project
{
    partial class frmBT3
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
            this.btnTinhTuoi = new System.Windows.Forms.Button();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTinhTuoi
            // 
            this.btnTinhTuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnTinhTuoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhTuoi.FlatAppearance.BorderSize = 0;
            this.btnTinhTuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhTuoi.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnTinhTuoi.ForeColor = System.Drawing.Color.White;
            this.btnTinhTuoi.Location = new System.Drawing.Point(258, 193);
            this.btnTinhTuoi.Name = "btnTinhTuoi";
            this.btnTinhTuoi.Size = new System.Drawing.Size(154, 32);
            this.btnTinhTuoi.TabIndex = 5;
            this.btnTinhTuoi.Text = "Tính Tuổi ";
            this.btnTinhTuoi.UseVisualStyleBackColor = false;
            this.btnTinhTuoi.Click += new System.EventHandler(this.btnTinhTuoi_Click);
            // 
            // lblISBN
            // 
            this.lblISBN.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblISBN.Location = new System.Drawing.Point(116, 136);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(135, 28);
            this.lblISBN.TabIndex = 6;
            this.lblISBN.Text = "Nhập năm sinh:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label1.Location = new System.Drawing.Point(144, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kết quả: ";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnQuayLai.Location = new System.Drawing.Point(22, 364);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(100, 35);
            this.btnQuayLai.TabIndex = 8;
            this.btnQuayLai.Text = "Quay lai";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtNamSinh.Location = new System.Drawing.Point(258, 133);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(251, 29);
            this.txtNamSinh.TabIndex = 9;
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKetQua.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtKetQua.Location = new System.Drawing.Point(258, 263);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(251, 29);
            this.txtKetQua.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Navy;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(634, 55);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "BT3 — Function: Tính tuổi theo năm sinh";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBT3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.btnTinhTuoi);
            this.Name = "frmBT3";
            this.Text = "frmBT3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTinhTuoi;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label lblTitle;
    }
}