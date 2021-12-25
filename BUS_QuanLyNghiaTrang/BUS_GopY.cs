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
    public class BUS_GopY
    {
        DAL_GopY dalGopY = new DAL_GopY();

        public DataTable getGopY(string search)
        {
            return dalGopY.getGopY(search);
        }

        public bool ThemGopY(GopY gopY)
        {
            return dalGopY.ThemGopY(gopY);
        }

        public bool SuaGopY(GopY gopY)
        {
            return dalGopY.SuaGopY(gopY);
        }

        public int xoaGopY(string MaGopY)
        {
            return dalGopY.xoaGopY(MaGopY);
        }

        public bool DuyetXuLy(GopY gopY)
        {
            return dalGopY.DuyetXuLy(gopY);
        }
    }
}
