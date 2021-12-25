using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyNghiaTrang;
using DTO_QuanLyNghiaTrang;

namespace QuanLyNghiaTrang
{
    public partial class GUI_Login : Form
    {
        BUS_TaiKhoan busLogin = new BUS_TaiKhoan();
        BUS_Crypto busCrypt = new BUS_Crypto();

        public GUI_Login()
        {
            InitializeComponent();
            lblNotification.Text = "";
        }

        public void Reset()
        {
            txtTaiKhoan.Text = txtMatKhau.Text = lblNotification.Text = "";
        }
        

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;

            TaiKhoan taiKhoan = busLogin.CheckLogin(username, password);

            if (taiKhoan != null)
            {
                string passwordHash = busCrypt.Decrypt(taiKhoan.MatKhau);

                if (String.IsNullOrEmpty(username))
                {
                    lblNotification.Text = "Tài khoản không được để trống.";
                }
                else if (String.IsNullOrEmpty(password))
                {
                    lblNotification.Text = "Mật khẩu không được để trống.";
                }

                else if (password == passwordHash)
                {
                    Reset();
                    GUI_Main frm = new GUI_Main(taiKhoan.MaTaiKhoan);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    lblNotification.Text = "Đăng nhập không thành công, tài khoản hoặc mật khẩu bị sai.";
                }
            }
            else
            {
                lblNotification.Text = "Tài khoản không tồn tại";
            }
            
        }

        private void GUI_Login_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void lblDangKy_Click(object sender, EventArgs e)
        {
            GUI_DangKy guiDangKy = new GUI_DangKy();
            this.Hide();
            guiDangKy.Show();
        }
    }
}
