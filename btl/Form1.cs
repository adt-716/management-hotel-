using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace btl
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
            
            
        }
        private void customizeDesing()
        {
            panelDanhMuc.Visible = false;
            panelDatPhong.Visible = false;
            panelHeThong.Visible = false;
            panelBaoCao.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelDanhMuc.Visible == true)
            {
                panelDanhMuc.Visible = false;
            }
            if (panelDatPhong.Visible == true) panelDatPhong.Visible = false;
            if (panelHeThong.Visible == true) { panelHeThong.Visible = false; }
            if (panelBaoCao.Visible == true) panelBaoCao.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }
        private void btnPhong_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDanhMuc);
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDatPhong);
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHeThong);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBaoCao);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            // hideSubMenu();

            userControlDanhGia1.Hide();
            userControlNhanVien1.Hide();
            userControlKH1.Hide();
            userControlDV1.Hide();
            userControlPhong1.Hide();
            userControlQLyPhong1.Hide();
            userControlDatPhong1.Hide();
            userControlHoaDon1.Hide();
            userControlTTTK1.Hide();
            userControlDoiMK1.Hide();
            userControlDangKyTK1.Hide();
            userControlDVPhoBien1.Hide();
            userControlDoanhThuT1.Hide();
            userControlNhanVien1.Show();
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            userControlDanhGia1.Hide();
            userControlNhanVien1.Hide();
            userControlKH1.Hide();
            userControlDV1.Hide();
            userControlPhong1.Hide();
            userControlQLyPhong1.Hide();
            userControlDatPhong1.Hide();
            userControlHoaDon1.Hide();
            userControlTTTK1.Hide();
            userControlDoiMK1.Hide();
            userControlDangKyTK1.Hide();
            userControlDVPhoBien1.Hide();
            userControlDoanhThuT1.Hide();
            userControlKH1.Show();
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            userControlDanhGia1.Hide();
            userControlNhanVien1.Hide();
            userControlKH1.Hide();
            userControlDV1.Hide();
            userControlPhong1.Hide();
            userControlQLyPhong1.Hide();
            userControlDatPhong1.Hide();
            userControlHoaDon1.Hide();
            userControlTTTK1.Hide();
            userControlDoiMK1.Hide();
            userControlDangKyTK1.Hide();
            userControlDVPhoBien1.Hide();
            userControlDoanhThuT1.Hide();
            userControlDV1.Show();
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);
        }
        private void btnPhong_Click_1(object sender, EventArgs e)
        {
            // hideSubMenu();
            userControlDanhGia1.Hide();
            userControlNhanVien1.Hide();
            userControlKH1.Hide();
            userControlDV1.Hide();
            userControlPhong1.Hide();
            userControlQLyPhong1.Hide();
            userControlDatPhong1.Hide();
            userControlHoaDon1.Hide();
            userControlTTTK1.Hide();
            userControlDoiMK1.Hide();
            userControlDangKyTK1.Hide();
            userControlDVPhoBien1.Hide();
            userControlDoanhThuT1.Hide();
            userControlPhong1.Show();
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);
        }
        private void btnQLyphong_Click(object sender, EventArgs e)
        {
            userControlDanhGia1.Hide();
            userControlNhanVien1.Hide();
            userControlKH1.Hide();
            userControlDV1.Hide();
            userControlPhong1.Hide();
            userControlQLyPhong1.Hide();
            userControlDatPhong1.Hide();
            userControlHoaDon1.Hide();
            userControlTTTK1.Hide();
            userControlDoiMK1.Hide();
            userControlDangKyTK1.Hide();
            userControlDVPhoBien1.Hide();
            userControlDoanhThuT1.Hide();
            userControlQLyPhong1.Show();
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);
        }
        private void btnDP_Click(object sender, EventArgs e)
        {
            // hideSubMenu();
            userControlDanhGia1.Hide();
            userControlNhanVien1.Hide();
            userControlKH1.Hide();
            userControlDV1.Hide();
            userControlPhong1.Hide();
            userControlQLyPhong1.Hide();
            userControlDatPhong1.Hide();
            userControlHoaDon1.Hide();
            userControlTTTK1.Hide();
            userControlDoiMK1.Hide();
            userControlDangKyTK1.Hide();
            userControlDVPhoBien1.Hide();
            userControlDoanhThuT1.Hide();
            userControlDatPhong1.Show();
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            userControlDanhGia1.Hide();
            userControlNhanVien1.Hide();
            userControlKH1.Hide();
            userControlDV1.Hide();
            userControlPhong1.Hide();
            userControlQLyPhong1.Hide();
            userControlDatPhong1.Hide();
            userControlHoaDon1.Hide();
            userControlTTTK1.Hide();
            userControlDoiMK1.Hide();
            userControlDangKyTK1.Hide();
            userControlDVPhoBien1.Hide();
            userControlDoanhThuT1.Hide();
            userControlHoaDon1.Show();
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            // hideSubMenu();
            userControlDanhGia1.Hide();
            userControlNhanVien1.Hide();
            userControlKH1.Hide();
            userControlDV1.Hide();
            userControlPhong1.Hide();
            userControlQLyPhong1.Hide();
            userControlDatPhong1.Hide();
            userControlHoaDon1.Hide();
            userControlTTTK1.Hide();
            userControlDoiMK1.Hide();
            userControlDangKyTK1.Hide();
            userControlDVPhoBien1.Hide();
            userControlDoanhThuT1.Hide();
            userControlTTTK1.Show();
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            // hideSubMenu();
            userControlDanhGia1.Hide();
            userControlNhanVien1.Hide();
            userControlKH1.Hide();
            userControlDV1.Hide();
            userControlPhong1.Hide();
            userControlQLyPhong1.Hide();
            userControlDatPhong1.Hide();
            userControlHoaDon1.Hide();
            userControlTTTK1.Hide();
            userControlDoiMK1.Hide();
            userControlDangKyTK1.Hide();
            userControlDVPhoBien1.Hide();
            userControlDoanhThuT1.Hide();
            userControlDoiMK1.Show();
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btnDKi_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            userControlDanhGia1.Hide();
            userControlNhanVien1.Hide();
            userControlKH1.Hide();
            userControlDV1.Hide();
            userControlPhong1.Hide();
            userControlQLyPhong1.Hide();
            userControlDatPhong1.Hide();
            userControlHoaDon1.Hide();
            userControlTTTK1.Hide();
            userControlDoiMK1.Hide();
            userControlDangKyTK1.Hide();
            userControlDVPhoBien1.Hide();
            userControlDoanhThuT1.Hide();
            userControlDangKyTK1.Show();
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            // hideSubMenu();
            userControlDoanhThuT1.Hide();
            userControlDanhGia1.Hide();
            userControlNhanVien1.Hide();
            userControlKH1.Hide();
            userControlDV1.Hide();
            userControlPhong1.Hide();
            userControlQLyPhong1.Hide();
            userControlDatPhong1.Hide();
            userControlHoaDon1.Hide();
            userControlTTTK1.Hide();
            userControlDoiMK1.Hide();
            userControlDangKyTK1.Hide();
            userControlDVPhoBien1.Hide();
            userControlDoanhThuT1.Show();
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);
        }


        private void btnDVPB(object sender, EventArgs e)
        {
            //hideSubMenu();
            userControlDanhGia1.Hide();
            userControlNhanVien1.Hide();
            userControlKH1.Hide();
            userControlDV1.Hide();
            userControlPhong1.Hide();
            userControlQLyPhong1.Hide();
            userControlDatPhong1.Hide();
            userControlHoaDon1.Hide();
            userControlTTTK1.Hide();
            userControlDoiMK1.Hide();
            userControlDangKyTK1.Hide();
            userControlDVPhoBien1.Hide();
            userControlDoanhThuT1.Hide();
            userControlDVPhoBien1.Show();
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            userControlDanhGia1.Hide();
            userControlNhanVien1.Hide();
            userControlKH1.Hide();
            userControlDV1.Hide();
            userControlPhong1.Hide();
            userControlQLyPhong1.Hide();
            userControlDatPhong1.Hide();
            userControlHoaDon1.Hide();
            userControlTTTK1.Hide();
            userControlDoiMK1.Hide();
            userControlDangKyTK1.Hide();
            userControlDVPhoBien1.Hide();
            userControlDoanhThuT1.Hide();
            userControlDanhGia1.Show();
            
            HighlightButton((Guna.UI2.WinForms.Guna2Button)sender);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
        private Guna.UI2.WinForms.Guna2Button currentButton;

        private void HighlightButton(Guna.UI2.WinForms.Guna2Button btn)
        {
            if (currentButton != null)
            {
                ResetButtonColor ();
            }

            // Lưu Guna2Button hiện tại
            currentButton = btn;

            // Đặt màu nền mới cho Guna2Button hiện tại
            currentButton.FillColor = Color.FromArgb(58, 166, 107);

            // Thực hiện các hành động khác nếu cần
            // ...
        }

        private void ResetButtonColor()
        {
            if (currentButton != null)
            {
                // Reset màu nền của Guna2Button về màu mặc định
                currentButton.FillColor = Color.FromArgb(52, 73, 92);
            }
        }
    }
}
