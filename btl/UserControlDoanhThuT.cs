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
    public partial class UserControlDoanhThuT : UserControl
    {
        
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        
        public UserControlDoanhThuT()
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection = new SqlConnection(str);
            command = new SqlCommand(); // Initialize the SqlCommand object
            command.Connection = connection;
        }
      
        private void LoadRevenueData()
        {
                    int selectedMonth = Convert.ToInt32(cbThang.SelectedItem);
                    int selectedYear = Convert.ToInt32(cbNam.SelectedItem);

                    // Update the SQL query to filter by the selected month and year
                    command.CommandText = $@"
                SELECT
                    MONTH(CONVERT(DATE, HoaDon.NgayTT, 103)) AS Thang,
                    YEAR(CONVERT(DATE, HoaDon.NgayTT, 103)) AS Nam,
                    SUM(CASE WHEN Phong.SoPhong IS NOT NULL THEN LoaiPhong.DonGia * DATEDIFF(DAY, CONVERT(DATE, DatPhong.Ngay_nhan, 103), CONVERT(DATE, DatPhong.Ngay_tra, 103)) ELSE 0 END) AS DoanhThuPhong,
                    SUM(CASE WHEN DichVu.MaDV IS NOT NULL THEN DichVu.GiaDV ELSE 0 END) AS DoanhThuDichVu,
                    SUM(
                        CASE
                            WHEN Phong.SoPhong IS NULL THEN DichVu.GiaDV
                            ELSE LoaiPhong.DonGia * DATEDIFF(DAY, CONVERT(DATE, DatPhong.Ngay_nhan, 103), CONVERT(DATE, DatPhong.Ngay_tra, 103)) + DichVu.GiaDV
                        END
                    ) AS TongDoanhThu
                FROM
                    HoaDon
                JOIN
                    KH ON HoaDon.MaKH = KH.MaKH
                LEFT JOIN
                    DatPhong ON KH.MaKH = DatPhong.MaKH
                LEFT JOIN
                    Phong ON DatPhong.MaDat = Phong.MaDat
                LEFT JOIN
                    LoaiPhong ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong
                LEFT JOIN
                    DichVu ON HoaDon.MaDV = DichVu.MaDV
                LEFT JOIN
                    KhachHang_DichVu ON DatPhong.MaKH = KhachHang_DichVu.MaKH
                WHERE
                    MONTH(CONVERT(DATE, HoaDon.NgayTT, 103)) = {selectedMonth} AND
                    YEAR(CONVERT(DATE, HoaDon.NgayTT, 103)) = {selectedYear}
                GROUP BY
                    MONTH(CONVERT(DATE, HoaDon.NgayTT, 103)),
                    YEAR(CONVERT(DATE, HoaDon.NgayTT, 103));
            ";

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            UpdateColumnChart();
            if (table.Rows.Count > 0)
            {
                // Retrieve values from the first row
                object doanhThuPhongValue = table.Rows[0]["DoanhThuPhong"];
                object doanhThuDichVuValue = table.Rows[0]["DoanhThuDichVu"];
                object tongDoanhThuValue = table.Rows[0]["TongDoanhThu"];

                // Set the TextBox texts with the converted values
                txtDoanhThuPhong.Text = (doanhThuPhongValue != DBNull.Value) ? doanhThuPhongValue.ToString() : "N/A";
                txtDoanhThuDV.Text = (doanhThuDichVuValue != DBNull.Value) ? doanhThuDichVuValue.ToString() : "N/A";
                txtTongDoanhThu.Text = (tongDoanhThuValue != DBNull.Value) ? tongDoanhThuValue.ToString() : "N/A";
            }
            else
            {
                // Handle the case where the DataTable is empty (optional)
                txtDoanhThuPhong.Text = "N/A";
                txtDoanhThuDV.Text = "N/A";
                txtTongDoanhThu.Text = "N/A";
            }
            // Call method to update the pie chart

        }



        private void UpdateColumnChart()
        {
            // Assuming you have a Pie chart named chart1 in your form
            chartRevenue.Series.Clear();
            chartRevenue.Series.Add("DoanhThuPhong");
            chartRevenue.Series.Add("DoanhThuDichVu");

            // Set the color for DoanhThuPhong series to blue
            chartRevenue.Series["DoanhThuPhong"].Points.DataBind(table.DefaultView, "Thang", "DoanhThuPhong", "");
            foreach (var point in chartRevenue.Series["DoanhThuPhong"].Points)
            {
                point.Color = System.Drawing.Color.Blue;
            }

            // Set the color for DoanhThuDichVu series to red
            chartRevenue.Series["DoanhThuDichVu"].Points.DataBind(table.DefaultView, "Thang", "DoanhThuDichVu", "");
            foreach (var point in chartRevenue.Series["DoanhThuDichVu"].Points)
            {
                point.Color = System.Drawing.Color.Red;
            }
        }


        private void UserControlDoanhThuT_Load(object sender, EventArgs e)
        {
           LoadRevenueData();
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRevenueData();
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRevenueData();
        }
    }
}
