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
    public class DAL_LietSi:DBConnection
    {
        public DataTable getLietSi(string search)
        {
            List<LietSi> lietsiLiet = new List<LietSi>();
            string sql = "SELECT * FROM func_LietSi()";
            SqlParam[] input = { new SqlParam("@Search", search) };
            DataTable dataTable = excuteQuery(sql, input);
            dataTable.Columns.Add("Ord");
            dataTable.Columns.Add("PhanKhu");
            
            DataRowCollection rows = dataTable.Rows;
            
                for (int i = 1; i < dataTable.Rows.Count + 1; i++)
                {
                    dataTable.Rows[i - 1]["Ord"] = i.ToString();
                    dataTable.Rows[i - 1]["PhanKhu"] = dataTable.Rows[i - 1]["SoLo"].ToString() + "-" + dataTable.Rows[i - 1]["SoHang"].ToString() + "-" + dataTable.Rows[i - 1]["SoMo"].ToString();
                    
                }
            
            return dataTable;
        }


        public DataTable getLietSi(string HoVaTen, string NgaySinh, string NgayHySinh, string QueQuan, long MaPhanMo )
        {
            List<LietSi> lietsiLiet = new List<LietSi>();
            string sql = "SELECT * FROM func_LS_TimKiem(@HoVaTen, @NgaySinh, @NgayHySinh, @QueQuan, @MaPhanMo)";
            SqlParam[] input = {
                new SqlParam("@HoVaTen", HoVaTen ),
                new SqlParam("@QueQuan", QueQuan ),
                new SqlParam("@NgaySinh", NgaySinh ),
                new SqlParam("@NgayHySinh", NgayHySinh ),
                new SqlParam("@MaPhanMo", MaPhanMo),
            };
            DataTable dataTable = excuteQuery(sql, input);
            dataTable.Columns.Add("Ord");
            dataTable.Columns.Add("PhanKhu");

            DataRowCollection rows = dataTable.Rows;

            for (int i = 1; i < dataTable.Rows.Count + 1; i++)
            {
                dataTable.Rows[i - 1]["Ord"] = i.ToString();
                dataTable.Rows[i - 1]["PhanKhu"] = dataTable.Rows[i - 1]["SoLo"].ToString() + "-" + dataTable.Rows[i - 1]["SoHang"].ToString() + "-" + dataTable.Rows[i - 1]["SoMo"].ToString();

            }

            return dataTable;
        }

        public LietSi GetLietSiByMaPhanMo(long MaPhanMo)
        {
            try
            {
                string sql = string.Format("select * from LietSi where MaPhanMo = '{0}'", MaPhanMo);
                LietSi lietSi = null;
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                DataRowCollection dataRowCollection = dataTable.Rows;
                foreach (DataRow dataRow in dataRowCollection)
                {

                    lietSi = new LietSi(long.Parse(dataRow[0].ToString()),
                                        dataRow[1].ToString(),
                                        dataRow[2].ToString(),
                                        dataRow[3].ToString(),
                                        dataRow[4].ToString(),
                                        dataRow[5].ToString(),
                                        dataRow[6].ToString(),
                                        dataRow[7].ToString(),
                                        dataRow[8].ToString(),
                                        dataRow[9].ToString());
                }
                return lietSi;
            }
            catch
            {
                con.Close();
                return null;
            }
        }

        public int addLietSi(LietSi lietsi)
        {
            int res = 0;
            string sql = "EXEC proc_LietSi_Them @HoVaTen, @QueQuan, @NgaySinh, @NgayHySinh, @ChucVu, @DonVi, @QuyTap, @MaPhanMo, @Anh, @Result OUT";
            SqlParam[] input =
            {
                new SqlParam("@HoVaTen", lietsi.HoVaTen),
                new SqlParam("@QueQuan", lietsi.QueQuan),
                new SqlParam("@NgaySinh", lietsi.NgaySinh),
                new SqlParam("@NgayHySinh", lietsi.NgayHySinh),
                new SqlParam("@ChucVu", lietsi.ChucVu),
                new SqlParam("@DonVi", lietsi.Donvi),
                new SqlParam("@QuyTap", lietsi.QuyTap),
                new SqlParam("@MaPhanMo", lietsi.MaPhanMo),
                new SqlParam("@Anh", lietsi.Anh),
            };
            SqlParam[] output = { new SqlParam("@Result", 0) };
            object[] rs = excuteProc(sql, input, output);
            res = (int)rs[0];
            return res;
        }

        public bool ThemLietSi(LietSi lietsi)
        {
            String st = String.Format("INSERT INTO LietSi(HoVaTen, QueQuan, NgaySinh, NgayHySinh, ChucVu, DonVi, QuyTap, MaPhanMo, Anh) VALUES(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', '{7}', '{8}')",
                lietsi.HoVaTen, lietsi.QueQuan, lietsi.NgaySinh, lietsi.NgayHySinh, lietsi.ChucVu, lietsi.Donvi, lietsi.QuyTap, lietsi.MaPhanMo, lietsi.Anh);
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

        public bool updateLietSi(LietSi lietsi)
        {
            String st = String.Format("UPDATE LietSi SET HoVaTen = N'{0}', QueQuan = N'{1}', NgaySinh = N'{2}', NgayHySinh = N'{3}',ChucVu = N'{4}', DonVi = N'{5}', QuyTap = N'{6}', MaPhanMo = N'{7}' , Anh = N'{8}' WHERE ID = N'{9}'",
                lietsi.HoVaTen, lietsi.QueQuan, lietsi.NgaySinh, lietsi.NgayHySinh, lietsi.ChucVu, lietsi.Donvi, lietsi.QuyTap, lietsi.MaPhanMo, lietsi.Anh, lietsi.ID);
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

        public int deleteLietSi(long ID)
        {
            string sql = "EXEC proc_LietSi_Xoa @ID, @Result OUT";
            SqlParam[] input = { new SqlParam("@ID", ID) };
            SqlParam[] output = { new SqlParam("@Result", 0) };

            object[] res = excuteProc(sql, input, output);

            return (int)res[0];
        }

    }
}
