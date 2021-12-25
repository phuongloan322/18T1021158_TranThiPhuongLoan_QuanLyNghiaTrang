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
    public class DAL_GopY:DBConnection
    {
        public DataTable getGopY(string search)
        {
            List<PhanMo> phanmoList = new List<PhanMo>();
            string sql = "SELECT * FROM func_GopY_Tim_Kiem(@Search)";
            SqlParam[] input = { new SqlParam("@Search", search) };
            DataTable dataTable = excuteQuery(sql, input);
            dataTable.Columns.Add("Ord");
            for (int i = 1; i < dataTable.Rows.Count + 1; i++)
            {
                dataTable.Rows[i - 1]["Ord"] = i.ToString();
            }
            return dataTable;
        }

        public bool ThemGopY(GopY gopY)
        {
            String st = String.Format("insert into GopY  values(N'{0}', N'{1}', N'{2}', N'{3}')",
                gopY.TieuDe, gopY.NguoiGopY, gopY.NgayGui, gopY.XuLy);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(st, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;
        }

        public bool SuaGopY(GopY gopY)
        {
            String st = String.Format("update GopY set TieuDe = N'{0}', NguoiGopY = N'{1}', NgayGui = N'{2}', XuLy = N'{3}' where MaGopY = N'{4}' ",
                 gopY.TieuDe, gopY.NguoiGopY, gopY.NgayGui, gopY.XuLy, gopY.MaGopY);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(st, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;
        }

        public bool DuyetXuLy(GopY gopY)
        {
            String st = String.Format("update GopY set XuLy = N'{0}' where MaGopY = N'{1}' ",
                 gopY.XuLy, gopY.MaGopY);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(st, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;
        }

        public int xoaGopY(string MaGopY)
        {
            string sql = "EXEC proc_GopY_Xoa @MaGopY, @Result OUT";
            SqlParam[] input = { new SqlParam("@MaGopY", MaGopY) };
            SqlParam[] output = { new SqlParam("@Result", 0) };

            object[] res = excuteProc(sql, input, output);

            return (int)res[0];
        }
    }
}
