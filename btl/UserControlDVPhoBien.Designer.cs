namespace btl
{
    partial class UserControlDVPhoBien
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
            this.chartDVPB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvDV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDVPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDVPB
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDVPB.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDVPB.Legends.Add(legend1);
            this.chartDVPB.Location = new System.Drawing.Point(101, 182);
            this.chartDVPB.Name = "chartDVPB";
            this.chartDVPB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Dịch vụ";
            series1.ShadowColor = System.Drawing.Color.Gray;
            this.chartDVPB.Series.Add(series1);
            this.chartDVPB.Size = new System.Drawing.Size(648, 623);
            this.chartDVPB.TabIndex = 0;
            this.chartDVPB.Text = "Dịch vụ phổ biến";
            // 
            // dgvDV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDV.ColumnHeadersHeight = 4;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDV.Location = new System.Drawing.Point(889, 182);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersVisible = false;
            this.dgvDV.RowHeadersWidth = 62;
            this.dgvDV.RowTemplate.Height = 28;
            this.dgvDV.Size = new System.Drawing.Size(615, 604);
            this.dgvDV.TabIndex = 1;
            this.dgvDV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDV.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDV.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDV.ThemeStyle.ReadOnly = false;
            this.dgvDV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDV.ThemeStyle.RowsStyle.Height = 28;
            this.dgvDV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(634, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dịch vụ phổ biến";
            // 
            // UserControlDVPhoBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.chartDVPB);
            this.Name = "UserControlDVPhoBien";
            this.Size = new System.Drawing.Size(1591, 876);
            this.Load += new System.EventHandler(this.UserControlDVPhoBien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDVPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDVPB;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDV;
        private System.Windows.Forms.Label label1;
    }
}
