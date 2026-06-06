using System;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class frmBT4 : Form
    {
        public frmBT4()
        {
            InitializeComponent();
            this.Text = "BT4 - Thu Vien SP";
            this.Size = new System.Drawing.Size(480, 380);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;

            var lblTitle = new Label
            {
                Text = "BT4 — Stored Procedures: CSDL Thu Vien",
                Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.FromArgb(31, 78, 121),
                Dock = DockStyle.Top,
                Height = 55,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };

            var btnQuayLai = new Button
            {
                Text = "Quay lai",
                Font = new System.Drawing.Font("Times New Roman", 10F),
                Location = new System.Drawing.Point(30, 80),
                Size = new System.Drawing.Size(100, 35),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnQuayLai.Click += (s, ev) => this.Close();

            this.Controls.AddRange(new Control[] { lblTitle, btnQuayLai });
        }
    }
}