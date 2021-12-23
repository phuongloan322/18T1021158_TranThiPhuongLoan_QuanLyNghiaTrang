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
    public class BUS_Album
    {
        DAL_Album dalAlbum = new DAL_Album();
        public DataTable getAlbum()
        {
            return dalAlbum.getAlbum();
        }

        public bool ThemAlbum(Album album)
        {
            return dalAlbum.ThemAlbum(album);
        }

        public bool updateAlbumAboutPic(Album album)
        {
            return dalAlbum.updateAlbumAboutPic(album);
        }

        public bool updateAlbum(Album album)
        {
            return dalAlbum.updateAlbum(album);
        }

        public int deleteAlbum(string MaAlbum)
        {
            return dalAlbum.deleteAlbum(MaAlbum);
        }
    }
}
