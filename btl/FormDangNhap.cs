using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl
{
    public partial class FormDangNhap : Form
    {
        SqlConnection con = null;
            //new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True");

        public FormDangNhap()
        {
            InitializeComponent();
            
        }

        private void picKhong_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                pic_HienThi.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void pic_HienThi_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                picKhong.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }
        public static string user { get;set; }
        public void btn_dang_nhap_Click(object sender, EventArgs e)
        {
            try {
                if (con == null)
                {
                    con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=khach_san;Integrated Security=True");

                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                 user = txtTenDangNhap.Text;
                string pass = txtMatKhau.Text;
                sqlCmd.CommandText = "SELECT * FROM HeThong WHERE TK = @User AND MK = @Pass";
                sqlCmd.Parameters.AddWithValue("@User", user);
                sqlCmd.Parameters.AddWithValue("@Pass", pass);
                sqlCmd.Connection = con;
                SqlDataReader data = sqlCmd.ExecuteReader();
                if (txtTenDangNhap.Text == string.Empty || txtMatKhau.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");
                }
                else if (data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Form1  nv = new Form1();
                    nv.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
                
                
                
            } catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi" );
            }
            finally
            {
                con.Close();
            }
            
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMK quenMK = new FormQuenMK();   
            quenMK.ShowDialog();
        }
    }
}
