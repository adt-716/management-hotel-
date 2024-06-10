using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web.Caching;
using System.Drawing.Imaging;
using System.Configuration;


namespace btl
{
    public partial class UserControlNhanVien : UserControl
    {

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select MaNV as 'Mã nhân viên', TenNV as N'Tên nhân viên', " +
                " GT as N'Giới tính',ChucDanh as 'Chức vụ' , SDT ,DiaChi as N'Địa chỉ', Email, TK as 'Tài khoản'  from NV";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvNhanVien.DataSource = table;
        }

        public UserControlNhanVien()
        {
            InitializeComponent();
        }
        
        private void UserControlNhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txtNhanVien.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            cbGT.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            cbChucVu.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into NV values (N'" + txtNhanVien.Text + "',N'" + txtHoTen.Text + "',N'" + cbGT.Text + "'," +
                " N'" + cbChucVu.Text + "', N'" + txtSDT.Text + "', N'" + txtDiaChi.Text + "',N'" + txtEmail.Text + "', NULL )";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE NV SET TenNV = @TenNV, GT = @GT, ChucDanh = @ChucVu, SDT = @SDT, DiaChi = @DiaChi, Email = @Email WHERE MaNV = @MaNV";

            // Add parameters
            command.Parameters.AddWithValue("@TenNV", txtHoTen.Text);
            command.Parameters.AddWithValue("@GT", cbGT.Text);
            command.Parameters.AddWithValue("@ChucVu", cbChucVu.Text);
            command.Parameters.AddWithValue("@SDT", txtSDT.Text);
            command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            command.Parameters.AddWithValue("@Email", txtEmail.Text);
            command.Parameters.AddWithValue("@MaNV", txtNhanVien.Text); // Assuming MaNV is the primary key in your table

            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM NV WHERE MaNV = @MaNV";
            command.Parameters.AddWithValue("@MaNV", txtNhanVien.Text);
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Search(txtTimKiem.Text);
        }
        private void Search(string keyword)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = $"[Mã nhân viên] LIKE '%{keyword}%' OR [Tên nhân viên] LIKE '%{keyword}%' OR [Giới tính]" +
                $" LIKE '%{keyword}%' OR [Chức vụ] LIKE '%{keyword}%' OR CONVERT(SDT, 'System.String') LIKE '%{keyword}%' OR [Địa chỉ] LIKE '%{keyword}%' OR [Email] LIKE '%{keyword}%'";
        }


    }
}
