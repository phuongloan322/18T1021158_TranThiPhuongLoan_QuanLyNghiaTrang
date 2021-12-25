using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BUS_QuanLyNghiaTrang;
using DTO_QuanLyNghiaTrang;

namespace QuanLyNghiaTrang
{
    public partial class GUI_DanhSachLietSi : Form
    {
        BUS_LietSi busLietSi = new BUS_LietSi();
        BUS_PhanMo busPhanMo = new BUS_PhanMo();
        public GUI_DanhSachLietSi()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadData("");
            LoadForm();
            dgvLietSi.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            dgvLietSi.EnableHeadersVisualStyles = false;
            dgvLietSi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvLietSi.ColumnHeadersHeight = 60;
        }

        private void LoadData(string search)
        {
            dgvLietSi.DataSource = busLietSi.getLietSi(search);
            ResetSearch();
        }

        public void ResetSearch()
        {
            txtHoVaTen.Text = "Họ và tên...";
            txtNamSinh.Text = "Năm sinh...";
            txtNamHySinh.Text = "Năm hy sinh...";
            txtNguyenQuan.Text = "Quê quán...";
            txtViTriMo.Text = "Vị trí mộ...";
        }

        private void dgvLietSi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            pnlTT.Enabled = false;
            string HoVaTen = txtHoVaTen.Text;
            string NgaySinh = txtNamSinh.Text;
            string NgayHySinh = txtNamHySinh.Text;
            string QueQuan = txtNguyenQuan.Text;
            string ViTriMo = txtViTriMo.Text;
            if (HoVaTen == "Họ và tên...")
                HoVaTen = "";
            if (NgaySinh == "Năm sinh...")
                NgaySinh = "";
            if (NgayHySinh == "Năm hy sinh...")
                NgayHySinh = "";
            if (QueQuan == "Quê quán...")
                QueQuan = "";
            if (ViTriMo == "Vị trí mộ...")
                ViTriMo = "";
            
