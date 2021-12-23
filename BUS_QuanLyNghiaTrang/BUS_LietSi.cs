using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNghiaTrang;
using DTO_QuanLyNghiaTrang;
using System.Data;
using System.Data.SqlClient;

namespace BUS_QuanLyNghiaTrang
{
    
    public class BUS_LietSi
    {
        DAL_LietSi dalLietSi = new DAL_LietSi();

        public DataTable getLietSi(string search)
        {
            return dalLietSi.getLietSi(search);
        }

        public DataTable getLietSi(string HoVaTen, string NgaySinh, string NgayHySinh, string QueQuan, long MaPhanMo)
        {
            return dalLietSi.getLietSi(HoVaTen, NgaySinh, NgayHySinh, QueQuan, MaPhanMo);
        }

        public LietSi GetLietSiByMaPhanMo(long MaPhanMo)
        {
            return dalLietSi.GetLietSiByMaPhanMo(MaPhanMo);
        }
/*
        public int addLietSi(LietSi lietsi)
        {
            return dalLietSi.addLietSi(lietsi);
        }*/

        public bool ThemLietSi(LietSi lietsi)
        {
            return dalLietSi.ThemLietSi(lietsi);
        }

        public bool updateLietSi(LietSi lietsi)
        {
            return dalLietSi.updateLietSi(lietsi);
        }

        public int deleteLietSi(long ID)
        {
            return dalLietSi.deleteLietSi(ID);
        }
    }
}
