using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLyNghiaTrang;
using BUS_QuanLyNghiaTrang;

namespace QuanLyNghiaTrang
{
    public partial class GUI_ThemLietSi : Form
    {
        BUS_LietSi busLietSi = new BUS_LietSi();
        BUS_PhanMo busPhanMo = new BUS_PhanMo();
        public SendMsg send;
        string MaPhanMo;
        public GUI_ThemLietSi(SendMsg sender)
        {
            InitializeComponent();
            this.send = sender;
            LoadForm();
            this.CenterToParent();
        }
        public GUI_ThemLietSi(string ma)
        {
            InitializeComponent();
            LoadForm();
            this.CenterToParent();
            MaPhanMo = ma;
            if (ma != null)
            {
                btnThem.Visible = false;
            }
            LoadData();
            lblTitleAdd.Text = "Chi tiết thông tin phần mộ";
        }


            public void LoadData()
        {
            if(MaPhanMo != null)
            {
                LietSi lietSi = busLietSi.GetLietSiByMaPhanMo(long.Parse(MaPhanMo));
                txtHoVaTen.Text = lietSi.HoVaTen;
                txtChucVu.Text = lietSi.ChucVu;
                txtDonVi.Text = lietSi.Donvi;
                txtNamSinh.Text = lietSi.NgaySinh;
                txtNamHySinh.Text = lietSi.NgayHySinh;
                txtQueQuan.Text = lietSi.QueQuan;
                cmbQuyTap.Text = lietSi.QuyTap;
                cmbViTriMo.Text = lietSi.MaPhanMo;
                label1.Visible =  cmbViTriMo.Visible = false;
            }
        }

        public void LoadForm()
        {

            cmbQuyTap.Items.Add("Đã quy tập");
            cmbQuyTap.Text = "Chưa quy tập";

            DataTable dataPhanMo = busPhanMo.getPhanMo("Còn trống");
            for (int i = 0; i < dataPhanMo.Rows.Count; i++)
            {
                string vitrimo = dataPhanMo.Rows[i][1].ToString() + "-"
                                + dataPhanMo.Rows[i][2].ToString() + "-"
                                + dataPhanMo.Rows[i][3].ToString();
                cmbViTriMo.Items.Add(vitrimo);
                cmbViTriMo.Text = dataPhanMo.Rows[0][1].ToString() + "-"
                                + dataPhanMo.Rows[0][2].ToString() + "-"
                                + dataPhanMo.Rows[0][3].ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string HoVaTen = txtHoVaTen.Text;
            string NgaySinh = txtNamSinh.Text;
            string NgayHySinh = txtNamHySinh.Text;
            string QueQuan = txtQueQuan.Text;
            string ChucVu = txtChucVu.Text;
            string DonVi = txtDonVi.Text;
            string QuyTap = cmbQuyTap.Text;
            string ViTriMo = cmbViTriMo.Text;
            string Anh = null;

            
            if (HoVaTen != "" && ViTriMo != "")
            {
                string[] vitri = ViTriMo.Split('-');
                long MaPhanMo = busPhanMo.getMaPhanMo(int.Parse(vitri[0]), int.Parse(vitri[1]), int.Parse(vitri[2]));
                LietSi lietSi = new LietSi(HoVaTen, QueQuan, NgaySinh, NgayHySinh, ChucVu, DonVi, QuyTap, MaPhanMo.ToString(), Anh);

                if (busLietSi.ThemLietSi(lietSi))
                {
                    PhanMo phanMo = new PhanMo(MaPhanMo, int.Parse(vitri[0]), int.Parse(vitri[1]), int.Parse(vitri[2]), "Đã sử dụng");
                    int rs = busPhanMo.updatePhanMo(phanMo);
                    MessageBox.Show("Thêm phần mộ liệt sĩ thành công", "Info");
                    this.send("");
                    this.Close();
                }
                else
                {
                    this.Close();
                    MessageBox.Show("Thêm phần mộ liệt sĩ thất bại", "Info");
                }
            }
            else
            {
                MessageBox.Show("Tên liệt sĩ không được trống. \n Vui lòng nhập đầy đủ thông tin!", "Info");
                txtHoVaTen.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtHoVaTen.Text = txtChucVu.Text = txtDonVi.Text = txtNamSinh.Text = txtNamHySinh.Text = txtQueQuan.Text = "";
            this.Close();
        }
    }
}
