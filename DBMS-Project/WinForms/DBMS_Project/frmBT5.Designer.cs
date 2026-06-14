namespace DBMS_Project
{
    partial class frmBT5
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaDocGia_Ins = new System.Windows.Forms.TextBox();
            this.txtMaCuon_Ins = new System.Windows.Forms.TextBox();
            this.txtISBN_Ins = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsMuon = new System.Windows.Forms.Button();
            this.lblISBN = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaDocGia_Del = new System.Windows.Forms.TextBox();
            this.txtMaCuon_Del = new System.Windows.Forms.TextBox();
            this.txtISBN_Del = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelMuon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTinhTrang_Upd = new System.Windows.Forms.TextBox();
            this.txtMaCuon_Upd = new System.Windows.Forms.TextBox();
            this.txtISBN_Upd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdCuonSach = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenTuaSach = new System.Windows.Forms.TextBox();
            this.txtMaTuaSach = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnInfThongBao = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(940, 55);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "BT5 — Triggers: CSDL Thư Viện";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaDocGia_Ins);
            this.panel1.Controls.Add(this.txtMaCuon_Ins);
            this.panel1.Controls.Add(this.txtISBN_Ins);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnInsMuon);
            this.panel1.Controls.Add(this.lblISBN);
            this.panel1.Location = new System.Drawing.Point(69, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 144);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã độc giả";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã cuốn";
            // 
            // txtMaDocGia_Ins
            // 
            this.txtMaDocGia_Ins.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaDocGia_Ins.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDocGia_Ins.Location = new System.Drawing.Point(256, 77);
            this.txtMaDocGia_Ins.Name = "txtMaDocGia_Ins";
            this.txtMaDocGia_Ins.Size = new System.Drawing.Size(100, 27);
            this.txtMaDocGia_Ins.TabIndex = 10;
            // 
            // txtMaCuon_Ins
            // 
            this.txtMaCuon_Ins.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaCuon_Ins.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCuon_Ins.Location = new System.Drawing.Point(132, 77);
            this.txtMaCuon_Ins.Name = "txtMaCuon_Ins";
            this.txtMaCuon_Ins.Size = new System.Drawing.Size(100, 27);
            this.txtMaCuon_Ins.TabIndex = 9;
            // 
            // txtISBN_Ins
            // 
            this.txtISBN_Ins.BackColor = System.Drawing.SystemColors.Control;
            this.txtISBN_Ins.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN_Ins.Location = new System.Drawing.Point(18, 75);
            this.txtISBN_Ins.Name = "txtISBN_Ins";
            this.txtISBN_Ins.Size = new System.Drawing.Size(100, 27);
            this.txtISBN_Ins.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "ISBN";
            // 
            // btnInsMuon
            // 
            this.btnInsMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.btnInsMuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsMuon.FlatAppearance.BorderSize = 0;
            this.btnInsMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsMuon.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnInsMuon.ForeColor = System.Drawing.Color.White;
            this.btnInsMuon.Location = new System.Drawing.Point(3, 114);
            this.btnInsMuon.Name = "btnInsMuon";
            this.btnInsMuon.Size = new System.Drawing.Size(370, 30);
            this.btnInsMuon.TabIndex = 5;
            this.btnInsMuon.Text = "Thêm mượn";
            this.btnInsMuon.UseVisualStyleBackColor = false;
            this.btnInsMuon.Click += new System.EventHandler(this.btnInsMuon_Click);
            // 
            // lblISBN
            // 
            this.lblISBN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblISBN.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblISBN.Location = new System.Drawing.Point(3, 9);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(353, 28);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "Trigger 1: Thêm phiếu mượn mới";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(63, 505);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersWidth = 51;
            this.dgvKetQua.RowTemplate.Height = 24;
            this.dgvKetQua.Size = new System.Drawing.Size(810, 135);
            this.dgvKetQua.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtMaDocGia_Del);
            this.panel2.Controls.Add(this.txtMaCuon_Del);
            this.panel2.Controls.Add(this.txtISBN_Del);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnDelMuon);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(503, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 144);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã độc giả";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(132, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã cuốn";
            // 
            // txtMaDocGia_Del
            // 
            this.txtMaDocGia_Del.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaDocGia_Del.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDocGia_Del.Location = new System.Drawing.Point(256, 77);
            this.txtMaDocGia_Del.Name = "txtMaDocGia_Del";
            this.txtMaDocGia_Del.Size = new System.Drawing.Size(100, 27);
            this.txtMaDocGia_Del.TabIndex = 10;
            // 
            // txtMaCuon_Del
            // 
            this.txtMaCuon_Del.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaCuon_Del.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCuon_Del.Location = new System.Drawing.Point(135, 77);
            this.txtMaCuon_Del.Name = "txtMaCuon_Del";
            this.txtMaCuon_Del.Size = new System.Drawing.Size(100, 27);
            this.txtMaCuon_Del.TabIndex = 9;
            // 
            // txtISBN_Del
            // 
            this.txtISBN_Del.BackColor = System.Drawing.SystemColors.Control;
            this.txtISBN_Del.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN_Del.Location = new System.Drawing.Point(18, 77);
            this.txtISBN_Del.Name = "txtISBN_Del";
            this.txtISBN_Del.Size = new System.Drawing.Size(100, 27);
            this.txtISBN_Del.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "ISBN";
            // 
            // btnDelMuon
            // 
            this.btnDelMuon.BackColor = System.Drawing.Color.Red;
            this.btnDelMuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelMuon.FlatAppearance.BorderSize = 0;
            this.btnDelMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelMuon.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelMuon.ForeColor = System.Drawing.Color.White;
            this.btnDelMuon.Location = new System.Drawing.Point(3, 114);
            this.btnDelMuon.Name = "btnDelMuon";
            this.btnDelMuon.Size = new System.Drawing.Size(370, 30);
            this.btnDelMuon.TabIndex = 5;
            this.btnDelMuon.Text = "Xóa mượn";
            this.btnDelMuon.UseVisualStyleBackColor = false;
            this.btnDelMuon.Click += new System.EventHandler(this.btnDelMuon_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(353, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "Trigger 2: Xóa phiếu mượn";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtTinhTrang_Upd);
            this.panel3.Controls.Add(this.txtMaCuon_Upd);
            this.panel3.Controls.Add(this.txtISBN_Upd);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnUpdCuonSach);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(72, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 144);
            this.panel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã cuốn";
            // 
            // txtTinhTrang_Upd
            // 
            this.txtTinhTrang_Upd.BackColor = System.Drawing.SystemColors.Control;
            this.txtTinhTrang_Upd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang_Upd.Location = new System.Drawing.Point(256, 77);
            this.txtTinhTrang_Upd.Name = "txtTinhTrang_Upd";
            this.txtTinhTrang_Upd.Size = new System.Drawing.Size(100, 27);
            this.txtTinhTrang_Upd.TabIndex = 10;
            // 
            // txtMaCuon_Upd
            // 
            this.txtMaCuon_Upd.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaCuon_Upd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCuon_Upd.Location = new System.Drawing.Point(132, 77);
            this.txtMaCuon_Upd.Name = "txtMaCuon_Upd";
            this.txtMaCuon_Upd.Size = new System.Drawing.Size(100, 27);
            this.txtMaCuon_Upd.TabIndex = 9;
            // 
            // txtISBN_Upd
            // 
            this.txtISBN_Upd.BackColor = System.Drawing.SystemColors.Control;
            this.txtISBN_Upd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN_Upd.Location = new System.Drawing.Point(18, 75);
            this.txtISBN_Upd.Name = "txtISBN_Upd";
            this.txtISBN_Upd.Size = new System.Drawing.Size(100, 27);
            this.txtISBN_Upd.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 28);
            this.label10.TabIndex = 4;
            this.label10.Text = "ISBN";
            // 
            // btnUpdCuonSach
            // 
            this.btnUpdCuonSach.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnUpdCuonSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdCuonSach.FlatAppearance.BorderSize = 0;
            this.btnUpdCuonSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdCuonSach.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdCuonSach.ForeColor = System.Drawing.Color.White;
            this.btnUpdCuonSach.Location = new System.Drawing.Point(3, 114);
            this.btnUpdCuonSach.Name = "btnUpdCuonSach";
            this.btnUpdCuonSach.Size = new System.Drawing.Size(370, 30);
            this.btnUpdCuonSach.TabIndex = 5;
            this.btnUpdCuonSach.Text = "Cập nhật";
            this.btnUpdCuonSach.UseVisualStyleBackColor = false;
            this.btnUpdCuonSach.Click += new System.EventHandler(this.btnUpdCuonSach_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(353, 28);
            this.label11.TabIndex = 2;
            this.label11.Text = "Trigger 3: Cập nhật tình trạng cuốn sách";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtTacGia);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtTenTuaSach);
            this.panel4.Controls.Add(this.txtMaTuaSach);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.btnInfThongBao);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(500, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 250);
            this.panel4.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 28);
            this.label13.TabIndex = 11;
            this.label13.Text = "Tên tựa sách mới";
            // 
            // txtTenTuaSach
            // 
            this.txtTenTuaSach.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenTuaSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTuaSach.Location = new System.Drawing.Point(18, 114);
            this.txtTenTuaSach.Name = "txtTenTuaSach";
            this.txtTenTuaSach.Size = new System.Drawing.Size(338, 27);
            this.txtTenTuaSach.TabIndex = 9;
            // 
            // txtMaTuaSach
            // 
            this.txtMaTuaSach.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaTuaSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTuaSach.Location = new System.Drawing.Point(18, 58);
            this.txtMaTuaSach.Name = "txtMaTuaSach";
            this.txtMaTuaSach.Size = new System.Drawing.Size(338, 27);
            this.txtMaTuaSach.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 28);
            this.label14.TabIndex = 4;
            this.label14.Text = "Mã tựa sách";
            // 
            // btnInfThongBao
            // 
            this.btnInfThongBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInfThongBao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfThongBao.FlatAppearance.BorderSize = 0;
            this.btnInfThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfThongBao.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnInfThongBao.ForeColor = System.Drawing.Color.White;
            this.btnInfThongBao.Location = new System.Drawing.Point(3, 217);
            this.btnInfThongBao.Name = "btnInfThongBao";
            this.btnInfThongBao.Size = new System.Drawing.Size(370, 30);
            this.btnInfThongBao.TabIndex = 5;
            this.btnInfThongBao.Text = "Thêm/Sửa";
            this.btnInfThongBao.UseVisualStyleBackColor = false;
            this.btnInfThongBao.Click += new System.EventHandler(this.btnInfThongBao_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(353, 28);
            this.label15.TabIndex = 2;
            this.label15.Text = "Trigger 4: Thêm/sửa tựa sách";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnQuayLai.Location = new System.Drawing.Point(63, 646);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(100, 35);
            this.btnQuayLai.TabIndex = 15;
            this.btnQuayLai.Text = "Quay lai";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 28);
            this.label12.TabIndex = 13;
            this.label12.Text = "Tác giả";
            // 
            // txtTacGia
            // 
            this.txtTacGia.BackColor = System.Drawing.SystemColors.Control;
            this.txtTacGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(18, 175);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(338, 27);
            this.txtTacGia.TabIndex = 12;
            // 
            // frmBT5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 691);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmBT5";
            this.Text = "frmBT5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsMuon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaDocGia_Ins;
        private System.Windows.Forms.TextBox txtMaCuon_Ins;
        private System.Windows.Forms.TextBox txtISBN_Ins;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaDocGia_Del;
        private System.Windows.Forms.TextBox txtMaCuon_Del;
        private System.Windows.Forms.TextBox txtISBN_Del;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelMuon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTinhTrang_Upd;
        private System.Windows.Forms.TextBox txtMaCuon_Upd;
        private System.Windows.Forms.TextBox txtISBN_Upd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdCuonSach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenTuaSach;
        private System.Windows.Forms.TextBox txtMaTuaSach;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnInfThongBao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTacGia;
    }
}