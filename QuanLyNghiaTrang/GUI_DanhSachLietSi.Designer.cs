
namespace QuanLyNghiaTrang
{
    partial class GUI_DanhSachLietSi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvLietSi = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguyenQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyTap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanKhuNghiaTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhanMo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoMo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pnlTT = new System.Windows.Forms.Panel();
            this.cmbViTriMo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTTNamHySinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTTNamSinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cmbQuyTap = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtViTriMo = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtNguyenQuan = new System.Windows.Forms.TextBox();
            this.txtNamHySinh = new System.Windows.Forms.TextBox();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLietSi)).BeginInit();
            this.panel7.SuspendLayout();
            this.pnlTT.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1543, 717);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.pnlTT);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1543, 584);
            this.panel4.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvLietSi);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(446, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1020, 584);
            this.panel8.TabIndex = 3;
            // 
            // dgvLietSi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Honeydew;
            this.dgvLietSi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLietSi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLietSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLietSi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ID,
            this.HoVaTen,
            this.Anh,
            this.NamSinh,
            this.NamHySinh,
            this.NguyenQuan,
            this.ChucVu,
            this.DonVi,
            this.QuyTap,
            this.PhanKhuNghiaTrang,
            this.MaPhanMo,
            this.SoLo,
            this.SoHang,
            this.SoMo});
            this.dgvLietSi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLietSi.Location = new System.Drawing.Point(0, 0);
            this.dgvLietSi.Name = "dgvLietSi";
            this.dgvLietSi.RowHeadersVisible = false;
            this.dgvLietSi.RowHeadersWidth = 51;
            this.dgvLietSi.RowTemplate.Height = 32;
            this.dgvLietSi.Size = new System.Drawing.Size(1020, 584);
            this.dgvLietSi.TabIndex = 0;
            this.dgvLietSi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLietSi_CellValueChanged);
            this.dgvLietSi.Click += new System.EventHandler(this.dgvLietSi_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "Ord";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 60;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // HoVaTen
            // 
            this.HoVaTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoVaTen.DataPropertyName = "HoVaTen";
            this.HoVaTen.HeaderText = "Họ và tên";
            this.HoVaTen.MinimumWidth = 6;
            this.HoVaTen.Name = "HoVaTen";
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "Anh";
            this.Anh.HeaderText = "Anh";
            this.Anh.MinimumWidth = 6;
            this.Anh.Name = "Anh";
            this.Anh.Visible = false;
            this.Anh.Width = 125;
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NgaySinh";
            this.NamSinh.HeaderText = "Năm sinh";
            this.NamSinh.MinimumWidth = 6;
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Width = 125;
            // 
            // NamHySinh
            // 
            this.NamHySinh.DataPropertyName = "NgayHySinh";
            this.NamHySinh.HeaderText = "Năm Hy Sinh";
            this.NamHySinh.MinimumWidth = 6;
            this.NamHySinh.Name = "NamHySinh";
            this.NamHySinh.Width = 125;
            // 
            // NguyenQuan
            // 
            this.NguyenQuan.DataPropertyName = "QueQuan";
            this.NguyenQuan.FillWeight = 200F;
            this.NguyenQuan.HeaderText = "Nguyên Quán";
            this.NguyenQuan.MinimumWidth = 6;
            this.NguyenQuan.Name = "NguyenQuan";
            this.NguyenQuan.Width = 200;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 125;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.MinimumWidth = 6;
            this.DonVi.Name = "DonVi";
            this.DonVi.Width = 125;
            // 
            // QuyTap
            // 
            this.QuyTap.DataPropertyName = "QuyTap";
            this.QuyTap.HeaderText = "Trạng thái Quy Tập";
            this.QuyTap.MinimumWidth = 6;
            this.QuyTap.Name = "QuyTap";
            this.QuyTap.Width = 125;
            // 
            // PhanKhuNghiaTrang
            // 
            this.PhanKhuNghiaTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhanKhuNghiaTrang.DataPropertyName = "PhanKhu";
            this.PhanKhuNghiaTrang.HeaderText = "Phân khu nghĩa trang (Lô - Hàng - Số mộ)";
            this.PhanKhuNghiaTrang.MinimumWidth = 6;
            this.PhanKhuNghiaTrang.Name = "PhanKhuNghiaTrang";
            // 
            // MaPhanMo
            // 
            this.MaPhanMo.DataPropertyName = "MaPhanMo";
            this.MaPhanMo.HeaderText = "Mã phần mộ";
            this.MaPhanMo.MinimumWidth = 6;
            this.MaPhanMo.Name = "MaPhanMo";
            this.MaPhanMo.Visible = false;
            this.MaPhanMo.Width = 125;
            // 
            // SoLo
            // 
            this.SoLo.DataPropertyName = "SoLo";
            this.SoLo.HeaderText = "Số lô";
            this.SoLo.MinimumWidth = 6;
            this.SoLo.Name = "SoLo";
            this.SoLo.Visible = false;
            this.SoLo.Width = 125;
            // 
            // SoHang
            // 
            this.SoHang.DataPropertyName = "SoHang";
            this.SoHang.HeaderText = "Số hàng";
            this.SoHang.MinimumWidth = 6;
            this.SoHang.Name = "SoHang";
            this.SoHang.Visible = false;
            this.SoHang.Width = 125;
            // 
            // SoMo
            // 
            this.SoMo.DataPropertyName = "SoMo";
            this.SoMo.HeaderText = "Số mộ";
            this.SoMo.MinimumWidth = 6;
            this.SoMo.Name = "SoMo";
            this.SoMo.Visible = false;
            this.SoMo.Width = 125;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnPrint);
            this.panel7.Controls.Add(this.btnReset);
            this.panel7.Controls.Add(this.btnXoa);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1466, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(77, 584);
            this.panel7.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.BackgroundImage = global::QuanLyNghiaTrang.Properties.Resources.printer;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(21, 155);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(43, 34);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.BackgroundImage = global::QuanLyNghiaTrang.Properties.Resources.circle_of_two_clockwise_arrows_rotation;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(22, 85);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(43, 34);
            this.btnReset.TabIndex = 11;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(22, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(43, 40);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "X";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pnlTT
            // 
            this.pnlTT.Controls.Add(this.cmbViTriMo);
            this.pnlTT.Controls.Add(this.label10);
            this.pnlTT.Controls.Add(this.txtQueQuan);
            this.pnlTT.Controls.Add(this.label9);
            this.pnlTT.Controls.Add(this.txtDonVi);
            this.pnlTT.Controls.Add(this.label8);
            this.pnlTT.Controls.Add(this.txtChucVu);
            this.pnlTT.Controls.Add(this.label7);
            this.pnlTT.Controls.Add(this.txtTTNamHySinh);
            this.pnlTT.Controls.Add(this.label6);
            this.pnlTT.Controls.Add(this.txtTTNamSinh);
            this.pnlTT.Controls.Add(this.label5);
            this.pnlTT.Controls.Add(this.label2);
            this.pnlTT.Controls.Add(this.btnLuu);
            this.pnlTT.Controls.Add(this.cmbQuyTap);
            this.pnlTT.Controls.Add(this.txtHoTen);
            this.pnlTT.Controls.Add(this.label3);
            this.pnlTT.Controls.Add(this.label4);
            this.pnlTT.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTT.Enabled = false;
            this.pnlTT.Location = new System.Drawing.Point(0, 0);
            this.pnlTT.Name = "pnlTT";
            this.pnlTT.Size = new System.Drawing.Size(446, 584);
            this.pnlTT.TabIndex = 1;
            // 
            // cmbViTriMo
            // 
            this.cmbViTriMo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbViTriMo.FormattingEnabled = true;
            this.cmbViTriMo.Location = new System.Drawing.Point(110, 450);
            this.cmbViTriMo.Name = "cmbViTriMo";
            this.cmbViTriMo.Size = new System.Drawing.Size(293, 24);
            this.cmbViTriMo.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Quê quán";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueQuan.Location = new System.Drawing.Point(110, 125);
            this.txtQueQuan.Multiline = true;
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(293, 34);
            this.txtQueQuan.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Đơn vị";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonVi.Location = new System.Drawing.Point(110, 344);
            this.txtDonVi.Multiline = true;
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(293, 34);
            this.txtDonVi.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Chức vụ";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChucVu.Location = new System.Drawing.Point(110, 289);
            this.txtChucVu.Multiline = true;
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(293, 34);
            this.txtChucVu.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Năm hy sinh";
            // 
            // txtTTNamHySinh
            // 
            this.txtTTNamHySinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTTNamHySinh.Location = new System.Drawing.Point(110, 235);
            this.txtTTNamHySinh.Multiline = true;
            this.txtTTNamHySinh.Name = "txtTTNamHySinh";
            this.txtTTNamHySinh.Size = new System.Drawing.Size(293, 34);
            this.txtTTNamHySinh.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Năm sinh";
            // 
            // txtTTNamSinh
            // 
            this.txtTTNamSinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTTNamSinh.Location = new System.Drawing.Point(110, 179);
            this.txtTTNamSinh.Multiline = true;
            this.txtTTNamSinh.Name = "txtTTNamSinh";
            this.txtTTNamSinh.Size = new System.Drawing.Size(293, 34);
            this.txtTTNamSinh.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "THÔNG TIN LIỆT SĨ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Họ và tên (*)";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.Green;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(295, 510);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 46);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cmbQuyTap
            // 
            this.cmbQuyTap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbQuyTap.FormattingEnabled = true;
            this.cmbQuyTap.Location = new System.Drawing.Point(110, 401);
            this.cmbQuyTap.Name = "cmbQuyTap";
            this.cmbQuyTap.Size = new System.Drawing.Size(293, 24);
            this.cmbQuyTap.TabIndex = 21;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.Location = new System.Drawing.Point(110, 73);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(293, 34);
            this.txtHoTen.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vị trí mộ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tình trạng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSearch);
            this.panel3.Controls.Add(this.lblMa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1543, 58);
            this.panel3.TabIndex = 1;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(21, 18);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(46, 17);
            this.lblMa.TabIndex = 10;
            this.lblMa.Text = "label2";
            this.lblMa.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtViTriMo);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.txtNguyenQuan);
            this.panel2.Controls.Add(this.txtNamHySinh);
            this.panel2.Controls.Add(this.txtNamSinh);
            this.panel2.Controls.Add(this.txtHoVaTen);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1543, 75);
            this.panel2.TabIndex = 0;
            // 
            // txtViTriMo
            // 
            this.txtViTriMo.Location = new System.Drawing.Point(1013, 17);
            this.txtViTriMo.Multiline = true;
            this.txtViTriMo.Name = "txtViTriMo";
            this.txtViTriMo.Size = new System.Drawing.Size(168, 33);
            this.txtViTriMo.TabIndex = 6;
            this.txtViTriMo.Enter += new System.EventHandler(this.txtViTriMo_Enter);
            this.txtViTriMo.Leave += new System.EventHandler(this.txtViTriMo_Leave);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(1421, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 40);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(1210, 14);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(126, 40);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtNguyenQuan
            // 
            this.txtNguyenQuan.Location = new System.Drawing.Point(824, 17);
            this.txtNguyenQuan.Multiline = true;
            this.txtNguyenQuan.Name = "txtNguyenQuan";
            this.txtNguyenQuan.Size = new System.Drawing.Size(168, 33);
            this.txtNguyenQuan.TabIndex = 4;
            this.txtNguyenQuan.Enter += new System.EventHandler(this.txtNguyenQuan_Enter);
            this.txtNguyenQuan.Leave += new System.EventHandler(this.txtNguyenQuan_Leave);
            // 
            // txtNamHySinh
            // 
            this.txtNamHySinh.Location = new System.Drawing.Point(636, 17);
            this.txtNamHySinh.Multiline = true;
            this.txtNamHySinh.Name = "txtNamHySinh";
            this.txtNamHySinh.Size = new System.Drawing.Size(168, 33);
            this.txtNamHySinh.TabIndex = 3;
            this.txtNamHySinh.Enter += new System.EventHandler(this.txtNamHySinh_Enter);
            this.txtNamHySinh.Leave += new System.EventHandler(this.txtNamHySinh_Leave);
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(439, 18);
            this.txtNamSinh.Multiline = true;
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(168, 32);
            this.txtNamSinh.TabIndex = 2;
            this.txtNamSinh.Enter += new System.EventHandler(this.txtNamSinh_Enter);
            this.txtNamSinh.Leave += new System.EventHandler(this.txtNamSinh_Leave);
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(252, 18);
            this.txtHoVaTen.Multiline = true;
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(168, 32);
            this.txtHoVaTen.TabIndex = 1;
            this.txtHoVaTen.Enter += new System.EventHandler(this.txtHoVaTen_Enter);
            this.txtHoVaTen.Leave += new System.EventHandler(this.txtHoVaTen_Leave);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 73);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin tìm kiếm:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(446, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(69, 20);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "label11";
            this.lblSearch.Visible = false;
            // 
            // GUI_DanhSachLietSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 717);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_DanhSachLietSi";
            this.Text = "GUI_DanhSachLietSi";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLietSi)).EndInit();
            this.panel7.ResumeLayout(false);
            this.pnlTT.ResumeLayout(false);
            this.pnlTT.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNguyenQuan;
        private System.Windows.Forms.TextBox txtNamHySinh;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.DataGridView dgvLietSi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtViTriMo;
        private System.Windows.Forms.Panel pnlTT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTTNamHySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTTNamSinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cmbQuyTap;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.ComboBox cmbViTriMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguyenQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuyTap;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanKhuNghiaTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhanMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoMo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblSearch;
    }
}