using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace btl
{
    public partial class UserControlDVPhoBien : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select KhachHang_DichVu.MaKH, KhachHang_DichVu.MaDV, DichVu.LoaiDV from KhachHang_DichVu  inner join DichVu on KhachHang_DichVu.MaDV = DichVu.MaDV ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDV.DataSource = table;
        }
        public UserControlDVPhoBien()
        {
            InitializeComponent();
            


        }

        private void UserControlDVPhoBien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            InitializeChart();


        }
        
        private void InitializeChart()
        {
            // Đặt loại biểu đồ thành Column
            chartDVPB.Series[0].ChartType = SeriesChartType.Column;

            // Đặt mục x cho biểu đồ
            chartDVPB.Series[0].XValueMember = "LoaiDV";

            // Đặt giá trị y cho biểu đồ
            chartDVPB.Series[0].YValueMembers = "SoLuong";

            // Thiết lập nguồn dữ liệu cho biểu đồ
            chartDVPB.DataSource = CountRatings();

            // Cập nhật biểu đồ
            chartDVPB.DataBind();
        }
        private DataTable CountRatings()
        {
            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("LoaiDV", typeof(string));
            resultTable.Columns.Add("SoLuong", typeof(int));

            // Lặp qua từng dịch vụ và đếm số lượng
            for (int i = 0; i < dgvDV.Rows.Count; i++)
            {
                string loaiDV = dgvDV.Rows[i].Cells["LoaiDV"].Value?.ToString();

                // Kiểm tra xem giá trị đã tồn tại trong resultTable chưa
                DataRow existingRow = resultTable.Select($"LoaiDV = '{loaiDV}'").FirstOrDefault();
                if (existingRow != null)
                {
                    // Nếu đã tồn tại, tăng số lượng
                    existingRow["SoLuong"] = Convert.ToInt32(existingRow["SoLuong"]) + 1;
                }
                else
                {
                    // Nếu chưa tồn tại, thêm mới vào resultTable
                    resultTable.Rows.Add(loaiDV, 1);
                }
            }


            return resultTable;
        }

        private int CountRatingsForLevel(int level)
        {
            int count = 0;

            // Lặp qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dgvDV.Rows)
            {
                // Lấy giá trị từ cột "LoaiDV"
                string loaiDV = row.Cells[2].Value?.ToString();

                // So sánh giá trị với dịch vụ của cấp độ hiện tại
                if (!string.IsNullOrEmpty(loaiDV) && loaiDV.Equals("LoaiDV" + level, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }

            return count;
        }




    }
}
