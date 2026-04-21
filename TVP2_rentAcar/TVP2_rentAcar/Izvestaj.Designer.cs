namespace TVP2_rentAcar
{
    partial class Izvestaj
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dgvIzvestaj = new System.Windows.Forms.DataGridView();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpOd
            // 
            this.dtpOd.CalendarFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOd.Location = new System.Drawing.Point(66, 176);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(246, 27);
            this.dtpOd.TabIndex = 0;
            // 
            // dtpDo
            // 
            this.dtpDo.CalendarFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDo.Location = new System.Drawing.Point(66, 257);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(246, 27);
            this.dtpDo.TabIndex = 1;
            // 
            // dgvIzvestaj
            // 
            this.dgvIzvestaj.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvIzvestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvestaj.Location = new System.Drawing.Point(468, 21);
            this.dgvIzvestaj.Name = "dgvIzvestaj";
            this.dgvIzvestaj.RowHeadersWidth = 51;
            this.dgvIzvestaj.RowTemplate.Height = 24;
            this.dgvIzvestaj.Size = new System.Drawing.Size(629, 285);
            this.dgvIzvestaj.TabIndex = 2;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerisi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerisi.Location = new System.Drawing.Point(92, 356);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(137, 66);
            this.btnGenerisi.TabIndex = 3;
            this.btnGenerisi.Text = "GENERISI";
            this.btnGenerisi.UseVisualStyleBackColor = false;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(468, 329);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(629, 281);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // Izvestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1188, 622);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.dgvIzvestaj);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Name = "Izvestaj";
            this.Text = "Izvestaj";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DataGridView dgvIzvestaj;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}