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
    public partial class UserControlDatPhong : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            command = connection.CreateCommand();
            command.Parameters.AddWithValue("@TrangThai1", "Trống");
            command.CommandText = "Select Phong.SoPhong as N'Số phòng' , LoaiPhong.TenLoaiPhong as N'Loại phòng', LoaiPhong.DonGia as N'Đơn giá', LoaiPhong.SoNguoi as N'Số người', LoaiPhong.SoGiuong as N'Số giường' from Phong inner join LoaiPhong on Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong where TrangThai = @TrangThai1";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvPhongTrong.DataSource = table;
        }
        
        public UserControlDatPhong()
        {
            InitializeComponent();
        }

        private void UserControlDatPhong_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
       
        }

        private void dgvPhongTrong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvPhongTrong.CurrentRow.Index;
            txtSoPhong.Text = dgvPhongTrong.Rows[i].Cells[0].Value.ToString();
            cbLoaiPhong.Text = dgvPhongTrong.Rows[i].Cells[1].Value.ToString();
            txtDG.Text = dgvPhongTrong.Rows[i].Cells[2].Value.ToString();
            txtSoNguoi.Text = dgvPhongTrong.Rows[i].Cells[3].Value.ToString();
            txtSoGiuong.Text = dgvPhongTrong.Rows[i].Cells[4].Value.ToString();
        }
        private string GenerateUniqueID(string prefix, int length)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Retrieve the last generated ID from the database
                    string query = $"SELECT TOP 1 MaDat FROM DatPhong WHERE MaDat LIKE '{prefix}%' ORDER BY MaDat DESC";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string lastID = reader.GetString(0);
                            int number = int.Parse(lastID.Substring(prefix.Length)) + 1;

                            // Generate the new ID
                            return $"{prefix}{number.ToString().PadLeft(length - prefix.Length, '0')}";
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL khi sinh mã đặt phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sinh mã đặt phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Default to the previous logic if an error occurs
            return prefix + Guid.NewGuid().ToString("N").Substring(0, Math.Min(8, 32 - prefix.Length));
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = GenerateUniqueID("KH", 3);
                string tenKH = txtHoTen.Text;
                string gioiTinh = cbGT.Text;
                int CCCD = int.Parse(txtCCCD.Text);
                int sdt = int.Parse(txtSDT.Text);
                string diaChi = txtNoiSong.Text;
                string quocTich = cbQuocTich.Text;
                DateTime ngayNhan = dateNhanPhong.Value;
                DateTime ngayDat = dateDatPhong.Value;
                DateTime ngayTra = dateNgayTra.Value;
                string maDat = GenerateUniqueID("DP", 3); 
                string cachDat = cbCachDat.Text;
                int soPhong = int.Parse(txtSoPhong.Text);
                string loaiPhong = cbLoaiPhong.Text;
                int donGia = int.Parse(txtDG.Text);
                int soNguoi = int.Parse(txtSoNguoi.Text);
                int SoGiuong = int.Parse(txtSoGiuong.Text);

                InsertIntoKH(maKH, tenKH, gioiTinh, CCCD, sdt, diaChi, quocTich);
                InsertIntoDatPhong(maDat, cachDat, ngayDat, ngayNhan, ngayTra, maKH, "NV001");
                InsertIntoPhong(soPhong, "Da Dat", maKH, maDat);

                MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đặt phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            
        }
        private void InsertIntoKH(string maKH, string tenKH, string gioiTinh, int CCCD, int sdt, string diaChi, string quocTich)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Insert into KH (Khach Hang)
                    string query = "INSERT INTO KH (MaKH, TenKH, GT, CCCD, SDT, DiaChi, QuocTich) " +
                                   "VALUES (@MaKH, @TenKH, @GT, @CCCD, @SDT, @DiaChi, @QuocTich)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaKH", maKH);
                        command.Parameters.AddWithValue("@TenKH", tenKH);
                        command.Parameters.AddWithValue("@GT", gioiTinh);
                        command.Parameters.AddWithValue("@CCCD", CCCD);
                        command.Parameters.AddWithValue("@SDT", sdt);
                        command.Parameters.AddWithValue("@DiaChi", diaChi);
                        command.Parameters.AddWithValue("@QuocTich", quocTich);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL khi thêm vào bảng KH: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm vào bảng KH: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void InsertIntoDatPhong(string maDatPhong, string cachDat, DateTime ngayDat, DateTime ngayNhan, DateTime ngayTra, string maKH, string maNV)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Chuyển đổi ngày sang chuỗi với định dạng "dd/MM/yyyy"
                    string ngayDatFormatted = ngayDat.ToString("dd-MM-yyyy");
                    string ngayNhanFormatted = ngayNhan.ToString("dd-MM-yyyy");
                    string ngayTraFormatted = ngayTra.ToString("dd-MM-yyyy");

                    // Thực hiện INSERT
                    string query = "INSERT INTO DatPhong (MaDat, Cach_dat, Ngay_dat, Ngay_nhan, Ngay_tra, MaKH, MaNV) " +
                                   "VALUES (@MaDat, @CachDat, @NgayDat, @NgayNhan, @NgayTra, @MaKH, @MaNV)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaDat", maDatPhong);
                        command.Parameters.AddWithValue("@CachDat", cachDat);
                        command.Parameters.AddWithValue("@NgayDat", ngayDatFormatted);
                        command.Parameters.AddWithValue("@NgayNhan", ngayNhanFormatted);
                        command.Parameters.AddWithValue("@NgayTra", ngayTraFormatted);
                        command.Parameters.AddWithValue("@MaKH", maKH);
                        command.Parameters.AddWithValue("@MaNV", maNV);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL khi thêm vào bảng DatPhong: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm vào bảng DatPhong: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertIntoPhong(int soPhong, string trangThai, string maKH, string maDatPhong)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Update Phong table to set the status to "Đã Đặt"
                    string updateQuery = "UPDATE Phong SET TrangThai = N'Đã Đặt', MaKH = @MaKH, MaDat = @MaDat WHERE SoPhong = @SoPhong";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@MaKH", maKH);
                        updateCommand.Parameters.AddWithValue("@MaDat", maDatPhong);
                        updateCommand.Parameters.AddWithValue("@SoPhong", soPhong);
                        updateCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL khi cập nhật trạng thái phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
