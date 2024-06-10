namespace btl
{
    partial class UserControlQLyPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbLoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvQly = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQly)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbTrangThai.BorderColor = System.Drawing.Color.Black;
            this.cbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTrangThai.ForeColor = System.Drawing.Color.Black;
            this.cbTrangThai.ItemHeight = 30;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Đã đặt"});
            this.cbTrangThai.Location = new System.Drawing.Point(95, 171);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(325, 36);
            this.cbTrangThai.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbTrangThai.TabIndex = 21;
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
            "Phòng đôi",
            "Phòng đơn",
            "Phòng gia đình",
            "Suite",
            "Phòng deluxe",
            "Phòng VIP"});
            this.cbLoaiPhong.Location = new System.Drawing.Point(95, 319);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(325, 36);
            this.cbLoaiPhong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbLoaiPhong.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(95, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Trạng thái phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(95, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(95, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "Số phòng";
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.BorderColor = System.Drawing.Color.Black;
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
            this.txtSoPhong.Location = new System.Drawing.Point(100, 470);
            this.txtSoPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.PasswordChar = '\0';
            this.txtSoPhong.PlaceholderText = "";
            this.txtSoPhong.SelectedText = "";
            this.txtSoPhong.Size = new System.Drawing.Size(320, 44);
            this.txtSoPhong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSoPhong.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoPhong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbLoaiPhong);
            this.groupBox1.Controls.Add(this.cbTrangThai);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(61, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 662);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý phòng";
            // 
            // dgvQly
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvQly.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQly.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQly.ColumnHeadersHeight = 4;
            this.dgvQly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQly.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQly.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.dgvQly.Location = new System.Drawing.Point(658, 122);
            this.dgvQly.Name = "dgvQly";
            this.dgvQly.RowHeadersVisible = false;
            this.dgvQly.RowHeadersWidth = 62;
            this.dgvQly.RowTemplate.Height = 28;
            this.dgvQly.Size = new System.Drawing.Size(872, 647);
            this.dgvQly.TabIndex = 30;
            this.dgvQly.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQly.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQly.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQly.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQly.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQly.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvQly.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.dgvQly.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQly.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQly.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvQly.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQly.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvQly.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvQly.ThemeStyle.ReadOnly = false;
            this.dgvQly.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQly.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQly.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvQly.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQly.ThemeStyle.RowsStyle.Height = 28;
            this.dgvQly.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQly.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQly.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQly_CellContentClick_1);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label30.Location = new System.Drawing.Point(559, 31);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(236, 45);
            this.label30.TabIndex = 96;
            this.label30.Text = "Quản lý phòng";
            // 
            // UserControlQLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label30);
            this.Controls.Add(this.dgvQly);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlQLyPhong";
            this.Size = new System.Drawing.Size(1591, 876);
            this.Load += new System.EventHandler(this.UserControlQLyPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbTrangThai;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSoPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQly;
        private System.Windows.Forms.Label label30;
    }
}
