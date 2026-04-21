using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace TVP2_rentAcar
{
    public partial class DodajVozilo : Form
    {
       
        private readonly string connStr;

        public DodajVozilo(string connectionString)
        {
            InitializeComponent();
            connStr = connectionString;

           
            UcitajKategorije();

        }

        
        private void btnDodajKat_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtNazivKategorije.Text) ||
                string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                MessageBox.Show("Popunite naziv i opis kategorije!");
                return;
            }

            int novaKatId;
            
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                string query = "INSERT INTO Kategorija (naziv, opis) VALUES (@naziv, @opis)";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@naziv", txtNazivKategorije.Text.Trim());
                    cmd.Parameters.AddWithValue("@opis", txtOpis.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                
                using (OleDbCommand getId = new OleDbCommand("SELECT @@IDENTITY", conn))
                {
                    novaKatId = Convert.ToInt32(getId.ExecuteScalar());
                }
            }

            MessageBox.Show("Kategorija dodata!");

         
            txtNazivKategorije.Clear();
            txtOpis.Clear();

            UcitajKategorije();

            
            cbKategorija.SelectedValue = novaKatId;

            
        }

    
        private void UcitajKategorije()
        {
            var kategorije = new List<Kategorija>();

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Kategorija";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kategorije.Add(new Kategorija
                        {
                            ID_kategorije = Convert.ToInt32(reader["id_kategorije"]),
                            Naziv = reader["naziv"].ToString(),
                            Opis = reader["opis"].ToString()
                        });
                    }
                }
            }

           
            cbKategorija.DataSource = kategorije;
            cbKategorija.DisplayMember = "Naziv";          
            cbKategorija.ValueMember = "ID_kategorije";    
            cbKategorija.SelectedIndex = -1;               
        }

        
        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
          
            if (cbKategorija.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtNazivVozila.Text) ||
                string.IsNullOrWhiteSpace(txtMarka.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtGodProizv.Text) ||
                string.IsNullOrWhiteSpace(txtCenaPoSatu.Text))
            {
                MessageBox.Show("Popunite sve podatke!");
                return;
            }

            
            if (!int.TryParse(txtGodProizv.Text, out int godProizv) ||
                godProizv < 1900 || godProizv > DateTime.Now.Year)
            {
                MessageBox.Show("Unesite ispravnu godinu proizvodnje!");
                return;
            }

            if (!decimal.TryParse(txtCenaPoSatu.Text, out decimal cena) || cena <= 0)
            {
                MessageBox.Show("Unesite ispravnu cenu po satu!");
                return;
            }

           
            int idKategorije = (int)cbKategorija.SelectedValue;
            string naziv = txtNazivVozila.Text.Trim();
            string marka = txtMarka.Text.Trim();
            string model = txtModel.Text.Trim();

            
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string query =
                    "INSERT INTO Vozilo (id_kategorije, naziv, marka, model, godina_proizvodnje, cena_po_satu) " +
                    "VALUES (@kategorija, @naziv, @marka, @model, @godina, @cena)";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@kategorija", idKategorije);
                    cmd.Parameters.AddWithValue("@naziv", naziv);
                    cmd.Parameters.AddWithValue("@marka", marka);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@godina", godProizv);

                  
                    cmd.Parameters.Add("@cena", OleDbType.Currency).Value = cena;

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Vozilo uspešno dodato!");

            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
