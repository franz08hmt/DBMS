using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class frmBT1 : Form
    {
        public frmBT1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSoA.Text.Trim(), out int soA))
            {
                MessageBox.Show("Vui long nhap so nguyen hop le cho So A!", "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtSoB.Text.Trim(), out int soB))
            {
                MessageBox.Show("Vui long nhap so nguyen hop le cho So B!", "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_TinhTong", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@SoA", soA);
                    cmd.Parameters.AddWithValue("@SoB", soB);

                    SqlParameter output = new SqlParameter("@KetQua", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(output);

                    cmd.ExecuteNonQuery();

                    txtKetQua.Text = output.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi ket noi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}