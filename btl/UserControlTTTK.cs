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
    public partial class UserControlTTTK : UserControl
    {
        public UserControlTTTK()
        {
            InitializeComponent();
        }

        private void UserControlTTTK_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True"))
                {
                    string user = FormDangNhap.user;
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT MaNV, TenNV, GT, ChucDanh, SDT, DiaChi, Email FROM NV WHERE TK = @TaiKhoan", connection))
                    {
                        command.Parameters.AddWithValue("@TaiKhoan",user );
                        using (SqlDataReader row = command.ExecuteReader())
                        {
                            if (row.Read())
                            {
                                txtMaNV.Text = row["MaNV"].ToString();
                                txtHoTen.Text = row["TenNV"].ToString();
                                cbGT.Text = row["GT"].ToString();
                                cbChucVu.Text = row["ChucDanh"].ToString();
                                txtSDT.Text = row["SDT"].ToString();
                                txtDiaChi.Text = row["DiaChi"].ToString();
                                txtEmail.Text = row["Email"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin tài khoản.");
                            }
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True"))
                {
                    connection.Open();

                    string updateQuery = "UPDATE NV SET TenNV = @TenNV, GT = @GT, ChucDanh = @ChucDanh, SDT = @SDT, DiaChi = @DiaChi, Email = @Email WHERE TK = @TaiKhoan";

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        string user = FormDangNhap.user;
                        updateCommand.Parameters.AddWithValue("@TenNV", txtHoTen.Text);
                        updateCommand.Parameters.AddWithValue("@GT", cbGT.Text);
                        updateCommand.Parameters.AddWithValue("@ChucDanh", cbChucVu.Text);
                        updateCommand.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        updateCommand.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        updateCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                        updateCommand.Parameters.AddWithValue("@TaiKhoan", user); 

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thông tin tài khoản đã được cập nhật thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật thông tin tài khoản.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
