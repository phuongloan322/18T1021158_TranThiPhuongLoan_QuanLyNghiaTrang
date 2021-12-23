using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNghiaTrang
{
    public class LietSi
    {
        public long ID { get; set; }
        public string HoVaTen { get; set; }
        public string QueQuan { get; set; }
        public string NgaySinh { get; set; }
        public string NgayHySinh { get; set; }
        public string ChucVu { get; set; }
        public string Donvi { get; set; }
        public string QuyTap { get; set; }
        public string MaPhanMo { get; set; }
        public string Anh { get; set; }

        public LietSi()
        {

        }

        public LietSi(long iD, string hoVaTen, string queQuan, string ngaySinh, string ngayHySinh, string chucVu, string donvi, string quyTap, string maPhanMo, string anh)
        {
            ID = iD;
            HoVaTen = hoVaTen;
            QueQuan = queQuan;
            NgaySinh = ngaySinh;
            NgayHySinh = ngayHySinh;
            ChucVu = chucVu;
            Donvi = donvi;
            QuyTap = quyTap;
            MaPhanMo = maPhanMo;
            Anh = anh;
        }

        public LietSi(string hoVaTen, string queQuan, string ngaySinh, string ngayHySinh, string chucVu, string donvi, string quyTap, string maPhanMo, string anh)
        {
            HoVaTen = hoVaTen;
            QueQuan = queQuan;
            NgaySinh = ngaySinh;
            NgayHySinh = ngayHySinh;
            ChucVu = chucVu;
            Donvi = donvi;
            QuyTap = quyTap;
            MaPhanMo = maPhanMo;
            Anh = anh;
        }
    }
}
