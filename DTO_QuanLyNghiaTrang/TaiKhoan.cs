using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNghiaTrang
{
    public class TaiKhoan
    {
        public long MaTaiKhoan { get; set; }
        public string HoVaTen { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int Quyen { get; set; }

        public TaiKhoan(long maTaiKhoan, string hoVaTen, string tenDangNhap, string matKhau, int quyen)
        {
            MaTaiKhoan = maTaiKhoan;
            HoVaTen = hoVaTen;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            Quyen = quyen;
        }

        public TaiKhoan(string hoVaTen, string tenDangNhap, string matKhau, int quyen)
        {
            HoVaTen = hoVaTen;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            Quyen = quyen;
        }
    }
}
