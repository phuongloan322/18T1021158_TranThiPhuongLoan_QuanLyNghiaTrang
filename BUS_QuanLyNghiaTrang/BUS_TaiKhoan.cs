using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNghiaTrang;
using DTO_QuanLyNghiaTrang;

namespace BUS_QuanLyNghiaTrang
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dalTaiKhoan = new DAL_TaiKhoan();

        public TaiKhoan CheckLogin(string username, string password)
        {
            return dalTaiKhoan.CheckLogin(username, password);
        }

        public int DangKy(TaiKhoan taiKhoan)
        {
            return dalTaiKhoan.DangKy(taiKhoan);
        }

        public TaiKhoan GetTaiKhoan(long MaTaiKhoan)
        {
            return dalTaiKhoan.GetTaiKhoan(MaTaiKhoan);
        }

        public int QuanLyTaiKhoan(TaiKhoan taiKhoan)
        {
            return dalTaiKhoan.QuanLyTaiKhoan(taiKhoan);
        }
    }
}
