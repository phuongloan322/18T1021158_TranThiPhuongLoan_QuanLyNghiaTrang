using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLyNghiaTrang;
using BUS_QuanLyNghiaTrang;


namespace QuanLyNghiaTrang
{
    public partial class GUI_DangKy : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        BUS_Crypto busCrypt = new BUS_Crypto();

        public GUI_DangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string HoVaTen = txtHoVaTen.Text;
            string TenDangNhap = txtTaiKhoan.Text;
            string MatKhau = txtMatKhau.Text;
            string MatKhauRep = txtMatKhauRep.Text;

            if(MatKhau == MatKhauRep)
            {
                string MatKhauHash = busCrypt.Encrypt(MatKhau);
                TaiKhoan taiKhoan = new TaiKhoan(HoVaTen, TenDangNhap, MatKhauHash, 1);
                int rs = busTaiKhoan.DangKy(taiKhoan);
                if(rs == -1)
                {
                    lblNotification.Visible = true;
                    lblNotification.Text = "Vui lòng nhập đầy đủ thông tin";
                }
                else if (rs == -2)
                {
                    lblNotification.Visible = true;
                    lblNotification.Text = "Tên đăng nhập đã tồn tại!";
                    txtTaiKhoan.Focus();
                }
                else if(rs == 0)
                {
                    GUI_Login guiLogin = new GUI_Login();
                    this.Hide();
                    guiLogin.Show();
                }
            }
            else
            {
                lblNotification.Text = "Nhập lại mật khẩu không chính xác";
                lblNotification.Visible = true;
                txtMatKhauRep.Text = txtMatKhau.Text = "";
                txtMatKhau.Focus();
            }
        }

        private void GUI_DangKy_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {
            GUI_Login guiLogin = new GUI_Login();
            this.Hide();
            guiLogin.Show();
        }
    }
}
