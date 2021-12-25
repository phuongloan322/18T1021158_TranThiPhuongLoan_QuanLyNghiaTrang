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
    public class DAL_Album:DBConnection
    {
        public DataTable getAlbum()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from AlbumAnh", con);
            DataTable daAlbum = new DataTable();
            da.Fill(daAlbum);
            daAlbum.Columns.Add("Ord");
            for (int i = 1; i < daAlbum.Rows.Count + 1; i++)
            {
                daAlbum.Rows[i - 1]["Ord"] = i.ToString();
            }
            return daAlbum;
        }

        public bool ThemAlbum(Album album)
        {
            String st = String.Format("insert into AlbumAnh  values(N'{0}', N'{1}', N'{2}')",
                album.MaAlbum, album.TenBoAnh, album.AnhDaiDien);
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

        public bool updateAlbumAboutPic(Album album)
        {
            String st = String.Format("update AlbumAnh set TenBoAnh = N'{0}', AnhDaiDien = N'{1}' where MaAlbum = N'{2}' ",
                album.TenBoAnh, album.AnhDaiDien, album.MaAlbum);
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

        public bool updateAlbum(Album album)
        {
            String st = String.Format("update AlbumAnh set TenBoAnh = N'{0}' where MaAlbum = N'{1}' ",
                album.TenBoAnh, album.MaAlbum);
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
        public int deleteAlbum(string MaAlbum)
        {
            string sql = "EXEC proc_Album_Xoa @MaAlbum, @Result OUT";
            SqlParam[] input = { new SqlParam("@MaAlbum", MaAlbum) };
            SqlParam[] output = { new SqlParam("@Result", 0) };

            object[] res = excuteProc(sql, input, output);

            return (int)res[0];
        }
    }
}
