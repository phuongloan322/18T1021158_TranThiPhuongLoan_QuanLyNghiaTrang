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
    public class DAL_TaiKhoan:DBConnection
    {
        public TaiKhoan CheckLogin(string username, string password)
        {
            try
            {
                string sql = string.Format("select * from TaiKhoan where TenDangNhap = '{0}'", username);
                TaiKhoan taiKhoan = null;
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                DataRowCollection dataRowCollection = dataTable.Rows;
                foreach (DataRow dataRow in dataRowCollection)
                {
                    
                   taiKhoan =  new TaiKhoan(long.Parse(dataRow[0].ToString()),
                                                        dataRow[1].ToString(),
                                                        dataRow[2].ToString(), 
                                                        dataRow[3].ToString(),
                                                        int.Parse(dataRow[4].ToString()));
                }
                return taiKhoan;
            }
            catch
            {
                con.Close();
                return null;
            }
        }

        public int DangKy(TaiKhoan taiKhoan)
        {
            string sql = "EXEC proc_TK_Tao @HoVaTen, @TenDangNhap, @MatKhau, @Quyen, @Result OUT";
            SqlParam[] input = { new SqlParam("@HoVaTen", taiKhoan.HoVaTen),
                                new SqlParam("@TenDangNhap", taiKhoan.TenDangNhap),
                                new SqlParam("@MatKhau", taiKhoan.MatKhau),
                                new SqlParam("@Quyen", taiKhoan.Quyen)};
            SqlParam[] output = { new SqlParam("@Result", 0) };

            object[] res = excuteProc(sql, input, output);

            return (int)res[0];
        }
    }
}
