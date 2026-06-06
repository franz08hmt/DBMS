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
            this.btnBT4 = new System.Windows.Forms.Button();
            this.btnBT5 = new System.Windows.Forms.Button();
            this.btnBT6 = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();

            // ── lblTitle ──────────────────────────────────────────
            this.lblTitle.AutoSize = false;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Height = 60;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lblTitle.Text = "DBMS PROJECT — Stored Procedures, Triggers & Functions";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Name = "lblTitle";

            // ── panelMain ─────────────────────────────────────────
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelMain.Name = "panelMain";
            this.panelMain.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnKetNoi,
                this.btnBT1,
                this.btnBT2,
                this.btnBT3,
                this.btnBT4,
                this.btnBT5,
                this.btnBT6,
                this.lblStatus
            });

            // ── btnKetNoi ─────────────────────────────────────────
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Text = "KẾT NỐI CSDL";
            this.btnKetNoi.Size = new System.Drawing.Size(560, 45);
            this.btnKetNoi.Location = new System.Drawing.Point(60, 30);
            this.btnKetNoi.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnKetNoi.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnKetNoi.ForeColor = System.Drawing.Color.White;
            this.btnKetNoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetNoi.FlatAppearance.BorderSize = 0;
            this.btnKetNoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);

            // ── btnBT1 ────────────────────────────────────────────
            this.btnBT1.Name = "btnBT1";
            this.btnBT1.Text = "BT1 — Stored Procedure: Tính tổng 2 số nguyên";
            this.btnBT1.Size = new System.Drawing.Size(560, 45);
            this.btnBT1.Location = new System.Drawing.Point(60, 95);
            this.btnBT1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBT1.BackColor = System.Drawing.Color.White;
            this.btnBT1.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnBT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBT1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnBT1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBT1.Click += new System.EventHandler(this.btnBT1_Click);

            // ── btnBT2 ────────────────────────────────────────────
            this.btnBT2.Name = "btnBT2";
            this.btnBT2.Text = "BT2 — Stored Procedure: Thông tin đầu sách";
            this.btnBT2.Size = new System.Drawing.Size(560, 45);
            this.btnBT2.Location = new System.Drawing.Point(60, 150);
            this.btnBT2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBT2.BackColor = System.Drawing.Color.White;
            this.btnBT2.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnBT2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBT2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnBT2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBT2.Click += new System.EventHandler(this.btnBT2_Click);

            // ── btnBT3 ────────────────────────────────────────────
            this.btnBT3.Name = "btnBT3";
            this.btnBT3.Text = "BT3 — Function: Tính tuổi theo năm sinh";
            this.btnBT3.Size = new System.Drawing.Size(560, 45);
            this.btnBT3.Location = new System.Drawing.Point(60, 205);
            this.btnBT3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBT3.BackColor = System.Drawing.Color.White;
            this.btnBT3.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnBT3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBT3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnBT3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBT3.Click += new System.EventHandler(this.btnBT3_Click);

            // ── btnBT4 ────────────────────────────────────────────
            this.btnBT4.Name = "btnBT4";
            this.btnBT4.Text = "BT4 — Stored Procedures: CSDL Thư Viện";
            this.btnBT4.Size = new System.Drawing.Size(560, 45);
            this.btnBT4.Location = new System.Drawing.Point(60, 260);
            this.btnBT4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBT4.BackColor = System.Drawing.Color.White;
            this.btnBT4.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnBT4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBT4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnBT4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBT4.Click += new System.EventHandler(this.btnBT4_Click);

            // ── btnBT5 ────────────────────────────────────────────
            this.btnBT5.Name = "btnBT5";
            this.btnBT5.Text = "BT5 — Triggers: CSDL Thư Viện";
            this.btnBT5.Size = new System.Drawing.Size(560, 45);
            this.btnBT5.Location = new System.Drawing.Point(60, 315);
            this.btnBT5.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBT5.BackColor = System.Drawing.Color.White;
            this.btnBT5.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnBT5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBT5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnBT5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBT5.Click += new System.EventHandler(this.btnBT5_Click);

            // ── btnBT6 ────────────────────────────────────────────
            this.btnBT6.Name = "btnBT6";
            this.btnBT6.Text = "BT6 — Functions: CSDL Đề Án";
            this.btnBT6.Size = new System.Drawing.Size(560, 45);
            this.btnBT6.Location = new System.Drawing.Point(60, 370);
            this.btnBT6.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBT6.BackColor = System.Drawing.Color.White;
            this.btnBT6.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnBT6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBT6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnBT6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBT6.Click += new System.EventHandler(this.btnBT6_Click);

            // ── lblStatus ─────────────────────────────────────────
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.AutoSize = false;
            this.lblStatus.Size = new System.Drawing.Size(560, 25);
            this.lblStatus.Location = new System.Drawing.Point(60, 425);
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic);
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Text = "Trạng thái: Chưa kết nối CSDL";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── frmMain ───────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 530);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblTitle);
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
        private System.Windows.Forms.Button btnBT4;
        private System.Windows.Forms.Button btnBT5;
        private System.Windows.Forms.Button btnBT6;
        private System.Windows.Forms.Panel panelMain;
    }
}