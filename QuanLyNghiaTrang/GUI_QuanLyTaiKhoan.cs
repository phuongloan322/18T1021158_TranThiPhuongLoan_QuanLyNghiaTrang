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
    public partial class GUI_QuanLyTaiKhoan : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        BUS_Crypto busCrypt = new BUS_Crypto();

        TaiKhoan taikhoan = null;
        long MaTaiKhoan;

        public GUI_QuanLyTaiKhoan(long maTaiKhoan)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            MaTaiKhoan = maTaiKhoan;
            LoadAccount();
        }

        public void LoadAccount()
        {
            taikhoan = busTaiKhoan.GetTaiKhoan(MaTaiKhoan);
            if(taikhoan != null)
            {
                txtHoVaTen.Text = taikhoan.HoVaTen;
                txtTenDangNhap.Text = taikhoan.TenDangNhap;
            }
        }

        public void Notification(string msg)
        {
            lblNotification.Text = msg;
            lblNotification.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string HoVaTen = txtHoVaTen.Text;
            string TenDangNhap = txtTenDangNhap.Text;
            string MatKhauCu = txtMatKhauCu.Text;
            string MatKhauMoi = txtMatKhauMoi.Text;
            string MatKhauMoiAgain = txtMatKhauMoiAgain.Text;

            if(MatKhauCu == "")
            {
                TaiKhoan taikhoanmoi = new TaiKhoan(HoVaTen, TenDangNhap, "", 1);
                int rs = busTaiKhoan.QuanLyTaiKhoan(taikhoanmoi);
                if(rs == 0)
                {
                    MessageBox.Show("Thay đổi thông tin thành công!", "Info");
                    LoadAccount();
                    lblNotification.Visible = false;
                }
                else if (rs == -1)
                {
                    Notification("Dữ liệu rỗng! Vui lòng thực hiện lại!");
                }
                else if (rs == 1)
                {
                    Notification("Tài khoản không tồn tại!");
                }
            }
            else
            {
                string passwordHash = busCrypt.Decrypt(taikhoan.MatKhau);

                if (MatKhauMoi != MatKhauMoiAgain)
                {
                    Notification("Nhập lại mật khẩu không chính xác!");
                }
                else if(MatKhauCu == passwordHash)
                {
                    string MatKhauMoiHash = busCrypt.Encrypt(MatKhauMoi);
                    TaiKhoan taikhoanmoi = new TaiKhoan(HoVaTen, TenDangNhap, MatKhauMoiHash, 1);
                    int rs = busTaiKhoan.QuanLyTaiKhoan(taikhoanmoi);
                    if (rs == 0)
                    {
                        MessageBox.Show("Thay đổi thông tin thành công!", "Info");
                        LoadAccount();
                        lblNotification.Visible = false;
                    }
                    else if (rs == -1)
                    {
                        Notification("Dữ liệu rỗng! Vui lòng thực hiện lại!");
                    }
                    else if (rs == 1)
                    {
                        Notification("Tài khoản không tồn tại!");
                    }
                }
                else if (MatKhauCu != passwordHash)
                {
                    Notification("Mật khẩu xác nhận không chính xác!");
                }

                txtMatKhauCu.Text = txtMatKhauMoi.Text = txtMatKhauMoiAgain.Text = "";
            }
        }
    }
}
