using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace btl
{
    public partial class FormQuenMK : Form
    {
        

        SqlConnection connection;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True";
        string randomcode;
        public static string userEmail {  get; set; }
        public FormQuenMK()
        {
            InitializeComponent();
        }
        
        private void btnGui_Click(object sender, EventArgs e)
        {
            string email = txtNhapEmail.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email");
            }
            else
            {
                try
                {
                    if (EmailExists(email))
                    {
                        // Tạo mã xác nhận ngẫu nhiên và hiển thị trên Label
                        randomcode = GenerateRandomCode();
                        label3.Text = "Mã xác nhận của bạn: " + randomcode;
                        userEmail = email;
                    }
                    else
                    {
                        label3.Text = "Email không tồn tại trong hệ thống.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }

        }
        private bool EmailExists(string email)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM HeThong INNER JOIN NV ON HeThong.TK = NV.TK WHERE Email = @Email", connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        private string GenerateRandomCode()
        {
            // Tạo mã xác nhận ngẫu nhiên, ví dụ: sử dụng ngày giờ hiện tại và số ngẫu nhiên
            Random rand = new Random();
            int randomNumber = rand.Next(100000, 999999);
            randomcode = randomNumber.ToString();
            return randomcode;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string enteredCode = txtNhapCode.Text;

            if (enteredCode == randomcode)
            {
                // Mã xác nhận đúng, chuyển sang FormQuenMK
                this.Hide(); // Ẩn form hiện tại

                FormDoiMK form = new FormDoiMK();
                form.ShowDialog(); // Hiển thị FormQuenMK
            }
            else
            {
                // Mã xác nhận không đúng
                MessageBox.Show("Mã xác nhận không đúng. Vui lòng kiểm tra lại.");
            }
        }
    }   
    
}
