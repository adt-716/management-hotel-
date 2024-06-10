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
using System.Windows.Forms.DataVisualization.Charting; 

namespace btl
{
    public partial class UserControlDanhGia : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select DanhGia.MucDG, HoaDon.MaHD, HoaDon.MaKH  from DanhGia inner join HoaDon on DanhGia.MaHD = HoaDon.MaHD ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDanhGia.DataSource = table;
        }
        public UserControlDanhGia()
        {
            InitializeComponent();
            InitializeChart(); 
        }

        private void UserControlDanhGia_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            InitializeChart();


        }
        private void InitializeChart()
        {
           

            // Set loại biểu đồ thành Line
            chartDanhGia.Series[0].ChartType = SeriesChartType.Column;

            // Set mục x cho biểu đồ
            chartDanhGia.Series[0].XValueMember = "MucDG";

            // Set giá trị y cho biểu đồ
            chartDanhGia.Series[0].YValueMembers = "SoLuong";

            // Thiết lập nguồn dữ liệu cho biểu đồ
            chartDanhGia.DataSource = CountRatings();

            // Set X axis title
            chartDanhGia.ChartAreas[0].AxisX.Title = "Rating Levels";

            // Set Y axis title
            chartDanhGia.ChartAreas[0].AxisY.Title = "Number of Ratings";

            // Customize line appearance
            chartDanhGia.Series[0].Color = Color.MediumAquamarine ;
            chartDanhGia.Series[0].BorderWidth = 4; // Adjust line thickness

            // Set the X-axis to display only ratings from 0 to 5
            chartDanhGia.ChartAreas[0].AxisX.Minimum = 0;
            chartDanhGia.ChartAreas[0].AxisX.Maximum = 6;

            // Cập nhật biểu đồ
            chartDanhGia.DataBind();

        }
    
        private DataTable CountRatings()
        {
            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("MucDG", typeof(int));
            resultTable.Columns.Add("SoLuong", typeof(int));

            for (int i = 1; i <= 5; i++)
            {
                int count = CountRatingsForLevel(i);
                resultTable.Rows.Add(i, count);
            }

            return resultTable;
        }

        private int CountRatingsForLevel(int level)
        {
            int count = 0;

            foreach (DataRow row in table.Rows)
            {
                int mucDG = Convert.ToInt32(row["MucDG"]);
                if (mucDG == level)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
