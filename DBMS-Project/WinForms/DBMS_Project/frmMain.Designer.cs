namespace DBMS_Project
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.btnBT1 = new System.Windows.Forms.Button();
            this.btnBT2 = new System.Windows.Forms.Button();
            this.btnBT3 = new System.Windows.Forms.Button();
            this.btnBT5 = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(933, 74);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "DBMS PROJECT — Stored Procedures, Triggers & Functions";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic);
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(80, 523);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(747, 31);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Trạng thái: Chưa kết nối CSDL";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKetNoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKetNoi.FlatAppearance.BorderSize = 0;
            this.btnKetNoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetNoi.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnKetNoi.ForeColor = System.Drawing.Color.White;
            this.btnKetNoi.Location = new System.Drawing.Point(80, 37);
            this.btnKetNoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(747, 55);
            this.btnKetNoi.TabIndex = 0;
            this.btnKetNoi.Text = "KẾT NỐI CSDL";
            this.btnKetNoi.UseVisualStyleBackColor = false;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnBT1
            // 
            this.btnBT1.BackColor = System.Drawing.Color.White;
            this.btnBT1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBT1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnBT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBT1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBT1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnBT1.Location = new System.Drawing.Point(288, 137);
            this.btnBT1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBT1.Name = "btnBT1";
            this.btnBT1.Size = new System.Drawing.Size(346, 55);
            this.btnBT1.TabIndex = 1;
            this.btnBT1.Text = "BT1 — Stored Procedure: Tính tổng 2 số nguyên";
            this.btnBT1.UseVisualStyleBackColor = false;
            this.btnBT1.Click += new System.EventHandler(this.btnBT1_Click);
            // 
            // btnBT2
            // 
            this.btnBT2.BackColor = System.Drawing.Color.White;
            this.btnBT2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBT2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnBT2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBT2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBT2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnBT2.Location = new System.Drawing.Point(23, 231);
            this.btnBT2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBT2.Name = "btnBT2";
            this.btnBT2.Size = new System.Drawing.Size(346, 55);
            this.btnBT2.TabIndex = 2;
            this.btnBT2.Text = "BT2 — Stored Procedure: Thông tin đầu sách";
            this.btnBT2.UseVisualStyleBackColor = false;
            this.btnBT2.Click += new System.EventHandler(this.btnBT2_Click);
            // 
            // btnBT3
            // 
            this.btnBT3.BackColor = System.Drawing.Color.White;
            this.btnBT3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBT3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnBT3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBT3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBT3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnBT3.Location = new System.Drawing.Point(565, 231);
            this.btnBT3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBT3.Name = "btnBT3";
            this.btnBT3.Size = new System.Drawing.Size(346, 55);
            this.btnBT3.TabIndex = 3;
            this.btnBT3.Text = "BT3 — Function: Tính tuổi theo năm sinh";
            this.btnBT3.UseVisualStyleBackColor = false;
            this.btnBT3.Click += new System.EventHandler(this.btnBT3_Click);
            // 
            // btnBT5
            // 
            this.btnBT5.BackColor = System.Drawing.Color.White;
            this.btnBT5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBT5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnBT5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBT5.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBT5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnBT5.Location = new System.Drawing.Point(288, 344);
            this.btnBT5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBT5.Name = "btnBT5";
            this.btnBT5.Size = new System.Drawing.Size(346, 55);
            this.btnBT5.TabIndex = 5;
            this.btnBT5.Text = "BT5 — Triggers: CSDL Thư Viện";
            this.btnBT5.UseVisualStyleBackColor = false;
            this.btnBT5.Click += new System.EventHandler(this.btnBT5_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelMain.Controls.Add(this.btnKetNoi);
            this.panelMain.Controls.Add(this.btnBT1);
            this.panelMain.Controls.Add(this.btnBT2);
            this.panelMain.Controls.Add(this.btnBT3);
            this.panelMain.Controls.Add(this.btnBT5);
            this.panelMain.Controls.Add(this.lblStatus);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(933, 578);
            this.panelMain.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(933, 652);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.Button btnBT1;
        private System.Windows.Forms.Button btnBT2;
        private System.Windows.Forms.Button btnBT3;
        private System.Windows.Forms.Button btnBT5;
        private System.Windows.Forms.Panel panelMain;
    }
}