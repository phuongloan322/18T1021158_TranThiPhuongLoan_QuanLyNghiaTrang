using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyNghiaTrang;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLyNghiaTrang
{
    public class DAL_PhanMo:DBConnection
    {
        public DataTable getPhanMo(string search)
        {
            List<PhanMo> phanmoList = new List<PhanMo>();
            string sql = "SELECT * FROM func_PhanMo_Tim_Kiem(@Search)";
            SqlParam[] input = { new SqlParam("@Search", search) };
            DataTable dataTable = excuteQuery(sql, input);
            dataTable.Columns.Add("Ord");
            for (int i = 1; i < dataTable.Rows.Count + 1; i++)
            {
                dataTable.Rows[i - 1]["Ord"] = i.ToString();
            }
            return dataTable;
        }

        public DataTable getPhanMoTimKiemViTri(int SoLo, int SoHang, int SoMo)
        {
            List<PhanMo> phanmoList = new List<PhanMo>();
            string sql = "SELECT * FROM func_PhanMo_Tim_Kiem_Vi_Tri(@SoLo, @SoHang, @SoMo)";
            SqlParam[] input = { new SqlParam("@SoLo", SoLo),
                                new SqlParam("@SoHang", SoHang),
                                new SqlParam("@SoMo", SoMo)};

            DataTable dataTable = excuteQuery(sql, input);
            dataTable.Columns.Add("Ord");
            for (int i = 1; i < dataTable.Rows.Count + 1; i++)
            {
                dataTable.Rows[i - 1]["Ord"] = i.ToString();
            }
            return dataTable;
        }

        public bool KiemTraPhanMo(int SoLo, int SoHang, int SoMo)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from QuanLyPhanMo where SoLo = '"+SoLo+ "' and SoHang = '" + SoHang + "' and SoMo = '" + SoMo + "'", con );
            DataTable daStudent = new DataTable();
            da.Fill(daStudent);
            if (daStudent.Rows.Count == 0)
                return true;
            else
                return false;
        }

        public long getMaPhanMo(int SoLo, int SoHang, int SoMo)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from QuanLyPhanMo where SoLo = '" + SoLo + "' and SoHang = '" + SoHang + "' and SoMo = '" + SoMo + "'", con);
            DataTable daStudent = new DataTable();
            da.Fill(daStudent);
            return long.Parse(daStudent.Rows[0][0].ToString());
        }

        public bool KiemTraPhanMoLietSi(int SoLo, int SoHang, int SoMo)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from LietSi where MaPhanMo in (select MaPhanMo from QuanLyPhanMo where SoLo = '" + SoLo + "' and SoHang = '" + SoHang + "' and SoMo = '" + SoMo + "')", con);
            DataTable daStudent = new DataTable();
            da.Fill(daStudent);
            if (daStudent.Rows.Count == 0)
                return true;
            else
                return false;
        }



        public int ThemPhanMo(PhanMo phanMo)
        {
            String st = String.Format("insert into QuanLyPhanMo(SoLo, SoHang, SoMo, TinhTrang) values(N'{0}', N'{1}', N'{2}', N'{3}')",
                phanMo.SoLo, phanMo.SoHang, phanMo.SoMo, phanMo.TinhTrang);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(st, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                con.Close();
                return -1;
            }
            con.Close();
            return 0;
        }

        public int updatePhanMo(PhanMo phanMo)
        {
            String st = String.Format("update QuanLyPhanMo set SoLo = N'{0}', SoHang = N'{1}', SoMo = N'{2}', TinhTrang = N'{3}' WHERE MaPhanMo = N'{4}'", 
                phanMo.SoLo, phanMo.SoHang, phanMo.SoMo, phanMo.TinhTrang, phanMo.MaPhanMo);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(st, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                con.Close();
                return -1;
            }
            con.Close();
            return 0;
        }

        public int deletePhanMo(string MaPhanMo)
        {
            string sql = "EXEC proc_PhanMo_Xoa @MaPhanMo, @Result OUT";
            SqlParam[] input = { new SqlParam("@MaPhanMo", MaPhanMo) };
            SqlParam[] output = { new SqlParam("@Result", 0) };

            object[] res = excuteProc(sql, input, output);

            return (int)res[0];
        }
    }
}
