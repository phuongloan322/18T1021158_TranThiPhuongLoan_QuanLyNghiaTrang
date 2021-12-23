using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyNghiaTrang;
using DAL_QuanLyNghiaTrang;
using System.Data;
using System.Data.SqlClient;

namespace BUS_QuanLyNghiaTrang
{
    public class BUS_PhanMo
    {
        DAL_PhanMo dalPhanMo = new DAL_PhanMo();
        public DataTable getPhanMo(string search)
        {
            return dalPhanMo.getPhanMo(search);
        }

        public DataTable getPhanMoTimKiemViTri(int SoLo, int SoHang, int SoMo)
        {
            return dalPhanMo.getPhanMoTimKiemViTri(SoLo, SoHang, SoMo);
        }

        public bool KiemTraPhanMo(int SoLo, int SoHang, int SoMo)
        {
            return dalPhanMo.KiemTraPhanMo(SoLo, SoHang, SoMo);
        }

        public long getMaPhanMo(int SoLo, int SoHang, int SoMo)
        {
            return dalPhanMo.getMaPhanMo(SoLo, SoHang, SoMo);
        }

        public bool KiemTraPhanMoLietSi(int SoLo, int SoHang, int SoMo)
        {
            return dalPhanMo.KiemTraPhanMoLietSi(SoLo, SoHang, SoMo);
        }

        public int ThemPhanMo(PhanMo phanMo)
        {
            return dalPhanMo.ThemPhanMo(phanMo);
        }

        public int updatePhanMo(PhanMo phanMo)
        {
            return dalPhanMo.updatePhanMo(phanMo);
        }

        public int deletePhanMo(string MaPhanMo)
        {
            return dalPhanMo.deletePhanMo(MaPhanMo);
        }
    }
}
