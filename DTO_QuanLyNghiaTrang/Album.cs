using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNghiaTrang
{
    public class Album
    {
        public string MaAlbum;
        public string TenBoAnh;
        public string AnhDaiDien;

        public Album(string maAlbum, string tenBoAnh, string anh)
        {
            MaAlbum = maAlbum;
            TenBoAnh = tenBoAnh;
            AnhDaiDien = anh;
        }
    }
}
