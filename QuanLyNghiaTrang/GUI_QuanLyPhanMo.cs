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

namespace QuanLyNghiaTrang
{
    public partial class GUI_QuanLyPhanMo : Form
    {
        BUS_PhanMo busPhanMo = new BUS_PhanMo();
        bool tf, tf1;
        string maPhanMo;
        string solo, sohang, somo, tinhtrang = "";
        public GUI_QuanLyPhanMo()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadData("");
            tf = tf1 = true;
            Lock_unLock(tf);
            Lock_unLock1(tf1);
            dgvPhanMo.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            dgvPhanMo.EnableHeadersVisualStyles = false;
            dgvPhanMo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvPhanMo.ColumnHeadersHeight = 60;
        }

        void Lock_unLock(bool tf)
        {
            btnLuu.Visible = tf;
            btnThem.Visible = !tf;
            btnNew.Enabled = tf;
            btnThem.Enabled = txtMaPhanMo.Enabled = txtSoLo.Enabled = txtSoHang.Enabled = txtSoMo.Enabled = cmbTinhTrang.Enabled = !tf;
        }

        void Lock_unLock1(bool tf1)
        {
            dgvPhanMo.Enabled = tf1;
            btnLuu.Visible = !tf1;
            btnThem.Visible = tf1;
            btnLuu.Enabled = btnXoa.Enabled = txtMaPhanMo.Enabled = txtSoLo.Enabled = txtSoHang.Enabled = txtSoMo.Enabled = cmbTinhTrang.Enabled = !tf1;
            btnXem.Visible = !tf1;
        }