            if(ViTriMo != "")
            {
                string[] vitri = ViTriMo.Split('-');
                if(vitri.Length == 3)
                {
                    long MaPhanMo = busPhanMo.getMaPhanMo(int.Parse(vitri[0]), int.Parse(vitri[1]), int.Parse(vitri[2]));
                    if(MaPhanMo != 0)
                    {
                        dgvLietSi.DataSource = busLietSi.getLietSi(HoVaTen, NgaySinh, NgayHySinh, QueQuan, MaPhanMo);
                        int soHang = dgvLietSi.Rows.Count - 1;
                        lblSearch.Text = "Kết quả tìm kiếm: " + soHang + " liệt sĩ";
                        lblSearch.Visible = true;
                    }
                    else
                    {
                        LoadData("");
                        MessageBox.Show("Không tìm thấy kết quả!", "Info");
                    }   
                }
                else 
                {
                    MessageBox.Show("Vui lòng nhập Vị trí mộ đúng format Lô-Hàng-Mộ\n Ví dụ: 1-1-11", "Info");
                }
            }
            else
            {
                dgvLietSi.DataSource = busLietSi.getLietSi(HoVaTen, NgaySinh, NgayHySinh, QueQuan, 0);
                int soHang = dgvLietSi.Rows.Count - 1;
                lblSearch.Text = "Kết quả tìm kiếm: " + soHang + " liệt sĩ";
                lblSearch.Visible = true;
            }
            ResetSearch();
        }

        private void txtHoVaTen_Enter(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == "Họ và tên...")
            {
                txtHoVaTen.Text = "";
            }
        }

        private void txtHoVaTen_Leave(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == "")
            {
                txtHoVaTen.Text = "Họ và tên...";
            }
        }

        private void txtNamSinh_Enter(object sender, EventArgs e)
        {
            if (txtNamSinh.Text == "Năm sinh...")
            {
                txtNamSinh.Text = "";
            }
        }

        private void txtNamSinh_Leave(object sender, EventArgs e)
        {
            if (txtNamSinh.Text == "")
            {
                txtNamSinh.Text = "Năm sinh...";
            }
        }

        private void txtNamHySinh_Enter(object sender, EventArgs e)
        {
            if (txtNamHySinh.Text == "Năm hy sinh...")
            {
                txtNamHySinh.Text = "";
            }
        }

        private void txtNamHySinh_Leave(object sender, EventArgs e)
        {
            if (txtNamHySinh.Text == "")
            {
                txtNamHySinh.Text = "Năm hy sinh...";
            }
        }

        private void txtNguyenQuan_Enter(object sender, EventArgs e)
        {
            if (txtNguyenQuan.Text == "Quê quán...")
            {
                txtNguyenQuan.Text = "";
            }
        }

        private void txtNguyenQuan_Leave(object sender, EventArgs e)
        {
            if (txtNguyenQuan.Text == "")
            {
                txtNguyenQuan.Text = "Quê quán...";
            }
        }

        private void txtViTriMo_Enter(object sender, EventArgs e)
        {
            if (txtViTriMo.Text == "Vị trí mộ...")
            {
                txtViTriMo.Text = "";
            }
        }

        private void txtViTriMo_Leave(object sender, EventArgs e)
        {
            if (txtViTriMo.Text == "")
            {
                txtViTriMo.Text = "Vị trí mộ...";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            LoadData("");
            lblMa.Text = "";
            txtHoTen.Text = "";
            txtQueQuan.Text = "";
            txtTTNamSinh.Text = "";
            txtTTNamHySinh.Text = "";
            txtChucVu.Text = "";
            txtDonVi.Text = "";
            cmbViTriMo.Text = "";
            pnlTT.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GUI_ThemLietSi frmThem = new GUI_ThemLietSi(LoadData);
            frmThem.Show();
        }


        public void LoadForm()
        {
            cmbQuyTap.Items.Add("Đã quy tập");
            cmbQuyTap.Items.Add("Chưa quy tập");
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

        private void dgvLietSi_Click(object sender, EventArgs e)
        {
            pnlTT.Enabled = true;
        
            int i = dgvLietSi.CurrentRow.Index;
            lblMa.Text = dgvLietSi[0, i].Value.ToString();
            txtHoTen.Text = dgvLietSi[1, i].Value.ToString();
            txtQueQuan.Text = dgvLietSi[2, i].Value.ToString();
            txtTTNamSinh.Text = dgvLietSi[3, i].Value.ToString();
            txtTTNamHySinh.Text = dgvLietSi[4, i].Value.ToString();
            txtChucVu.Text = dgvLietSi[5, i].Value.ToString();
            txtDonVi.Text = dgvLietSi[6, i].Value.ToString();
            cmbQuyTap.Text = dgvLietSi[7, i].Value.ToString();
            cmbViTriMo.Text = dgvLietSi[14, i].Value.ToString();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maXoa = lblMa.Text;
            if (maXoa != null || maXoa == "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa liệt sĩ " + txtHoTen.Text + " không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int rs = busLietSi.deleteLietSi(long.Parse(maXoa));
                    if (rs == 0)
                        MessageBox.Show(this, "Xóa thành công!");
                    else if (rs == -1)
                        MessageBox.Show(this, "Dữ liệu trống. Vui lòng thực hiện lại!");
                    else if (rs == -2)
                        MessageBox.Show(this, "Không tìm thấy dữ liệu. Vui lòng thực hiện lại!");
                    else if (rs == -3)
                        MessageBox.Show(this, "Dữ liệu này không thể xóa được. Vui lòng thực hiện lại!!");
                    LoadData("");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ID = lblMa.Text;
            string HoVaTen = txtHoTen.Text;
            string NgaySinh = txtTTNamSinh.Text;
            string NgayHySinh = txtTTNamHySinh.Text;
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
                LietSi lietSi = new LietSi(long.Parse(ID), HoVaTen, QueQuan, NgaySinh, NgayHySinh, ChucVu, DonVi, QuyTap, MaPhanMo.ToString(), Anh);

                if (busLietSi.updateLietSi(lietSi))
                {
                    MessageBox.Show("Chỉnh sửa phần mộ liệt sĩ thành công", "Info");
                    LoadData("");
                    Reset();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa phần mộ liệt sĩ thất bại", "Info");
                }
            }
            else
            {
                MessageBox.Show("Tên liệt sĩ không được trống. \n Vui lòng nhập đầy đủ thông tin!", "Info");
                txtHoVaTen.Focus();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            viewReportLietSi viewReportLiet = new viewReportLietSi();
            viewReportLiet.Show();
        }
    }
}
