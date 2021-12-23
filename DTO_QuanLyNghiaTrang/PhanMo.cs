using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNghiaTrang
{
    public class PhanMo
    {
        public long MaPhanMo;
        public int SoLo;
        public int SoHang;
        public int SoMo;
        public string TinhTrang;

        public PhanMo(long maPhanMo, int soLo, int soHang, int soMo, string tinhTrang)
        {
            MaPhanMo = maPhanMo;
            SoLo = soLo;
            SoHang = soHang;
            SoMo = soMo;
            TinhTrang = tinhTrang;
        }
        public PhanMo(int soLo, int soHang, int soMo, string tinhTrang)
        {
            SoLo = soLo;
            SoHang = soHang;
            SoMo = soMo;
            TinhTrang = tinhTrang;
        }

    }
}
