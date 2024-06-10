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
    public partial class UserControlDV : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select MaDV as N'Mã dịch vụ',  LoaiDV as N'Loại Dịch Vụ', GiaDV as 'Giá dịch vụ ' from DichVu";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDV.DataSource = table;
        }
        public UserControlDV()
        {
            InitializeComponent();
        }

        private void UserControlDV_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgvDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDV.CurrentRow.Index;
            txtMaDichVu.Text = dgvDV.Rows[i].Cells[0].Value.ToString();
            txtTenDV.Text = dgvDV.Rows[i].Cells[1].Value.ToString();
            txtGiaDV.Text = dgvDV.Rows[i].Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "insert into DichVu values('N" + txtMaDichVu.Text + "',N'" + txtTenDV.Text + "',N'" + txtGiaDV.Text + "' )";
                command.ExecuteNonQuery();
                loadData();
            } catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaDichVu.Text))
                {
                    command = connection.CreateCommand();
                    command.CommandText = "delete from DichVu where MaDV = '" + txtMaDichVu.Text + "'";
                    command.ExecuteNonQuery();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Please select a record to delete.");
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Loi"  + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update DichVu set MaDV = N'" + txtMaDichVu.Text + "',LoaiDV = N'" + txtTenDV.Text + "', GiaDV = N'" + txtGiaDV.Text + "'";
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
            dv.RowFilter = $"MaDV LIKE '%{keyword}%' OR LoaiDV LIKE '%{keyword}%' OR GiaDv LIKE '%{keyword}%' OR ChucDanh LIKE '%{keyword}%'";
        }
    }
}
