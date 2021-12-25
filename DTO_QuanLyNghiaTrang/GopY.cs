using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyNghiaTrang
{
    public class GopY
    {
        public long MaGopY { get; set; }
        public string TieuDe { get; set; }
        public string NguoiGopY { get; set; }
        public string NgayGui { get; set; }
        public string XuLy { get; set; }

        public GopY(long maGopY, string tieuDe, string nguoiGopY, string ngayGui, string xuLy)
        {
            MaGopY = maGopY;
            TieuDe = tieuDe;
            NguoiGopY = nguoiGopY;
            NgayGui = ngayGui;
            XuLy = xuLy;
        }
        public GopY(string tieuDe, string nguoiGopY, string ngayGui, string xuLy)
        {
            TieuDe = tieuDe;
            NguoiGopY = nguoiGopY;
            NgayGui = ngayGui;
            XuLy = xuLy;
        }
    }
}
