namespace btl
{
    partial class UserControlPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPhong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTim = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoGiuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoNguoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbLoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDG = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvPhong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.BorderRadius = 10;
            this.btnTim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.btnTim.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(1402, 71);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(119, 60);
            this.btnTim.TabIndex = 104;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(670, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(872, 146);
            this.groupBox4.TabIndex = 102;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tùy chọn";
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(370, 61);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 61);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 10;
            this.btnThem.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageSize = new System.Drawing.Size(40, 40);
            this.btnThem.Location = new System.Drawing.Point(93, 61);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 61);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm ";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 10;
            this.btnSua.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(644, 61);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 61);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(675, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 101;
            this.label2.Text = "Tìm theo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(153, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 45);
            this.label3.TabIndex = 100;
            this.label3.Text = "Danh mục phòng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderColor = System.Drawing.Color.Black;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(829, 71);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(529, 46);
            this.txtTimKiem.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTimKiem.TabIndex = 99;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoGiuong);
            this.groupBox1.Controls.Add(this.txtSoNguoi);
            this.groupBox1.Controls.Add(this.cbLoaiPhong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtDG);
            this.groupBox1.Controls.Add(this.txtSoPhong);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(40, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 540);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // txtSoGiuong
            // 
            this.txtSoGiuong.BorderColor = System.Drawing.Color.Black;
            this.txtSoGiuong.BorderRadius = 10;
            this.txtSoGiuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoGiuong.DefaultText = "";
            this.txtSoGiuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoGiuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoGiuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoGiuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoGiuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoGiuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoGiuong.ForeColor = System.Drawing.Color.Black;
            this.txtSoGiuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoGiuong.Location = new System.Drawing.Point(223, 389);
            this.txtSoGiuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoGiuong.Name = "txtSoGiuong";
            this.txtSoGiuong.PasswordChar = '\0';
            this.txtSoGiuong.PlaceholderText = "";
            this.txtSoGiuong.SelectedText = "";
            this.txtSoGiuong.Size = new System.Drawing.Size(311, 44);
            this.txtSoGiuong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSoGiuong.TabIndex = 106;
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.BorderColor = System.Drawing.Color.Black;
            this.txtSoNguoi.BorderRadius = 10;
            this.txtSoNguoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoNguoi.DefaultText = "";
            this.txtSoNguoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoNguoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoNguoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoNguoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoNguoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoNguoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoNguoi.ForeColor = System.Drawing.Color.Black;
            this.txtSoNguoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoNguoi.Location = new System.Drawing.Point(223, 309);
            this.txtSoNguoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.PasswordChar = '\0';
            this.txtSoNguoi.PlaceholderText = "";
            this.txtSoNguoi.SelectedText = "";
            this.txtSoNguoi.Size = new System.Drawing.Size(311, 44);
            this.txtSoNguoi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSoNguoi.TabIndex = 105;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiPhong.BorderColor = System.Drawing.Color.Black;
            this.cbLoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.cbLoaiPhong.ItemHeight = 30;
            this.cbLoaiPhong.Items.AddRange(new object[] {
            "Phòng đơn",
            "Phòng đôi",
            "Phòng gia đình",
            "Suite",
            "Phòng Deluxe",
            "Phòng Vip"});
            this.cbLoaiPhong.Location = new System.Drawing.Point(223, 148);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(311, 36);
            this.cbLoaiPhong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbLoaiPhong.TabIndex = 104;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 100;
            this.label6.Text = "Số giường";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 99;
            this.label7.Text = "Số người";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(58, 251);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 25);
            this.label18.TabIndex = 97;
            this.label18.Text = "Đơn giá";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(56, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 25);
            this.label19.TabIndex = 96;
            this.label19.Text = "Loại phòng";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(56, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 25);
            this.label20.TabIndex = 95;
            this.label20.Text = "Số phòng";
            // 
            // txtDG
            // 
            this.txtDG.BorderColor = System.Drawing.Color.Black;
            this.txtDG.BorderRadius = 10;
            this.txtDG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDG.DefaultText = "";
            this.txtDG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDG.ForeColor = System.Drawing.Color.Black;
            this.txtDG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDG.Location = new System.Drawing.Point(223, 232);
            this.txtDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDG.Name = "txtDG";
            this.txtDG.PasswordChar = '\0';
            this.txtDG.PlaceholderText = "";
            this.txtDG.SelectedText = "";
            this.txtDG.Size = new System.Drawing.Size(311, 44);
            this.txtDG.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDG.TabIndex = 3;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.BorderColor = System.Drawing.Color.Black;
            this.txtSoPhong.BorderRadius = 10;
            this.txtSoPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoPhong.DefaultText = "";
            this.txtSoPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoPhong.ForeColor = System.Drawing.Color.Black;
            this.txtSoPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoPhong.Location = new System.Drawing.Point(223, 56);
            this.txtSoPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.PasswordChar = '\0';
            this.txtSoPhong.PlaceholderText = "";
            this.txtSoPhong.SelectedText = "";
            this.txtSoPhong.Size = new System.Drawing.Size(311, 44);
            this.txtSoPhong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSoPhong.TabIndex = 1;
            // 
            // dgvPhong
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPhong.ColumnHeadersHeight = 4;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhong.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.dgvPhong.Location = new System.Drawing.Point(670, 361);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.RowHeadersWidth = 62;
            this.dgvPhong.RowTemplate.Height = 28;
            this.dgvPhong.Size = new System.Drawing.Size(872, 462);
            this.dgvPhong.TabIndex = 105;
            this.dgvPhong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPhong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPhong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPhong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPhong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.dgvPhong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPhong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvPhong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPhong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPhong.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPhong.ThemeStyle.ReadOnly = false;
            this.dgvPhong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvPhong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhong.ThemeStyle.RowsStyle.Height = 28;
            this.dgvPhong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);
            // 
            // UserControlPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlPhong";
            this.Size = new System.Drawing.Size(1591, 876);
            this.Load += new System.EventHandler(this.UserControlPhong_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnTim;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2TextBox txtDG;
        private Guna.UI2.WinForms.Guna2TextBox txtSoPhong;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtSoGiuong;
        private Guna.UI2.WinForms.Guna2TextBox txtSoNguoi;
    }
}
