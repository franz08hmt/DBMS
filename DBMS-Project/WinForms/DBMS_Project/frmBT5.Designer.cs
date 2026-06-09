namespace DBMS_Project
{
    partial class frmBT5
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
            this.grpIns = new System.Windows.Forms.GroupBox();
            this.lblInsISBN = new System.Windows.Forms.Label();
            this.txtInsISBN = new System.Windows.Forms.TextBox();
            this.lblInsCS = new System.Windows.Forms.Label();
            this.txtInsCS = new System.Windows.Forms.TextBox();
            this.lblInsDG = new System.Windows.Forms.Label();
            this.txtInsDG = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.grpDel = new System.Windows.Forms.GroupBox();
            this.lblDelISBN = new System.Windows.Forms.Label();
            this.txtDelISBN = new System.Windows.Forms.TextBox();
            this.lblDelCS = new System.Windows.Forms.Label();
            this.txtDelCS = new System.Windows.Forms.TextBox();
            this.lblDelDG = new System.Windows.Forms.Label();
            this.txtDelDG = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpUpd = new System.Windows.Forms.GroupBox();
            this.lblUpdISBN = new System.Windows.Forms.Label();
            this.txtUpdISBN = new System.Windows.Forms.TextBox();
            this.lblUpdCS = new System.Windows.Forms.Label();
            this.txtUpdCS = new System.Windows.Forms.TextBox();
            this.lblUpdTT = new System.Windows.Forms.Label();
            this.cmbUpdTT = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpThongBao = new System.Windows.Forms.GroupBox();
            this.lblTBMa = new System.Windows.Forms.Label();
            this.txtTBMa = new System.Windows.Forms.TextBox();
            this.lblTBTen = new System.Windows.Forms.Label();
            this.txtTBTen = new System.Windows.Forms.TextBox();
            this.btnTBInsert = new System.Windows.Forms.Button();
            this.btnTBUpdate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.grpIns.SuspendLayout();
            this.grpDel.SuspendLayout();
            this.grpUpd.SuspendLayout();
            this.grpThongBao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(760, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BT5 — Triggers: CSDL Thu Vien";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpIns
            // 
            this.grpIns.Controls.Add(this.lblInsISBN);
            this.grpIns.Controls.Add(this.txtInsISBN);
            this.grpIns.Controls.Add(this.lblInsCS);
            this.grpIns.Controls.Add(this.txtInsCS);
            this.grpIns.Controls.Add(this.lblInsDG);
            this.grpIns.Controls.Add(this.txtInsDG);
            this.grpIns.Controls.Add(this.btnInsert);
            this.grpIns.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.grpIns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.grpIns.Location = new System.Drawing.Point(12, 62);
            this.grpIns.Name = "grpIns";
            this.grpIns.Size = new System.Drawing.Size(360, 110);
            this.grpIns.TabIndex = 1;
            this.grpIns.TabStop = false;
            this.grpIns.Text = "tg_insMuon — AFTER INSERT (them phieu muon)";
            // 
            // lblInsISBN
            // 
            this.lblInsISBN.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblInsISBN.Location = new System.Drawing.Point(8, 24);
            this.lblInsISBN.Name = "lblInsISBN";
            this.lblInsISBN.Size = new System.Drawing.Size(50, 20);
            this.lblInsISBN.TabIndex = 0;
            this.lblInsISBN.Text = "ISBN:";
            // 
            // txtInsISBN
            // 
            this.txtInsISBN.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtInsISBN.Location = new System.Drawing.Point(60, 22);
            this.txtInsISBN.Name = "txtInsISBN";
            this.txtInsISBN.Size = new System.Drawing.Size(85, 28);
            this.txtInsISBN.TabIndex = 1;
            this.txtInsISBN.Text = "ISBN004";
            // 
            // lblInsCS
            // 
            this.lblInsCS.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblInsCS.Location = new System.Drawing.Point(155, 24);
            this.lblInsCS.Name = "lblInsCS";
            this.lblInsCS.Size = new System.Drawing.Size(60, 20);
            this.lblInsCS.TabIndex = 2;
            this.lblInsCS.Text = "Ma cuon:";
            // 
            // txtInsCS
            // 
            this.txtInsCS.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtInsCS.Location = new System.Drawing.Point(218, 22);
            this.txtInsCS.Name = "txtInsCS";
            this.txtInsCS.Size = new System.Drawing.Size(60, 28);
            this.txtInsCS.TabIndex = 3;
            this.txtInsCS.Text = "CS001";
            // 
            // lblInsDG
            // 
            this.lblInsDG.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblInsDG.Location = new System.Drawing.Point(8, 54);
            this.lblInsDG.Name = "lblInsDG";
            this.lblInsDG.Size = new System.Drawing.Size(70, 20);
            this.lblInsDG.TabIndex = 4;
            this.lblInsDG.Text = "Ma doc gia:";
            // 
            // txtInsDG
            // 
            this.txtInsDG.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtInsDG.Location = new System.Drawing.Point(80, 52);
            this.txtInsDG.Name = "txtInsDG";
            this.txtInsDG.Size = new System.Drawing.Size(85, 28);
            this.txtInsDG.TabIndex = 5;
            this.txtInsDG.Text = "DG005";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(8, 80);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(340, 26);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "THEM MUON (INSERT)";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // grpDel
            // 
            this.grpDel.Controls.Add(this.lblDelISBN);
            this.grpDel.Controls.Add(this.txtDelISBN);
            this.grpDel.Controls.Add(this.lblDelCS);
            this.grpDel.Controls.Add(this.txtDelCS);
            this.grpDel.Controls.Add(this.lblDelDG);
            this.grpDel.Controls.Add(this.txtDelDG);
            this.grpDel.Controls.Add(this.btnDelete);
            this.grpDel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.grpDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.grpDel.Location = new System.Drawing.Point(12, 182);
            this.grpDel.Name = "grpDel";
            this.grpDel.Size = new System.Drawing.Size(360, 110);
            this.grpDel.TabIndex = 2;
            this.grpDel.TabStop = false;
            this.grpDel.Text = "tg_delMuon — AFTER DELETE (xoa phieu muon / tra sach)";
            // 
            // lblDelISBN
            // 
            this.lblDelISBN.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblDelISBN.Location = new System.Drawing.Point(8, 24);
            this.lblDelISBN.Name = "lblDelISBN";
            this.lblDelISBN.Size = new System.Drawing.Size(50, 20);
            this.lblDelISBN.TabIndex = 0;
            this.lblDelISBN.Text = "ISBN:";
            // 
            // txtDelISBN
            // 
            this.txtDelISBN.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtDelISBN.Location = new System.Drawing.Point(80, 21);
            this.txtDelISBN.Name = "txtDelISBN";
            this.txtDelISBN.Size = new System.Drawing.Size(85, 28);
            this.txtDelISBN.TabIndex = 1;
            this.txtDelISBN.Text = "ISBN004";
            // 
            // lblDelCS
            // 
            this.lblDelCS.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblDelCS.Location = new System.Drawing.Point(186, 24);
            this.lblDelCS.Name = "lblDelCS";
            this.lblDelCS.Size = new System.Drawing.Size(60, 20);
            this.lblDelCS.TabIndex = 2;
            this.lblDelCS.Text = "Ma cuon:";
            // 
            // txtDelCS
            // 
            this.txtDelCS.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtDelCS.Location = new System.Drawing.Point(252, 22);
            this.txtDelCS.Name = "txtDelCS";
            this.txtDelCS.Size = new System.Drawing.Size(60, 28);
            this.txtDelCS.TabIndex = 3;
            this.txtDelCS.Text = "CS001";
            // 
            // lblDelDG
            // 
            this.lblDelDG.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblDelDG.Location = new System.Drawing.Point(8, 54);
            this.lblDelDG.Name = "lblDelDG";
            this.lblDelDG.Size = new System.Drawing.Size(70, 20);
            this.lblDelDG.TabIndex = 4;
            this.lblDelDG.Text = "Ma doc gia:";
            // 
            // txtDelDG
            // 
            this.txtDelDG.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtDelDG.Location = new System.Drawing.Point(80, 52);
            this.txtDelDG.Name = "txtDelDG";
            this.txtDelDG.Size = new System.Drawing.Size(85, 28);
            this.txtDelDG.TabIndex = 5;
            this.txtDelDG.Text = "DG005";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(8, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(340, 26);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "XOA MUON (DELETE)";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpUpd
            // 
            this.grpUpd.Controls.Add(this.lblUpdISBN);
            this.grpUpd.Controls.Add(this.txtUpdISBN);
            this.grpUpd.Controls.Add(this.lblUpdCS);
            this.grpUpd.Controls.Add(this.txtUpdCS);
            this.grpUpd.Controls.Add(this.lblUpdTT);
            this.grpUpd.Controls.Add(this.cmbUpdTT);
            this.grpUpd.Controls.Add(this.btnUpdate);
            this.grpUpd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.grpUpd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(86)))));
            this.grpUpd.Location = new System.Drawing.Point(388, 62);
            this.grpUpd.Name = "grpUpd";
            this.grpUpd.Size = new System.Drawing.Size(360, 110);
            this.grpUpd.TabIndex = 3;
            this.grpUpd.TabStop = false;
            this.grpUpd.Text = "tg_updCuonSach — AFTER UPDATE (cap nhat tinh trang)";
            // 
            // lblUpdISBN
            // 
            this.lblUpdISBN.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblUpdISBN.Location = new System.Drawing.Point(8, 24);
            this.lblUpdISBN.Name = "lblUpdISBN";
            this.lblUpdISBN.Size = new System.Drawing.Size(50, 20);
            this.lblUpdISBN.TabIndex = 0;
            this.lblUpdISBN.Text = "ISBN:";
            // 
            // txtUpdISBN
            // 
            this.txtUpdISBN.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtUpdISBN.Location = new System.Drawing.Point(60, 22);
            this.txtUpdISBN.Name = "txtUpdISBN";
            this.txtUpdISBN.Size = new System.Drawing.Size(85, 28);
            this.txtUpdISBN.TabIndex = 1;
            this.txtUpdISBN.Text = "ISBN004";
            // 
            // lblUpdCS
            // 
            this.lblUpdCS.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblUpdCS.Location = new System.Drawing.Point(155, 24);
            this.lblUpdCS.Name = "lblUpdCS";
            this.lblUpdCS.Size = new System.Drawing.Size(60, 20);
            this.lblUpdCS.TabIndex = 2;
            this.lblUpdCS.Text = "Ma cuon:";
            // 
            // txtUpdCS
            // 
            this.txtUpdCS.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtUpdCS.Location = new System.Drawing.Point(218, 22);
            this.txtUpdCS.Name = "txtUpdCS";
            this.txtUpdCS.Size = new System.Drawing.Size(60, 28);
            this.txtUpdCS.TabIndex = 3;
            this.txtUpdCS.Text = "CS002";
            // 
            // lblUpdTT
            // 
            this.lblUpdTT.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblUpdTT.Location = new System.Drawing.Point(8, 54);
            this.lblUpdTT.Name = "lblUpdTT";
            this.lblUpdTT.Size = new System.Drawing.Size(70, 20);
            this.lblUpdTT.TabIndex = 4;
            this.lblUpdTT.Text = "Tinh trang:";
            // 
            // cmbUpdTT
            // 
            this.cmbUpdTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdTT.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbUpdTT.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.cmbUpdTT.Location = new System.Drawing.Point(80, 52);
            this.cmbUpdTT.Name = "cmbUpdTT";
            this.cmbUpdTT.Size = new System.Drawing.Size(80, 28);
            this.cmbUpdTT.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(86)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(8, 80);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(340, 26);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "CAP NHAT (UPDATE)";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpThongBao
            // 
            this.grpThongBao.Controls.Add(this.lblTBMa);
            this.grpThongBao.Controls.Add(this.txtTBMa);
            this.grpThongBao.Controls.Add(this.lblTBTen);
            this.grpThongBao.Controls.Add(this.txtTBTen);
            this.grpThongBao.Controls.Add(this.btnTBInsert);
            this.grpThongBao.Controls.Add(this.btnTBUpdate);
            this.grpThongBao.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.grpThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.grpThongBao.Location = new System.Drawing.Point(388, 182);
            this.grpThongBao.Name = "grpThongBao";
            this.grpThongBao.Size = new System.Drawing.Size(360, 110);
            this.grpThongBao.TabIndex = 4;
            this.grpThongBao.TabStop = false;
            this.grpThongBao.Text = "tg_InfThongBao — AFTER INSERT/UPDATE (thong bao tuasach)";
            // 
            // lblTBMa
            // 
            this.lblTBMa.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblTBMa.Location = new System.Drawing.Point(8, 24);
            this.lblTBMa.Name = "lblTBMa";
            this.lblTBMa.Size = new System.Drawing.Size(75, 20);
            this.lblTBMa.TabIndex = 0;
            this.lblTBMa.Text = "Ma tua sach:";
            // 
            // txtTBMa
            // 
            this.txtTBMa.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtTBMa.Location = new System.Drawing.Point(86, 22);
            this.txtTBMa.Name = "txtTBMa";
            this.txtTBMa.Size = new System.Drawing.Size(80, 28);
            this.txtTBMa.TabIndex = 1;
            this.txtTBMa.Text = "TS005";
            // 
            // lblTBTen
            // 
            this.lblTBTen.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblTBTen.Location = new System.Drawing.Point(8, 52);
            this.lblTBTen.Name = "lblTBTen";
            this.lblTBTen.Size = new System.Drawing.Size(78, 20);
            this.lblTBTen.TabIndex = 2;
            this.lblTBTen.Text = "Ten tua sach:";
            // 
            // txtTBTen
            // 
            this.txtTBTen.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtTBTen.Location = new System.Drawing.Point(86, 50);
            this.txtTBTen.Name = "txtTBTen";
            this.txtTBTen.Size = new System.Drawing.Size(262, 28);
            this.txtTBTen.TabIndex = 3;
            this.txtTBTen.Text = "Tri tue nhan tao";
            // 
            // btnTBInsert
            // 
            this.btnTBInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnTBInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTBInsert.FlatAppearance.BorderSize = 0;
            this.btnTBInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTBInsert.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnTBInsert.ForeColor = System.Drawing.Color.White;
            this.btnTBInsert.Location = new System.Drawing.Point(8, 80);
            this.btnTBInsert.Name = "btnTBInsert";
            this.btnTBInsert.Size = new System.Drawing.Size(165, 26);
            this.btnTBInsert.TabIndex = 4;
            this.btnTBInsert.Text = "INSERT";
            this.btnTBInsert.UseVisualStyleBackColor = false;
            this.btnTBInsert.Click += new System.EventHandler(this.btnTBInsert_Click);
            // 
            // btnTBUpdate
            // 
            this.btnTBUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnTBUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTBUpdate.FlatAppearance.BorderSize = 0;
            this.btnTBUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTBUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnTBUpdate.ForeColor = System.Drawing.Color.White;
            this.btnTBUpdate.Location = new System.Drawing.Point(183, 80);
            this.btnTBUpdate.Name = "btnTBUpdate";
            this.btnTBUpdate.Size = new System.Drawing.Size(165, 26);
            this.btnTBUpdate.TabIndex = 5;
            this.btnTBUpdate.Text = "UPDATE";
            this.btnTBUpdate.UseVisualStyleBackColor = false;
            this.btnTBUpdate.Click += new System.EventHandler(this.btnTBUpdate_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.lblResult.Location = new System.Drawing.Point(12, 305);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(280, 22);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Ket qua / Thong bao Trigger:";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.txtResult.Font = new System.Drawing.Font("Courier New", 9F);
            this.txtResult.Location = new System.Drawing.Point(12, 330);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(736, 120);
            this.txtResult.TabIndex = 6;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnQuayLai.Location = new System.Drawing.Point(12, 462);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(100, 32);
            this.btnQuayLai.TabIndex = 7;
            this.btnQuayLai.Text = "Quay lai";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // frmBT5
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 510);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpIns);
            this.Controls.Add(this.grpDel);
            this.Controls.Add(this.grpUpd);
            this.Controls.Add(this.grpThongBao);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnQuayLai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBT5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BT5 - Triggers";
            this.grpIns.ResumeLayout(false);
            this.grpIns.PerformLayout();
            this.grpDel.ResumeLayout(false);
            this.grpDel.PerformLayout();
            this.grpUpd.ResumeLayout(false);
            this.grpUpd.PerformLayout();
            this.grpThongBao.ResumeLayout(false);
            this.grpThongBao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpIns;
        private System.Windows.Forms.Label lblInsISBN, lblInsCS, lblInsDG;
        private System.Windows.Forms.TextBox txtInsISBN, txtInsCS, txtInsDG;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox grpDel;
        private System.Windows.Forms.Label lblDelISBN, lblDelCS, lblDelDG;
        private System.Windows.Forms.TextBox txtDelISBN, txtDelCS, txtDelDG;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpUpd;
        private System.Windows.Forms.Label lblUpdISBN, lblUpdCS, lblUpdTT;
        private System.Windows.Forms.TextBox txtUpdISBN, txtUpdCS;
        private System.Windows.Forms.ComboBox cmbUpdTT;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpThongBao;
        private System.Windows.Forms.Label lblTBMa, lblTBTen;
        private System.Windows.Forms.TextBox txtTBMa, txtTBTen;
        private System.Windows.Forms.Button btnTBInsert, btnTBUpdate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnQuayLai;
    }
}