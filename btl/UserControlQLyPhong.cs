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
    public partial class UserControlQLyPhong : UserControl
    {
        
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select LoaiPhong.TenLoaiPhong as N'Loại phòng', Phong.TrangThai as N'Trạng thái', Phong.SoPhong as N'Số phòng'  from LoaiPhong inner join Phong on LoaiPhong.MaLoaiPhong = Phong.MaLoaiPhong ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvQly.DataSource = table;
        }
        
        public UserControlQLyPhong()
        {
            InitializeComponent();
        }

        

        private void UserControlQLyPhong_Load(object sender, EventArgs e)
        {
            
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            
        }
        private void dgvQly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i;
            i = dgvQly.CurrentRow.Index;
            cbLoaiPhong.Text = dgvQly.Rows[i].Cells[0].Value.ToString();
            cbTrangThai.Text = dgvQly.Rows[i].Cells[1].Value.ToString();
            txtSoPhong.Text = dgvQly.Rows[i].Cells[2].Value.ToString();
            
        }

        private void dgvQly_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvQly.CurrentRow.Index;
            cbLoaiPhong.Text = dgvQly.Rows[i].Cells[0].Value.ToString();
            cbTrangThai.Text = dgvQly.Rows[i].Cells[1].Value.ToString();
            txtSoPhong.Text = dgvQly.Rows[i].Cells[2].Value.ToString();
        }
    }
}
