namespace TVP2_rentAcar
{
    partial class DodajRez
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
            this.dgRez = new System.Windows.Forms.DataGridView();
            this.cmbVozilo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnObrisiRez = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numMinutiKraj = new System.Windows.Forms.NumericUpDown();
            this.numSatiKraj = new System.Windows.Forms.NumericUpDown();
            this.numMinutiPocetak = new System.Windows.Forms.NumericUpDown();
            this.numSatiPocetak = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtVozacka = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgRez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutiKraj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatiKraj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutiPocetak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatiPocetak)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRez
            // 
            this.dgRez.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgRez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRez.Location = new System.Drawing.Point(3, 0);
            this.dgRez.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgRez.Name = "dgRez";
            this.dgRez.RowHeadersWidth = 51;
            this.dgRez.RowTemplate.Height = 24;
            this.dgRez.Size = new System.Drawing.Size(890, 369);
            this.dgRez.TabIndex = 0;
            this.dgRez.SelectionChanged += new System.EventHandler(this.dgRez_SelectionChanged);
            // 
            // cmbVozilo
            // 
            this.cmbVozilo.FormattingEnabled = true;
            this.cmbVozilo.Location = new System.Drawing.Point(228, 387);
            this.cmbVozilo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVozilo.Name = "cmbVozilo";
            this.cmbVozilo.Size = new System.Drawing.Size(218, 27);
            this.cmbVozilo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izaberi vozilo:";
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.CustomFormat = "MMMM dd \"at\" t:mm tt";
            this.dtpPocetak.Location = new System.Drawing.Point(228, 445);
            this.dtpPocetak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(249, 27);
            this.dtpPocetak.TabIndex = 3;
            // 
            // dtpKraj
            // 
            this.dtpKraj.CustomFormat = "MMMM dd \"at\" t:mm tt";
            this.dtpKraj.Location = new System.Drawing.Point(228, 524);
            this.dtpKraj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(249, 27);
            this.dtpKraj.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "OD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "DO:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(743, 498);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(180, 53);
            this.btnSacuvaj.TabIndex = 7;
            this.btnSacuvaj.Text = "SAČUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnObrisiRez
            // 
            this.btnObrisiRez.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnObrisiRez.Location = new System.Drawing.Point(1150, 498);
            this.btnObrisiRez.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnObrisiRez.Name = "btnObrisiRez";
            this.btnObrisiRez.Size = new System.Drawing.Size(180, 53);
            this.btnObrisiRez.TabIndex = 8;
            this.btnObrisiRez.Text = "OBRIŠI";
            this.btnObrisiRez.UseVisualStyleBackColor = true;
            this.btnObrisiRez.Click += new System.EventHandler(this.btnObrisiRez_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(943, 498);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 53);
            this.button2.TabIndex = 9;
            this.button2.Text = "IZMENI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numMinutiKraj
            // 
            this.numMinutiKraj.Location = new System.Drawing.Point(151, 545);
            this.numMinutiKraj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numMinutiKraj.Name = "numMinutiKraj";
            this.numMinutiKraj.Size = new System.Drawing.Size(54, 27);
            this.numMinutiKraj.TabIndex = 10;
            // 
            // numSatiKraj
            // 
            this.numSatiKraj.Location = new System.Drawing.Point(151, 510);
            this.numSatiKraj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSatiKraj.Name = "numSatiKraj";
            this.numSatiKraj.Size = new System.Drawing.Size(54, 27);
            this.numSatiKraj.TabIndex = 11;
            // 
            // numMinutiPocetak
            // 
            this.numMinutiPocetak.Location = new System.Drawing.Point(151, 462);
            this.numMinutiPocetak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numMinutiPocetak.Name = "numMinutiPocetak";
            this.numMinutiPocetak.Size = new System.Drawing.Size(54, 27);
            this.numMinutiPocetak.TabIndex = 12;
            // 
            // numSatiPocetak
            // 
            this.numSatiPocetak.Location = new System.Drawing.Point(151, 427);
            this.numSatiPocetak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSatiPocetak.Name = "numSatiPocetak";
            this.numSatiPocetak.Size = new System.Drawing.Size(54, 27);
            this.numSatiPocetak.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(978, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(947, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Prezime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(957, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Adresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(952, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(915, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Vozacka kategorija";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1021, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "KLIJENT";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(1073, 62);
            this.txtIme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(112, 27);
            this.txtIme.TabIndex = 20;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(1073, 117);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(112, 27);
            this.txtPrezime.TabIndex = 21;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(1073, 168);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(112, 27);
            this.txtAdresa.TabIndex = 22;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(1073, 218);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(112, 27);
            this.txtTelefon.TabIndex = 23;
            // 
            // txtVozacka
            // 
            this.txtVozacka.Location = new System.Drawing.Point(1073, 271);
            this.txtVozacka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVozacka.Name = "txtVozacka";
            this.txtVozacka.Size = new System.Drawing.Size(112, 27);
            this.txtVozacka.TabIndex = 24;
            // 
            // DodajRez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1357, 599);
            this.Controls.Add(this.txtVozacka);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numSatiPocetak);
            this.Controls.Add(this.numMinutiPocetak);
            this.Controls.Add(this.numSatiKraj);
            this.Controls.Add(this.numMinutiKraj);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnObrisiRez);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpKraj);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVozilo);
            this.Controls.Add(this.dgRez);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DodajRez";
            this.Text = "DodajRez";
            ((System.ComponentModel.ISupportInitialize)(this.dgRez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutiKraj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatiKraj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutiPocetak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatiPocetak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRez;
        private System.Windows.Forms.ComboBox cmbVozilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnObrisiRez;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numMinutiKraj;
        private System.Windows.Forms.NumericUpDown numSatiKraj;
        private System.Windows.Forms.NumericUpDown numMinutiPocetak;
        private System.Windows.Forms.NumericUpDown numSatiPocetak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtVozacka;
    }
}