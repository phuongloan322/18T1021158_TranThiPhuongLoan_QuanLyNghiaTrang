using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNghiaTrang
{
    public delegate void SendMsg(string value);

    public partial class GUI_Main : Form
    {

        bool tf1, tf2, tf3;
        public GUI_Main()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            tf1 = false;
            tf2 = false;
            tf3 = false;
            pnlView.Show();
        }

        public void setColor(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.DarkSeaGreen;
        }

        public void unsetColor(Button btn)
        {
            btn.ForeColor = Color.White;
            btn.BackColor = Color.DarkSeaGreen;
        }


        private void GUI_Main_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
            setColor(btnTrangChu);
            GUI_Home gui_home = new GUI_Home();
            gui_home.TopLevel = false;
            pnlView.Controls.Add(gui_home);
            pnlView.Dock = DockStyle.Fill;
            gui_home.Show();
        }

        private void btnPhanMo_Click(object sender, EventArgs e)
        {
            setColor(btnPhanMo);
            unsetColor(btnDanhSachLietSi);unsetColor(btnTrangChu); unsetColor(btnAlbumAnh);
            GUI_QuanLyPhanMo guiPhanMo = new GUI_QuanLyPhanMo();
            guiPhanMo.TopLevel = false;
            pnlView.Controls.Add(guiPhanMo);
            pnlView.Dock = DockStyle.Fill;
            guiPhanMo.Show();
        }

        private void btnAlbumAnh_Click(object sender, EventArgs e)
        {
            setColor(btnAlbumAnh);
            unsetColor(btnDanhSachLietSi); unsetColor(btnPhanMo); unsetColor(btnTrangChu);
            GUI_Ablum_Anh guiAlbumAnh = new GUI_Ablum_Anh();
            guiAlbumAnh.TopLevel = false;
            pnlView.Controls.Add(guiAlbumAnh);
            pnlView.Dock = DockStyle.Fill;
            guiAlbumAnh.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            setColor(btnTrangChu);
            unsetColor(btnDanhSachLietSi); unsetColor(btnPhanMo); unsetColor(btnAlbumAnh);
            GUI_Home gui_home = new GUI_Home();
            gui_home.TopLevel = false;
            pnlView.Controls.Add(gui_home);
            pnlView.Dock = DockStyle.Fill;
            gui_home.Show();
        }


        private void btnDanhSachLietSi_Click(object sender, EventArgs e)
        {
            setColor(btnDanhSachLietSi);
            unsetColor(btnPhanMo); unsetColor(btnTrangChu); unsetColor(btnAlbumAnh);
            GUI_DanhSachLietSi guiLietSi = new GUI_DanhSachLietSi();
            guiLietSi.TopLevel = false;
            pnlView.Controls.Add(guiLietSi);
            pnlView.Dock = DockStyle.Fill;
            guiLietSi.Show();
        }
    }
}
