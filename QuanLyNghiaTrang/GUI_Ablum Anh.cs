using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyNghiaTrang;
using DTO_QuanLyNghiaTrang;

namespace QuanLyNghiaTrang
{
    public partial class GUI_Ablum_Anh : Form
    {
        BUS_Album busAlbum = new BUS_Album();

        string imageLocation = "";
        string maAlbum = "";

        public GUI_Ablum_Anh()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            dgvAlbum.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(187)))), ((int)(((byte)(153)))));
            dgvAlbum.EnableHeadersVisualStyles = false;
            dgvAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAlbum.ColumnHeadersHeight = 60;
        }

        public void LoadData()
        {
            dgvAlbum.Rows.Clear();
            txtMa.Enabled = true;
            DataTable data = busAlbum.getAlbum();
                foreach (DataRow row in data.Rows)
                {
                    try
                    {
                        byte[] img = File.ReadAllBytes(row["AnhDaiDien"].ToString());
                        dgvAlbum.Rows.Add(row["Ord"], row["MaAlbum"], row["TenBoAnh"], img);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không tìm thấy file:" + row["AnhDaiDien"].ToString());
                    }
            }
        }

        public void Reset()
        {
            txtMa.Text = "";
            txtTieuDe.Text = "";
            pic1.Image = null;
            btnAdd.Enabled = true;
            txtMa.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void GUI_Ablum_Anh_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            dgvImage.HeaderText = "Hình ảnh";
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewTextBoxColumn dgvSTT = new DataGridViewTextBoxColumn();
            dgvSTT.HeaderText = "STT";

            DataGridViewTextBoxColumn dgvId = new DataGridViewTextBoxColumn();
            dgvId.HeaderText = "Mã Album";

            DataGridViewTextBoxColumn dgvTieuDe = new DataGridViewTextBoxColumn();
            dgvTieuDe.HeaderText = "Tiêu đề ảnh";

            dgvAlbum.Columns.Add(dgvSTT);
            dgvAlbum.Columns.Add(dgvId);
            dgvAlbum.Columns.Add(dgvTieuDe);
            dgvAlbum.Columns.Add(dgvImage);

            dgvAlbum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlbum.RowTemplate.Height = 200;

            dgvAlbum.AllowUserToAddRows = false;

            LoadData();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName;
                pic1.Image = Image.FromFile(imageLocation);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                string maAlbum = txtMa.Text;
                string TenBoAnh = txtTieuDe.Text;
                string AnhDaiDien = imageLocation;

                Album album = new Album(maAlbum, TenBoAnh, AnhDaiDien);

                if(maAlbum != "" && TenBoAnh != null && AnhDaiDien != "")
                {
                    if(busAlbum.ThemAlbum(album))
                    {
                        MessageBox.Show("Thêm album ảnh thành công!", "Info");
                        LoadData();
                        Reset();
                }
                    else
                    {
                        MessageBox.Show("Thêm album ảnh thất bại! \n Vui lòng thực hiện lại", "Info");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Info");
                    txtMa.Focus();
                }
        }

        private void dgvAlbum_Click(object sender, EventArgs e)
        {
            int i = dgvAlbum.CurrentRow.Index;
            maAlbum = txtMa.Text = dgvAlbum[1, i].Value.ToString();
            txtTieuDe.Text = dgvAlbum[2, i].Value.ToString();
            MemoryStream ms = new MemoryStream((byte[])dgvAlbum.CurrentRow.Cells[3].Value);
            pic1.Image = Image.FromStream(ms);
            txtMa.Enabled = false;
            btnAdd.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maAlbum = txtMa.Text;
            string TenBoAnh = txtTieuDe.Text;
            string AnhDaiDien = imageLocation;

            Album album = new Album(maAlbum, TenBoAnh, AnhDaiDien);

            if (maAlbum != "" && TenBoAnh != null)
            {
                if(AnhDaiDien != "")
                {
                    if (busAlbum.updateAlbumAboutPic(album))
                    {
                        MessageBox.Show("Chỉnh sửa album ảnh thành công!", "Info");
                        dgvAlbum.Rows.Clear();
                        LoadData();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa album ảnh thất bại! \n Vui lòng thực hiện lại", "Info");
                    }
                }
                else
                {
                    if (busAlbum.updateAlbum(album))
                    {
                        MessageBox.Show("Chỉnh sửa album ảnh thành công!", "Info");
                        dgvAlbum.Rows.Clear();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa album ảnh thất bại! \n Vui lòng thực hiện lại", "Info");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Info");
                txtMa.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maAlbum != null && maAlbum != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa Ablum số " + maAlbum + " không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int rs = busAlbum.deleteAlbum(maAlbum);
                    if (rs == 0)
                        MessageBox.Show(this, "Xóa thành công!");
                    else if (rs == -1)
                        MessageBox.Show(this, "Dữ liệu trống. Vui lòng thực hiện lại!");
                    else if (rs == -2)
                        MessageBox.Show(this, "Không tìm thấy dữ liệu. Vui lòng thực hiện lại!");
                    else if (rs == -3)
                        MessageBox.Show(this, "Dữ liệu này không thể xóa được. Vui lòng thực hiện lại!!");
                    LoadData();
                    Reset();
                }
            }
            else
            {
                MessageBox.Show(this, "Dữ liệu trống. Vui lòng thực hiện lại!");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
