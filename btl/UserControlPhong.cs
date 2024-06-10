using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl
{
    public partial class UserControlPhong : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select Phong.SoPhong as N'Số phòng' , LoaiPhong.TenLoaiPhong as N'Loại phòng', LoaiPhong.DonGia as N'Đơn giá', LoaiPhong.SoNguoi as 'Số người', LoaiPhong.SoGiuong as N'Số giường' from Phong inner join LoaiPhong on Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvPhong.DataSource = table;
        }
        public UserControlPhong()
        {
            InitializeComponent();
        }
        private void UserControlPhong_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }
        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvPhong.CurrentRow.Index;
            txtSoPhong.Text = dgvPhong.Rows[i].Cells[0].Value.ToString();
            cbLoaiPhong.Text = dgvPhong.Rows[i].Cells[1].Value.ToString();
            txtDG.Text = dgvPhong.Rows[i].Cells[2].Value.ToString();
            txtSoNguoi.Text = dgvPhong.Rows[i].Cells[3].Value.ToString();
            txtSoGiuong.Text = dgvPhong.Rows[i].Cells[4].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Search(txtTimKiem.Text);
        }
        private void Search(string keyword)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = $"CONVERT(SoPhong, 'System.String') LIKE '%{keyword}%' OR TenLoaiPhong LIKE '%{keyword}%' OR CONVERT(DonGia, 'System.String') LIKE '%{keyword}%' OR CONVERT(SoNguoi, 'System.String') LIKE '%{keyword}%' OR CONVERT(SoGiuong, 'System.String') LIKE '%{keyword}%'";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maLoaiPhong = GetMaLoaiPhongByTenLoaiPhong(cbLoaiPhong.Text);
                if (string.IsNullOrEmpty(maLoaiPhong))
                {
                    MessageBox.Show("Không tìm thấy mã loại phòng cho tên loại phòng: " + cbLoaiPhong.Text, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Phong (SoPhong, TrangThai, MaKH, MaDat, MaLoaiPhong) VALUES (@SoPhong, N'Trống',NULL, NULL, @MaLoaiPhong)";

                // Sử dụng tham số để tránh lỗi SQL injection
                command.Parameters.AddWithValue("@SoPhong", txtSoPhong.Text);
                command.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);

                command.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetMaLoaiPhongByTenLoaiPhong(string tenLoaiPhong)
        {
            string maLoaiPhong = null;
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT MaLoaiPhong FROM LoaiPhong WHERE TenLoaiPhong = @TenLoaiPhong";
                cmd.Parameters.AddWithValue("@TenLoaiPhong", tenLoaiPhong);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    maLoaiPhong = reader["MaLoaiPhong"].ToString();
                }
            }

            return maLoaiPhong;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string  soPhong = txtSoPhong.Text;
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Phong WHERE SoPhong = @SoPhong";

                // Sử dụng tham số để tránh lỗi SQL injection
                command.Parameters.AddWithValue("@SoPhong", soPhong);

                command.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string soPhong = txtSoPhong.Text;
                string tenLoaiPhong = cbLoaiPhong.Text;
                string maLoaiPhong = GetMaLoaiPhongByTenLoaiPhong(tenLoaiPhong);
                int  donGia = GetDonGiaByMaLoaiPhong(maLoaiPhong);
                command = connection.CreateCommand();
                command.CommandText = "UPDATE Phong SET  MaLoaiPhong = @MaLoaiPhong WHERE SoPhong = @SoPhong";
                command.Parameters.AddWithValue("@SoPhong", soPhong);
                command.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);

                command.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int  GetDonGiaByMaLoaiPhong(string maLoaiPhong)
        {
            int donGia = 0;
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT DonGia FROM LoaiPhong WHERE MaLoaiPhong = @MaLoaiPhong";
                cmd.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["DonGia"] != DBNull.Value)
                    {
                        donGia = reader.GetInt32(reader.GetOrdinal("DonGia"));
                    }
                    else
                    {
                        MessageBox.Show("Giá trị đơn giá không hợp lệ hoặc là NULL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return donGia;
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenLoaiPhong = cbLoaiPhong.Text;
            string maLoaiPhong = GetMaLoaiPhongByTenLoaiPhong(tenLoaiPhong);
            int donGia = GetDonGiaByMaLoaiPhong(maLoaiPhong);
            txtDG.Text = donGia.ToString();
        }
    }
}
