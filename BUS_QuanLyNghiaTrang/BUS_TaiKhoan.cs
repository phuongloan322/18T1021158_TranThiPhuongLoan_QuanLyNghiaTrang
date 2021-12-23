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
    }
}
