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
    public partial class UserControlHoaDon : UserControl
    {
        
        public string MaKhachHang { get; set; } 
        public event DataGridViewCellEventHandler CellClick;
        public void SetMaKhachHang(string maKhachHang)
        {
            MaKhachHang = maKhachHang;
        }
        public UserControlHoaDon()
        {
            InitializeComponent();
        }

        public void UserControlHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;

        }
        private void LoadData()
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True"))
                {
                    con.Open();

                    // Truy vấn SQL để lấy thông tin hóa đơn từ cơ sở dữ liệ
                    string query = @"
                                  SELECT
                                HoaDon.MaHD,
                                KH.MaKH,
                                KH.TenKH,
                                Phong.SoPhong,
                                Phong.MaLoaiPhong,
                                LoaiPhong.DonGia,
                                DATEDIFF(DAY, CONVERT(DATE, DatPhong.Ngay_nhan, 103), CONVERT(DATE, DatPhong.Ngay_tra, 103)) AS SoNgayThue,
                                LoaiPhong.DonGia * DATEDIFF(DAY, CONVERT(DATE, DatPhong.Ngay_nhan, 103), CONVERT(DATE, DatPhong.Ngay_tra, 103)) AS DoanhThuPhong,
                                MAX(HoaDon.MaDV) AS MaDV,
                                MAX(DichVu.LoaiDV) AS LoaiDV,
                                MAX(DichVu.GiaDV) AS GiaDV,
                                COUNT(HoaDon.MaDV) AS SoLuongDichVu,
                                SUM(DichVu.GiaDV) AS DoanhThuDichVu,
                                CASE
                                    WHEN Phong.SoPhong IS NULL THEN SUM(DichVu.GiaDV)
                                    ELSE LoaiPhong.DonGia * DATEDIFF(DAY, CONVERT(DATE, DatPhong.Ngay_nhan, 103), CONVERT(DATE, DatPhong.Ngay_tra, 103))
                                        + SUM(DichVu.GiaDV)
                                END AS TongDoanhThu,
                                NV.MaNV,
                                NV.TenNV,
	                            HoaDon.PTTT as PTTT ,
                                HoaDon.NgayTT AS NgayThanhToan
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

                            LEFT JOIN
                                NV ON HoaDon.MaNV = NV.MaNV

                            GROUP BY
                                HoaDon.MaHD,
                                KH.MaKH,
                                KH.TenKH,
                                Phong.SoPhong,
                                Phong.MaLoaiPhong,
                                LoaiPhong.DonGia,
                                DATEDIFF(DAY, CONVERT(DATE, DatPhong.Ngay_nhan, 103), CONVERT(DATE, DatPhong.Ngay_tra, 103)),
                                NV.TenNV,
                                HoaDon.NgayTT,
	                            PTTT,
                                NV.MaNV;
                    ";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Hiển thị thông tin hóa đơn trong DataGridView
                        dgvHoaDon.DataSource = dataTable;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void HienThiHoaDonForm(string maKhachHang)
        {
            // Tạo một instance của form hóa đơn và truyền mã khách hàng vào nó
           
            FormHoaDon formHoaDon = new FormHoaDon();
            // Truyền mã khách hàng vào form hóa đơn
            formHoaDon.maKhachHang = maKhachHang;

            // Hiển thị form
            formHoaDon.Show();
        }

        public void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một ô có dữ liệu hay không
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị của cột MaKH trong hàng được chọn
                string maKhachHang = dgvHoaDon.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();

                // Hiển thị form hóa đơn với thông tin của mã khách hàng
                HienThiHoaDonForm(maKhachHang);
                
            }
           
        }
    }
}
