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
    public partial class UserControlDoiMK : UserControl
    {
        public UserControlDoiMK()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True");

            try
            {
                con.Open();

                // Sử dụng tham số để tránh SQL Injection
                SqlCommand checkPasswordCmd = new SqlCommand("SELECT * FROM HeThong WHERE TK = @TK AND MK = @MK", con);
                checkPasswordCmd.Parameters.AddWithValue("@TK", txtDangNhap.Text);
                checkPasswordCmd.Parameters.AddWithValue("@MK", txtMKcu.Text);

                SqlDataAdapter sda = new SqlDataAdapter(checkPasswordCmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    if (txtMKmoi.Text == txtNhapLai.Text)
                    {
                        // Sử dụng tham số trong câu lệnh SQL
                        SqlCommand updatePasswordCmd = new SqlCommand("UPDATE HeThong SET MK = @NewPassword WHERE TK = @TK AND MK = @OldPassword", con);
                        updatePasswordCmd.Parameters.AddWithValue("@NewPassword", txtNhapLai.Text);
                        updatePasswordCmd.Parameters.AddWithValue("@TK", txtDangNhap.Text);
                        updatePasswordCmd.Parameters.AddWithValue("@OldPassword", txtMKcu.Text);

                        updatePasswordCmd.ExecuteNonQuery();
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không trùng khớp.");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu cũ không đúng.");
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
    }
}
