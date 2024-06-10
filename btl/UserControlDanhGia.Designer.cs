namespace btl
{
    partial class UserControlDanhGia
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chartDanhGia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvDanhGia = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhGia)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDanhGia
            // 
            this.chartDanhGia.BorderlineWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.chartDanhGia.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDanhGia.Legends.Add(legend1);
            this.chartDanhGia.Location = new System.Drawing.Point(47, 142);
            this.chartDanhGia.Name = "chartDanhGia";
            this.chartDanhGia.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Đánh giá";
            series1.ShadowColor = System.Drawing.Color.Gray;
            series1.YValuesPerPoint = 2;
            this.chartDanhGia.Series.Add(series1);
            this.chartDanhGia.Size = new System.Drawing.Size(767, 700);
            this.chartDanhGia.TabIndex = 0;
            this.chartDanhGia.Text = "Biểu đồ đánh giá khách hàng";
            // 
            // dgvDanhGia
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDanhGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhGia.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhGia.ColumnHeadersHeight = 4;
            this.dgvDanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhGia.Location = new System.Drawing.Point(834, 178);
            this.dgvDanhGia.Name = "dgvDanhGia";
            this.dgvDanhGia.RowHeadersVisible = false;
            this.dgvDanhGia.RowHeadersWidth = 62;
            this.dgvDanhGia.RowTemplate.Height = 28;
            this.dgvDanhGia.Size = new System.Drawing.Size(692, 604);
            this.dgvDanhGia.TabIndex = 1;
            this.dgvDanhGia.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhGia.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDanhGia.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDanhGia.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDanhGia.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDanhGia.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDanhGia.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhGia.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDanhGia.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhGia.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDanhGia.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDanhGia.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDanhGia.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDanhGia.ThemeStyle.ReadOnly = false;
            this.dgvDanhGia.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhGia.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhGia.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDanhGia.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDanhGia.ThemeStyle.RowsStyle.Height = 28;
            this.dgvDanhGia.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhGia.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(688, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đánh giá khách hàng";
            // 
            // UserControlDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhGia);
            this.Controls.Add(this.chartDanhGia);
            this.Name = "UserControlDanhGia";
            this.Size = new System.Drawing.Size(1591, 916);
            this.Load += new System.EventHandler(this.UserControlDanhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDanhGia;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhGia;
        private System.Windows.Forms.Label label1;
    }
}
