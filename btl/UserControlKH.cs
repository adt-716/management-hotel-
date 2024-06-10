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
    public partial class UserControlKH : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select MaKH as 'Mã khách hàng', TenKH as N'Tên khách hàng'," +
                "GT as N'Giới tính',CCCD , SDT,DiaChi as N'Địa chỉ', QuocTich as N'Quốc tịch'  from KH";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvKH.DataSource = table;
        }
        public UserControlKH()
        {
            InitializeComponent();
        }

        private void UserControlKH_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKH.CurrentRow.Index;
            txtMaKh.Text = dgvKH.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvKH.Rows[i].Cells[1].Value.ToString();
            cbGT.Text = dgvKH.Rows[i].Cells[2].Value.ToString();
            txtSDT.Text = dgvKH.Rows[i].Cells[3].Value.ToString();
            txtCCCD.Text = dgvKH.Rows[i].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvKH.Rows[i].Cells[5].Value.ToString();
            cbQuocTich.Text = dgvKH.Rows[i].Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into KH values(N'" + txtMaKh.Text + "',N'" + txtHoTen.Text + "',N'" + cbGT.Text + "', N'" 
                + txtSDT.Text + "', N'" + txtCCCD.Text + "', N'" + txtDiaChi.Text + "',N'" + cbQuocTich.Text + "' )";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (CanDeleteRecord(txtMaKh.Text))
                {
                    command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM KH WHERE MaKH = @MaKH";
                    command.Parameters.AddWithValue("@MaKH", txtMaKh.Text);

                    command.ExecuteNonQuery();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Không thể xóa khách hàng do có quan hệ khóa ngoại với bảng Đặt phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CanDeleteRecord(string maKhachHang)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM DatPhong WHERE MaKH = @MaKH";
                command.Parameters.AddWithValue("@MaKH", maKhachHang);

                int count = (int)command.ExecuteScalar();

                return count == 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra quan hệ khóa ngoại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Trả về false nếu có lỗi trong quá trình kiểm tra
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command = connection.CreateCommand();
            command.CommandText = "UPDATE KH SET TenKH = @TenKH, GT = @GT, SDT = @SDT, CCCD = @CCCD, DiaChi = @DiaChi, QuocTich = @QuocTich WHERE MaKH = @MaKH";

            // Add parameters
            command.Parameters.AddWithValue("@TenKH", txtHoTen.Text);
            command.Parameters.AddWithValue("@GT", cbGT.Text);
            command.Parameters.AddWithValue("@SDT", txtSDT.Text);
            command.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
            command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            command.Parameters.AddWithValue("@QuocTich", cbQuocTich.Text);
            command.Parameters.AddWithValue("@MaKH", txtMaKh.Text);

            command.ExecuteNonQuery();
            loadData();
        }
        
        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Search(txtTimKiem.Text);
        }
        private void Search(string keyword)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = $"MaKH LIKE '%{keyword}%' OR TenKH LIKE '%{keyword}%' OR GT LIKE '%{keyword}%' OR CONVERT(SDT, 'System.String') LIKE '%{keyword}%' OR CONVERT(CCCD, 'System.String') LIKE '%{keyword}%' OR DiaChi LIKE '%{keyword}%' OR QuocTich LIKE '%{keyword}%'";
        }
    }
}
