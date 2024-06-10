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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace btl
{
    public partial class FormDoiMK : Form
    {

        public FormDoiMK()
        {
            InitializeComponent();
           
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra mật khẩu mới và nhập lại mật khẩu
            string newPassword = txtMKmoi.Text;
            string confirmPassword = txtNhapLai.Text;

            // Lấy giá trị từ biến tĩnh userEmail trong FormQuenMK
            string userEmail = FormQuenMK.userEmail;

            if (newPassword == confirmPassword)
            {
                // Mật khẩu mới và xác nhận mật khẩu đúng, thực hiện đổi mật khẩu
                if (ChangePassword(userEmail, newPassword))
                {
                    MessageBox.Show("Đổi mật khẩu thành công.");
                    this.Close(); // Đóng FormDoiMK sau khi đổi mật khẩu thành công
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi đổi mật khẩu.");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp. Vui lòng kiểm tra lại.");
            }
        }
        private bool ChangePassword(string userEmail, string newPassword)
        {
            // Thực hiện logic để đổi mật khẩu trong cơ sở dữ liệu
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE HeThong SET MK = @MatKhau FROM HeThong INNER JOIN NV ON HeThong.TK = NV.TK WHERE Email = @Email", con))
                    {
                        command.Parameters.AddWithValue("@MatKhau", newPassword);
                        command.Parameters.AddWithValue("@Email", userEmail);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                return false;
            }
        }

        private void picKhong_Click(object sender, EventArgs e)
        {
            if (txtMKmoi.PasswordChar == '*')
            {
                pic_HienThi.BringToFront();
                txtMKmoi.PasswordChar = '\0';
            }
        }

        private void pic_HienThi_Click(object sender, EventArgs e)
        {
            if (txtMKmoi.PasswordChar == '\0')
            {
                picKhong.BringToFront();
                txtMKmoi.PasswordChar = '*';
            }
        }

        private void picKhong2_Click(object sender, EventArgs e)
        {
            if (txtNhapLai.PasswordChar == '*')
            {
                picHienThi2.BringToFront();
                txtNhapLai.PasswordChar = '\0';
            }
        }

        private void picHienThi2_Click(object sender, EventArgs e)
        {
            if (txtNhapLai.PasswordChar == '\0')
            {
                picKhong2.BringToFront();
                txtNhapLai.PasswordChar = '*';
            }
        }
    }
}
