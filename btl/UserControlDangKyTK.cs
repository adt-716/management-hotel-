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

namespace btl
{
    public partial class UserControlDangKyTK : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True");
        public UserControlDangKyTK()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                if (txtMaNV.Text.Trim() == "" || txtTenNV.Text.Trim() == "" || txtTenDangNhap.Text.Trim() == "" ||
                txtMK.Text.Trim() == "" || txtNhapLai.Text.Trim() == "" || cbGT.Text.Trim() == "" ||
                CbChucDanh.Text.Trim() == "" || txtSDT.Text.Trim() == "" || txtDiaChi.Text.Trim() == "" ||
                txtEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký.");
                }
                else if (txtMK.Text != txtNhapLai.Text)
                {
                    MessageBox.Show("Mật khẩu và nhập lại mật khẩu không khớp.");
                }
                else
                {
                    // Thêm tài khoản và mật khẩu vào bảng TaiKhoanMatKhau với TK là khóa ngoại
                    SqlCommand insertTaiKhoanCmd = new SqlCommand("INSERT INTO HeThong (TK, MK) " +
                                                                   "VALUES (@TK, @MK)", con);
                    insertTaiKhoanCmd.Parameters.AddWithValue("@TK", txtTenDangNhap.Text);
                    insertTaiKhoanCmd.Parameters.AddWithValue("@MK", txtMK.Text);

                    insertTaiKhoanCmd.ExecuteNonQuery();
                    // Thực hiện đăng ký tài khoản và nhân viên
                    SqlCommand insertNhanVienCmd = new SqlCommand("INSERT INTO NV (MaNV, TenNV, GT, ChucDanh, SDT, DiaChi, Email, TK) " +
                                                                   "VALUES (@MaNV, @HoTen, @GioiTinh, @ChucDanh, @SDT, @DiaChi, @Email, @TK)", con);
                    insertNhanVienCmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    insertNhanVienCmd.Parameters.AddWithValue("@HoTen", txtTenNV.Text);
                   
                    insertNhanVienCmd.Parameters.AddWithValue("@GioiTinh", cbGT.Text);
                    insertNhanVienCmd.Parameters.AddWithValue("@ChucDanh", CbChucDanh.Text);
                    insertNhanVienCmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    insertNhanVienCmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    insertNhanVienCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    insertNhanVienCmd.Parameters.AddWithValue("@TK", txtTenDangNhap.Text);
                    insertNhanVienCmd.ExecuteNonQuery();

                   

                    MessageBox.Show("Đăng ký tài khoản và nhân viên thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa thông tin đã nhập
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtTenDangNhap.Text = "";
            txtMK.Text = "";
            txtNhapLai.Text = "";
            cbGT.SelectedIndex = -1;
            CbChucDanh.SelectedIndex = -1;
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
        }
    }
}
