using System.Data;
using System.Data.SqlClient;

namespace SanBay
{
    public partial class Form1 : Form
    {
        private string connectionString = KetNoi.chuoiKN;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM MayBay";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maMB = tbMaMB.Text;
            string tenMB = tbTenMB.Text;
            DateTime namSX = dtpNamSX.Value;
            float soGioBay;


            if (!float.TryParse(tbSoGioBay.Text, out soGioBay))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho số giờ bay!");
                return;
            }

            string query = "INSERT INTO MayBay (MaMB, TenMB, NamSX, SoGioBay) VALUES (@MaMB, @TenMB, @NamSX, @SoGioBay)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMB", maMB);
                        cmd.Parameters.AddWithValue("@TenMB", tenMB);
                        cmd.Parameters.AddWithValue("@NamSX", namSX);
                        cmd.Parameters.AddWithValue("@SoGioBay", soGioBay);

                        
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm máy bay thành công!");
                            LoadData(); 
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi thêm dữ liệu!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
                }
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMB = tbMaMB.Text;
            string tenMB = tbTenMB.Text;
            DateTime namSX = dtpNamSX.Value;
            float soGioBay;


            if (!float.TryParse(tbSoGioBay.Text, out soGioBay))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho số giờ bay!");
                return;
            }

            string query = "UPDATE MayBay SET TenMB = @TenMB, NamSX = @NamSX, SoGioBay = @SoGioBay WHERE MaMB = @MaMB";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMB", maMB);
                        cmd.Parameters.AddWithValue("@TenMB", tenMB);
                        cmd.Parameters.AddWithValue("@NamSX", namSX);
                        cmd.Parameters.AddWithValue("@SoGioBay", soGioBay);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật máy bay thành công!");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy máy bay với mã này để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
                }
            }
        }

        private void tbMaMB_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTenMB_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNamSX_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbSoGioBay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
