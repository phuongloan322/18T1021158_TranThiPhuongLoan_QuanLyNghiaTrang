using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyNghiaTrang;
using DTO_QuanLyNghiaTrang;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNghiaTrang
{
    public partial class GUI_QuanLyGopY : Form
    {
        BUS_GopY busGopY = new BUS_GopY();
        bool tf, tf1;
        string maGopY, tieuDe, nguoiGopY, ngayGui, xuLy;
        public GUI_QuanLyGopY()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadData("");
            tf = tf1 = true;
            Lock();
            dgvGopY.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            dgvGopY.EnableHeadersVisualStyles = false;
            dgvGopY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvGopY.ColumnHeadersHeight = 60;
        }

        private void dgvGopY_Click(object sender, EventArgs e)
        {
            if (tf1)
            {
                int i = dgvGopY.CurrentRow.Index;
                maGopY = dgvGopY[0, i].Value.ToString();
                nguoiGopY = txtNguoiGopY.Text = dgvGopY[2, i].Value.ToString();
                tieuDe = txtTieude.Text = dgvGopY[1, i].Value.ToString();
                ngayGui = dateNgayGui.Text = dgvGopY[3, i].Value.ToString();
                xuLy = cmbXuLy.Text = dgvGopY[4, i].Value.ToString();
                tf = false;
                unLockEdit();
                if (xuLy == "Đã xử lý")
                {
                    btnDuyet.Visible = false;
                   
                }
                else
                {
                    btnDuyet.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Đang thực hiện thêm phần mộ! \n Vui lòng nhấn Reset để thực hiện lại!", "Info");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void LoadData(string search)
        {
            dgvGopY.DataSource = busGopY.getGopY(search);
            lblSearch.Text = "";
        }

        public void XuLyNgay()
        {
            string ngaytam = dateNgayGui.Value.ToString().Substring(0, 10);
            string[] ngay = ngaytam.Split('/');
            ngayGui = ngay[2] + "-" + ngay[1] + "-" + ngay[0];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tieuDe = txtTieude.Text;
            nguoiGopY = txtNguoiGopY.Text;
            xuLy = cmbXuLy.Text;
            XuLyNgay();

            Console.WriteLine(ngayGui);

            if (tieuDe != ""  && nguoiGopY != "" && ngayGui != "" && xuLy != "")
            {
                GopY gopy = new GopY(tieuDe, nguoiGopY, ngayGui, xuLy);

                if (busGopY.ThemGopY(gopy))
                {
                    MessageBox.Show("Thêm góp ý thành công!", "Info");
                    Reset();
                }
                else
                {
                    MessageBox.Show("Thêm góp ý thất bại! \n Vui lòng thực hiện lại", "Info");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Info");
                txtTieude.Focus();
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            tieuDe = txtTieude.Text;
            nguoiGopY = txtNguoiGopY.Text;
            xuLy = cmbXuLy.Text;
            XuLyNgay();

            if (tieuDe != "" && nguoiGopY != "" && ngayGui != "" && xuLy != "")
            {
                GopY gopy = new GopY(long.Parse(maGopY), tieuDe, nguoiGopY, ngayGui, "Đã xử lý");

                if (busGopY.DuyetXuLy(gopy))
                {
                    MessageBox.Show("Duyệt thông tin góp ý thành công!", "Info");
                    LoadData("");
                    Lock();
                }
                else
                {
                    MessageBox.Show("Duyệt thông tin góp ý thất bại! \n Vui lòng thực hiện lại", "Info");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu trống! \nVui lòng thực hiện lại!", "Info");
                txtTieude.Focus();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tieuDe = txtTieude.Text;
            nguoiGopY = txtNguoiGopY.Text;
            xuLy = cmbXuLy.Text;
            XuLyNgay();

            if (tieuDe != "" && nguoiGopY != "" && ngayGui != "" && xuLy != "")
            {
                GopY gopy = new GopY(long.Parse(maGopY), tieuDe, nguoiGopY, ngayGui, xuLy);

                if (busGopY.SuaGopY(gopy))
                {
                    MessageBox.Show("Chỉnh sửa góp ý thành công!", "Info");
                    LoadData("");
                    Lock();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa góp ý thất bại! \n Vui lòng thực hiện lại", "Info");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Info");
                txtTieude.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (maGopY != "" && maGopY != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa Góp ý " + tieuDe + " không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int rs = busGopY.xoaGopY(maGopY);
                    if (rs == 0)
                    {
                        MessageBox.Show("Xóa thông tin góp ý thành công", "Info");
                        LoadData("");
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin góp ý thất bại \n Vui lòng thực hiện lại", "Info");
                        Reset();
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Dữ liệu trống. Vui lòng thực hiện lại!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtTieude.Text = txtNguoiGopY.Text = "";
            string search = txtSearch.Text;
            txtSearch.Text = "";
            DataTable dataSearch = busGopY.getGopY(search);
            if (dataSearch.Rows.Count == 0)
            {
                LoadData("");
                MessageBox.Show("Không tìm thấy kết quả!", "Info");
            }
            else
            {
                LoadData(search);
                int soHang = dgvGopY.Rows.Count - 1;
                lblSearch.Text = "Kết quả tìm kiếm: " + soHang + " góp ý";
                lblSearch.Visible = true;
            }
            
        }

        void Lock()
        {
            btnLuu.Visible = btnDuyet.Visible = btnThem.Visible = false;
            txtNguoiGopY.Enabled = txtTieude.Enabled = dateNgayGui.Enabled = cmbXuLy.Enabled = false;
            tf = tf1 = true;
        }

        void unLockAdd()
        {
            btnThem.Visible = true;
            txtNguoiGopY.Enabled = txtTieude.Enabled = dateNgayGui.Enabled = cmbXuLy.Enabled = true;
            btnLuu.Visible = false;
        }

        void unLockEdit()
        {
            btnLuu.Visible = true;
            txtNguoiGopY.Enabled = txtTieude.Enabled = dateNgayGui.Enabled = cmbXuLy.Enabled = true;
            btnThem.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tf)
            {
                tf1 = false;
                unLockAdd();
                txtNguoiGopY.Text = txtTieude.Text = "";
                cmbXuLy.Text = "Chưa xử lý";
            }
            else
            {
                MessageBox.Show("Đang xem chi tiết. Vui lòng nhấn Reset để thực hiện lại!", "Info");
            }
        }

        private void Reset()
        {
            tf = true;
            Lock();
            LoadData("");
            txtTieude.Text = txtNguoiGopY.Text = "";
        }
    }
}