        private void LoadData(string search)
        {
            dgvPhanMo.DataSource = busPhanMo.getPhanMo(search);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rs = busPhanMo.deletePhanMo(maPhanMo);
            if (rs == 0)
            {
                MessageBox.Show("Xóa phần mộ thành công", "Info");
                LoadData("");
                tf1 = !tf1;
                Lock_unLock1(tf1);
            }
            else
            {
                MessageBox.Show("Xóa phần mộ thất bại \n Vui lòng thực hiện lại", "Info");
                Reset();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string SoLo = txtSoLo.Text;
            string SoHang = txtSoHang.Text;
            string SoMo = txtSoMo.Text;
            string TinhTrang = cmbTinhTrang.Text;

            if (SoLo!= "" && SoHang != "" && SoMo != "" && TinhTrang != "")
            {
                PhanMo  phanMo = new PhanMo(long.Parse(txtMaPhanMo.Text), int.Parse(txtSoLo.Text), int.Parse(txtSoHang.Text)
                    , int.Parse(txtSoMo.Text), cmbTinhTrang.Text);
                
                if(solo == SoLo && sohang == SoHang && somo == SoMo)        
                {
                    if(tinhtrang == "Đã sử dụng" && TinhTrang != "Đã sử dụng" && !busPhanMo.KiemTraPhanMoLietSi(int.Parse(SoLo), int.Parse(SoHang), int.Parse(SoMo)))
                    {
                        MessageBox.Show("Phần mộ này đã được sử dụng! \n Vui lòng kiểm tra lại bên phần liệt sĩ", "Info");
                        Reset();
                    }
                    else
                    {
                        int rs = busPhanMo.updatePhanMo(phanMo);        //k chỉnh sửa vị trí
                        if (rs == 0)
                        {
                            MessageBox.Show("Chỉnh sửa phần mộ thành công!", "Info");
                            LoadData("");
                            tf1 = !tf1;
                            Lock_unLock1(tf1);
                        }
                        else
                        {
                            MessageBox.Show("Chỉnh sửa phần mộ thất bại!", "Info");
                        }
                    }
                    
                }
                else
                {
                    if (busPhanMo.KiemTraPhanMo(int.Parse(SoLo), int.Parse(SoHang), int.Parse(SoMo)))   //chỉnh sửa vị trí
                    {
                        if (tinhtrang == "Đã sử dụng" && TinhTrang != "Đã sử dụng" && !busPhanMo.KiemTraPhanMoLietSi(int.Parse(SoLo), int.Parse(SoHang), int.Parse(SoMo)))
                        {
                            MessageBox.Show("Phần mộ này đã được sử dụng! \n Vui lòng kiểm tra lại bên phần liệt sĩ", "Info");
                            Reset();
                        }
                        else
                        {
                            int rs = busPhanMo.updatePhanMo(phanMo);
                            if (rs == 0)
                            {
                                MessageBox.Show("Chỉnh sửa phần mộ thành công!", "Info");
                                LoadData("");
                                tf1 = !tf1;
                                Lock_unLock1(tf1);
                            }
                            else
                            {
                                MessageBox.Show("Chỉnh sửa phần mộ thất bại!", "Info");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phần mộ này đã tồn tại! \n Vui lòng thực hiện lại", "Info");
                    }
                }

                
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Info");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string SoLo = txtSoLo.Text;
            string SoHang = txtSoHang.Text;
            string SoMo = txtSoMo.Text;

            if (SoLo != "" && SoHang != "" && SoMo != "" && cmbTinhTrang.Text != "")
            {
                PhanMo phanMo = new PhanMo(int.Parse(txtSoLo.Text), int.Parse(txtSoHang.Text), int.Parse(txtSoMo.Text), cmbTinhTrang.Text);
                
                if(busPhanMo.KiemTraPhanMo(int.Parse(SoLo), int.Parse(SoHang), int.Parse(SoMo)))
                {
                    int rs = busPhanMo.ThemPhanMo(phanMo);
                    if (rs == 0)
                    {
                        MessageBox.Show("Thêm phần mộ thành công!", "Info");
                        LoadData("");
                        tf = !tf;
                        Lock_unLock(tf);
                    }
                    else
                    {
                        MessageBox.Show("Thêm phần mộ thất bại! \n Vui lòng thực hiện lại", "Info");
                    }
                }
                else
                {
                    MessageBox.Show("Phần mộ này đã được sử dụng! \n Vui lòng thực hiện lại", "Info");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Info");
                txtMaPhanMo.Focus();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            txtSearch.Text = "";
            string[] vitri = search.Split('-');
            if(vitri.Length == 3)
            {
                DataTable dataSearch = busPhanMo.getPhanMoTimKiemViTri(int.Parse(vitri[0]), int.Parse(vitri[1]), int.Parse(vitri[2]));
                if (dataSearch.Rows.Count == 0)
                {
                    LoadData("");
                    MessageBox.Show("Không tìm thấy kết quả!", "Info");
                }
                else
                {
                    dgvPhanMo.DataSource = dataSearch;
                    int soHang = dgvPhanMo.Rows.Count - 1;
                    lblSearch.Text = "Kết quả tìm kiếm: " + soHang + " phần mộ";
                    lblSearch.Visible = true;
                }
            }
            else if(vitri.Length > 1 && vitri.Length != 3)
            {
                    MessageBox.Show("Vui lòng nhập Vị trí mộ đúng format Lô-Hàng-Mộ\n Ví dụ: 1-1-11", "Info");
            }
            else
            {
                DataTable dataSearch = busPhanMo.getPhanMo(search);
                if(dataSearch.Rows.Count == 0)
                {
                    LoadData("");
                    MessageBox.Show("Không tìm thấy kết quả!", "Info");
                }
                else
                {
                    dgvPhanMo.DataSource = busPhanMo.getPhanMo(search);
                    int soHang = dgvPhanMo.Rows.Count - 1;
                    lblSearch.Text = "Kết quả tìm kiếm: " + soHang + " phần mộ";
                    lblSearch.Visible = true;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tf1)
            {
                tf = !tf;
                Lock_unLock(tf);
                txtMaPhanMo.Text = txtSoLo.Text = txtSoHang.Text = txtSoMo.Text = cmbTinhTrang.Text = "";
            }
            else
            {
                MessageBox.Show("Đang xem chi tiết. Vui lòng nhấn Reset để thực hiện lại!", "Info");
            }
        }

        private void txtMaPhanMo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            GUI_ThemLietSi frmThem = new GUI_ThemLietSi(txtMaPhanMo.Text);
            frmThem.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            viewReportPhanMo viewPhanMo = new viewReportPhanMo();
            viewPhanMo.Show();
        }

        private void Reset()
        {
            tf = tf1 = true;
            Lock_unLock(tf);
            Lock_unLock1(tf1);
            LoadData("");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgvPhanMo_Click(object sender, EventArgs e)
        {
            if (dgvPhanMo.Enabled)
            {
                int i = dgvPhanMo.CurrentRow.Index;
                maPhanMo = dgvPhanMo[0, i].Value.ToString();
                txtMaPhanMo.Text = dgvPhanMo[0, i].Value.ToString();
                solo = txtSoLo.Text = dgvPhanMo[1, i].Value.ToString();
                sohang = txtSoHang.Text = dgvPhanMo[2, i].Value.ToString();
                somo = txtSoMo.Text = dgvPhanMo[3, i].Value.ToString();
                tinhtrang = cmbTinhTrang.Text = dgvPhanMo[4, i].Value.ToString();
                tf1 = !tf1;
                Lock_unLock1(tf1);
                
            }
            else
            {
                MessageBox.Show("Đang thực hiện thêm phần mộ! \n Vui lòng nhấn Reset để thực hiện lại!", "Info");
            }
        }
    }
}
