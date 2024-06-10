using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl
{
    public partial class FormHoaDon : Form
    {
        
        public string maKhachHang { get; set; }
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Mã khách hàng được chọn: {maKhachHang}");
            LoadData();
            ShowHoaDonInfo();

        }
        public  void LoadData()
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True"))
                {
                    con.Open();

                    // Sử dụng tham số trong truy vấn SQL
                    string query = @" SELECT
                            HoaDon.MaHD,
                            KH.MaKH,
                            KH.TenKH,
                            Phong.SoPhong,
                            Phong.MaLoaiPhong,
                            LoaiPhong.DonGia,
                            DATEDIFF(DAY, CONVERT(DATE, DatPhong.Ngay_nhan, 103), CONVERT(DATE, DatPhong.Ngay_tra, 103)) AS SoNgayThue,
                            LoaiPhong.DonGia * DATEDIFF(DAY, CONVERT(DATE, DatPhong.Ngay_nhan, 103), CONVERT(DATE, DatPhong.Ngay_tra, 103)) AS TienPhong,
                            MAX(HoaDon.MaDV) AS MaDV ,
                            MAX(DichVu.LoaiDV) AS LoaiDV ,
                            MAX(DichVu.GiaDV) AS GiaDV ,
                            COUNT(HoaDon.MaDV) AS SoLuongDichVu ,
                            SUM(DichVu.GiaDV) AS TienDichVu,
                            CASE
                                WHEN Phong.SoPhong IS NULL THEN SUM(DichVu.GiaDV)
                                ELSE LoaiPhong.DonGia * DATEDIFF(DAY, CONVERT(DATE, DatPhong.Ngay_nhan, 103), CONVERT(DATE, DatPhong.Ngay_tra, 103))
                                    + SUM(DichVu.GiaDV)
                            END AS TongBill,
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
                        WHERE KH.MaKH = @MaKH
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
                        // Thêm tham số vào truy vấn SQL
                        cmd.Parameters.AddWithValue("@MaKH", maKhachHang);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Hiển thị thông tin hóa đơn trong DataGridView
                        dgvTTHoaDon.DataSource = dataTable;
                        // Hide specific columns
                        dgvTTHoaDon.Columns["MaHD"].Visible = false;
                        dgvTTHoaDon.Columns["MaNV"].Visible = false;
                        dgvTTHoaDon.Columns["TenNV"].Visible = false;
                        dgvTTHoaDon.Columns["TenKH"].Visible = false;
                        dgvTTHoaDon.Columns["MaKH"].Visible = false;
                        dgvTTHoaDon.Columns["NgayThanhToan"].Visible = false;
                        dgvTTHoaDon.Columns["PTTT"].Visible = false;
                        dgvTTHoaDon.Columns["SoPhong"].Visible = false;
                        dgvTTHoaDon.Columns["SoNgayThue"].Visible = false;
                        dgvTTHoaDon.Columns["TienPhong"].Visible = false;
                        dgvTTHoaDon.Columns["TienDichVu"].Visible = false;
                        dgvTTHoaDon.Columns["TongBill"].Visible = false;
                        dgvTTHoaDon.Columns["MaLoaiPhong"].Visible = false;
                        dgvTTHoaDon.Columns["DonGia"].Visible = false;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                txtMaHD.Text = reader["MaHD"].ToString();
                                txtMaNV.Text = reader["MaNV"].ToString();
                                txtTenNV.Text = reader["TenNV"].ToString() ;
                                txtMaKH.Text = reader["MaKH"].ToString();
                                txtTenKH.Text = reader["TenKH"].ToString();
                                txtNgayLap.Text = reader["NgayThanhToan"].ToString();
                                txtPTTT.Text = reader["PTTT"].ToString();
                                txtSoPhong.Text = reader["SoPhong"].ToString();
                                txtSoNgay.Text = reader["SoNgayThue"].ToString();
                            }
                        }

                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTTHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           ShowHoaDonInfo();
        }

        public void ShowHoaDonInfo()
        {
            try
            {
                decimal tongTienPhong = 0;
                decimal tongTienDichVu = 0;
                decimal tongBill = 0;

                foreach (DataGridViewRow row in dgvTTHoaDon.Rows)
                {
                    // Check if the row is not a new row
                    if (!row.IsNewRow)
                    {
                        // Use TryParse to safely convert cell values to decimal
                        if (decimal.TryParse(row.Cells["TienPhong"]?.Value?.ToString(), out decimal doanhThuPhong))
                        {
                            tongTienPhong += doanhThuPhong;
                        }

                        if (decimal.TryParse(row.Cells["TienDichVu"]?.Value?.ToString(), out decimal doanhThuDichVu))
                        {
                            tongTienDichVu += doanhThuDichVu;
                        }

                        if (decimal.TryParse(row.Cells["TongBill"]?.Value?.ToString(), out decimal tongDoanhThu))
                        {
                            tongBill += tongDoanhThu;
                        }
                    }
                }

                // Hiển thị tổng tiền trong TextBox
                txtTongTienPhong.Text = tongTienPhong.ToString();
                txtTongTienDichVu.Text = tongTienDichVu.ToString();
                txtTongBill.Text = tongBill.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tổng tiền: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Bitmap bmp;
        PrintDocument printDocument = new PrintDocument();
        private void btnIn_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(1042, 1023);
            using (Graphics mg = Graphics.FromImage(bmp))
            {
                mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, new Size(1100, 1023));
            }
            // Hiển thị trước khi in
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (bmp != null)
            {
                e.Graphics.DrawImage(bmp, 0  , 0 );
            }
        }
    }
}
