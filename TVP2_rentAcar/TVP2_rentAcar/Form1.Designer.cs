namespace TVP2_rentAcar
{
    partial class Form1
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
            this.dgVozila = new System.Windows.Forms.DataGridView();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDo = new System.Windows.Forms.TextBox();
            this.txtOd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnDodajRez = new System.Windows.Forms.Button();
            this.btnDodajV = new System.Windows.Forms.Button();
            this.lblPopularno = new System.Windows.Forms.Label();
            this.btnIzvestaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVozila
            // 
            this.dgVozila.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVozila.Location = new System.Drawing.Point(14, 14);
            this.dgVozila.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgVozila.Name = "dgVozila";
            this.dgVozila.RowHeadersWidth = 51;
            this.dgVozila.RowTemplate.Height = 24;
            this.dgVozila.Size = new System.Drawing.Size(780, 408);
            this.dgVozila.TabIndex = 0;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(1076, 46);
            this.cmbKategorija.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(201, 27);
            this.cmbKategorija.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(921, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategorije vozila:";
            // 
            // txtDo
            // 
            this.txtDo.Location = new System.Drawing.Point(1217, 217);
            this.txtDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDo.Name = "txtDo";
            this.txtDo.Size = new System.Drawing.Size(112, 27);
            this.txtDo.TabIndex = 3;
            // 
            // txtOd
            // 
            this.txtOd.Location = new System.Drawing.Point(1217, 160);
            this.txtOd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOd.Name = "txtOd";
            this.txtOd.Size = new System.Drawing.Size(112, 27);
            this.txtOd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(828, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "OD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1192, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filtriranje cena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(828, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "DO:";
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(876, 160);
            this.dtpOd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(224, 27);
            this.dtpOd.TabIndex = 8;
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(872, 217);
            this.dtpDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(224, 27);
            this.dtpDo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(872, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Filtriranje po datumu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1151, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "OD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1151, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "DO:";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilter.Location = new System.Drawing.Point(995, 306);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(222, 71);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "Filtriraj";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnDodajRez
            // 
            this.btnDodajRez.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajRez.Location = new System.Drawing.Point(80, 448);
            this.btnDodajRez.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodajRez.Name = "btnDodajRez";
            this.btnDodajRez.Size = new System.Drawing.Size(180, 60);
            this.btnDodajRez.TabIndex = 14;
            this.btnDodajRez.Text = "Dodaj rezervaciju";
            this.btnDodajRez.UseVisualStyleBackColor = false;
            this.btnDodajRez.Click += new System.EventHandler(this.btnDodajRez_Click);
            // 
            // btnDodajV
            // 
            this.btnDodajV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajV.Location = new System.Drawing.Point(298, 448);
            this.btnDodajV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodajV.Name = "btnDodajV";
            this.btnDodajV.Size = new System.Drawing.Size(180, 60);
            this.btnDodajV.TabIndex = 15;
            this.btnDodajV.Text = "Dodaj vozilo i kategoriju";
            this.btnDodajV.UseVisualStyleBackColor = false;
            this.btnDodajV.Click += new System.EventHandler(this.btnDodajV_Click);
            // 
            // lblPopularno
            // 
            this.lblPopularno.AutoSize = true;
            this.lblPopularno.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopularno.Location = new System.Drawing.Point(927, 415);
            this.lblPopularno.Name = "lblPopularno";
            this.lblPopularno.Size = new System.Drawing.Size(0, 51);
            this.lblPopularno.TabIndex = 16;
            // 
            // btnIzvestaj
            // 
            this.btnIzvestaj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIzvestaj.Location = new System.Drawing.Point(528, 448);
            this.btnIzvestaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzvestaj.Name = "btnIzvestaj";
            this.btnIzvestaj.Size = new System.Drawing.Size(180, 60);
            this.btnIzvestaj.TabIndex = 17;
            this.btnIzvestaj.Text = "Izvestaj";
            this.btnIzvestaj.UseVisualStyleBackColor = false;
            this.btnIzvestaj.Click += new System.EventHandler(this.btnIzvestaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1395, 556);
            this.Controls.Add(this.btnIzvestaj);
            this.Controls.Add(this.lblPopularno);
            this.Controls.Add(this.btnDodajV);
            this.Controls.Add(this.btnDodajRez);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOd);
            this.Controls.Add(this.txtDo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.dgVozila);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVozila;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDo;
        private System.Windows.Forms.TextBox txtOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnDodajRez;
        private System.Windows.Forms.Button btnDodajV;
        private System.Windows.Forms.Label lblPopularno;
        private System.Windows.Forms.Button btnIzvestaj;
    }
}

