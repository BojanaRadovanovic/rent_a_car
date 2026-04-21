using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVP2_rentAcar;

namespace TVP2_rentAcar
{
    public partial class DodajRez : Form
    {
        
        private string connStr;
        private List<Vozilo> vozila;
        List<Rezervacija> rezervacije = new List<Rezervacija>();

       
        public DodajRez(string connectionString, List<Vozilo> listaVozila)
        {
            InitializeComponent();
            connStr = connectionString;
            vozila = listaVozila; 
            PopuniComboVozila();  
            UcitajRezervacije();   
            PrikaziRezervacije();  

            
            numSatiPocetak.Minimum = 0;
            numSatiPocetak.Maximum = 23;
            numSatiKraj.Minimum = 0;
            numSatiKraj.Maximum = 23;


            numMinutiPocetak.Minimum = 0;
            numMinutiPocetak.Maximum = 59;
            numMinutiKraj.Minimum = 0;
            numMinutiKraj.Maximum = 59;
        }

       
        private void PopuniComboVozila()
        {
            cmbVozilo.DataSource = vozila;
            cmbVozilo.DisplayMember = "Naziv";
            cmbVozilo.ValueMember = "ID_vozila";
            cmbVozilo.SelectedIndex = -1;
        }

        
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
       
            DateTime pocetak = dtpPocetak.Value.Date
                   .AddHours((double)numSatiPocetak.Value)
                   .AddMinutes((double)numMinutiPocetak.Value);

            DateTime kraj = dtpKraj.Value.Date
                            .AddHours((double)numSatiKraj.Value)
                            .AddMinutes((double)numMinutiKraj.Value);

            
            if (string.IsNullOrWhiteSpace(txtIme.Text) ||
                string.IsNullOrWhiteSpace(txtPrezime.Text) ||
                string.IsNullOrWhiteSpace(txtAdresa.Text) ||
                string.IsNullOrWhiteSpace(txtTelefon.Text) ||
                string.IsNullOrWhiteSpace(txtVozacka.Text))
            {
                MessageBox.Show("Popunite sve podatke o klijentu!");
                return;
            }

            string telefon = txtTelefon.Text.Trim();
            if (!telefon.All(char.IsDigit))
            {
                MessageBox.Show("Telefon mora sadržati samo cifre!");
                return;
            }
            if (telefon.Length < 9 || telefon.Length > 10)
            {
                MessageBox.Show("Telefon mora imati 9 ili 10 cifara!");
                return;
            }

            if (cmbVozilo.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite vozilo!");
                return;
            }

            int voziloId = (int)cmbVozilo.SelectedValue;


            if (kraj <= pocetak)
            {
                MessageBox.Show("Kraj mora biti posle početka rezervacije!");
                return;
            }


            foreach (var r in rezervacije)
            {
                if (r.ID_vozila == voziloId)
                {
                    
                    if (!(r.DatumVreme_kraja <= pocetak || r.DatumVreme_pocetka >= kraj))
                    {
                        MessageBox.Show("Izabrano vozilo je već rezervisano u ovom periodu!");
                        return;
                    }
                }
            }

            int klijentId;
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
            
                string queryKlijent = "INSERT INTO Klijent (ime, prezime, adresa, telefon, vozacka_kategorija) " +
                                      "VALUES (@ime, @prezime, @adresa, @telefon, @vk)";
                using (OleDbCommand cmd = new OleDbCommand(queryKlijent, conn))
                {
                    cmd.Parameters.AddWithValue("@ime", txtIme.Text);
                    cmd.Parameters.AddWithValue("@prezime", txtPrezime.Text);
                    cmd.Parameters.AddWithValue("@adresa", txtAdresa.Text);
                    cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                    cmd.Parameters.AddWithValue("@vk", txtVozacka.Text);
                    cmd.ExecuteNonQuery();
                }


                string getIdQuery = "SELECT @@IDENTITY";
                using (OleDbCommand cmd = new OleDbCommand(getIdQuery, conn))
                {
                    klijentId = Convert.ToInt32(cmd.ExecuteScalar());
                }


                Vozilo vozilo = null;
                foreach (var v in vozila)
                {
                    if (v.ID_vozila == voziloId)
                    {
                        vozilo = v;
                        break;
                    }
                }
               
                TimeSpan trajanje = kraj - pocetak;
                decimal cena = Math.Ceiling((decimal)trajanje.TotalMinutes * (vozilo.Cena_po_satu / 60m));
                
                string queryRez = "INSERT INTO Rezervacija (id_vozila, id_klijenta, datumVreme_pocetka, datumVreme_kraja, cena) " +
                                  "VALUES (@vozilo, @klijent, @pocetak, @kraj, @cena)";
                using (OleDbCommand cmd = new OleDbCommand(queryRez, conn))
                {
                    cmd.Parameters.AddWithValue("@vozilo", voziloId);
                    cmd.Parameters.AddWithValue("@klijent", klijentId);
                    cmd.Parameters.AddWithValue("@pocetak", pocetak);
                    cmd.Parameters.AddWithValue("@kraj", kraj);
                    cmd.Parameters.Add("@cena", OleDbType.Currency).Value = cena;
                    cmd.ExecuteNonQuery();
                }
            }

            rezervacije.Clear();
            UcitajRezervacije();
            PrikaziRezervacije();

            MessageBox.Show("Klijent i rezervacija uspešno dodati!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void UcitajRezervacije()
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                
                conn.Open();
                string query = "SELECT * FROM Rezervacija";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    rezervacije.Clear();
                    while (reader.Read())
                    {
                        rezervacije.Add(new Rezervacija
                        {
                            ID_rezervacije = reader["id_rezervacija"] != DBNull.Value ? Convert.ToInt32(reader["id_rezervacija"]) : 0,
                            ID_vozila = reader["id_vozila"] != DBNull.Value ? Convert.ToInt32(reader["id_vozila"]) : 0,
                            ID_klijenta = reader["id_klijenta"] != DBNull.Value ? Convert.ToInt32(reader["id_klijenta"]) : 0,
                            DatumVreme_pocetka = reader["datumVreme_pocetka"] != DBNull.Value ? Convert.ToDateTime(reader["datumVreme_pocetka"]) : DateTime.MinValue,
                            DatumVreme_kraja = reader["datumVreme_kraja"] != DBNull.Value ? Convert.ToDateTime(reader["datumVreme_kraja"]) : DateTime.MinValue,
                            Cena = reader["cena"] != DBNull.Value ? Convert.ToDecimal(reader["cena"]) : 0m
                        });
                    }
                }
            }
        }
        
        private void PrikaziRezervacije()
        {
            dgRez.DataSource = null;
            dgRez.DataSource = rezervacije;
            dgRez.Columns["ID_vozila"].HeaderText = "ID Vozila";
            dgRez.Columns["ID_klijenta"].HeaderText = "ID Klijenta";
            dgRez.Columns["DatumVreme_pocetka"].HeaderText = "Početak";
            dgRez.Columns["DatumVreme_kraja"].HeaderText = "Kraj";
            dgRez.Columns["Cena"].HeaderText = "Cena";
            dgRez.Columns["DatumVreme_pocetka"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            dgRez.Columns["DatumVreme_kraja"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            dgRez.Columns["Cena"].DefaultCellStyle.Format = "0.00";

        }

        
        private void btnObrisiRez_Click(object sender, EventArgs e)
        {
            if (dgRez.CurrentRow == null)
            {
                MessageBox.Show("Izaberite rezervaciju za brisanje!");
                return;
            }

            int rezervacijaId = Convert.ToInt32(dgRez.CurrentRow.Cells["ID_rezervacije"].Value);

            var potvrda = MessageBox.Show("Da li ste sigurni da želite da obrišete ovu rezervaciju?",
                                          "Potvrda", MessageBoxButtons.YesNo);
            if (potvrda == DialogResult.No)
                return;

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string query = "DELETE FROM Rezervacija WHERE id_rezervacija=@id";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", rezervacijaId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Rezervacija obrisana!");
            rezervacije.Clear();
            UcitajRezervacije();
            PrikaziRezervacije();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgRez.CurrentRow == null)
            {
                MessageBox.Show("Izaberite rezervaciju za izmenu!");
                return;
            }

            int rezervacijaId = Convert.ToInt32(dgRez.CurrentRow.Cells["ID_rezervacije"].Value);

            
            DateTime pocetak = dtpPocetak.Value.Date
                               .AddHours((double)numSatiPocetak.Value)
                               .AddMinutes((double)numMinutiPocetak.Value);

            DateTime kraj = dtpKraj.Value.Date
                            .AddHours((double)numSatiKraj.Value)
                            .AddMinutes((double)numMinutiKraj.Value);

            if (kraj <= pocetak)
            {
                MessageBox.Show("Kraj mora biti posle početka rezervacije!");
                return;
            }

            if (cmbVozilo.SelectedValue == null)
            {
                MessageBox.Show("Izaberite vozilo!");
                return;
            }
            int voziloId = (int)cmbVozilo.SelectedValue;

            
            foreach (var r in rezervacije)
            {
                if (r.ID_rezervacije != rezervacijaId && r.ID_vozila == voziloId)
                {
                    bool nemaPreseka = (r.DatumVreme_kraja <= pocetak) || (r.DatumVreme_pocetka >= kraj);
                    if (!nemaPreseka)
                    {
                        MessageBox.Show("Izabrano vozilo je već rezervisano u ovom periodu!");
                        return;
                    }
                }
            }

       
            Vozilo vozilo = null;
            foreach (var v in vozila)
            {
                if (v.ID_vozila == voziloId)
                {
                    vozilo = v;
                    break;
                }
            }
            if (vozilo == null)
            {
                MessageBox.Show("Vozilo nije pronađeno.");
                return;
            }

           
            TimeSpan trajanje = kraj - pocetak;
            decimal cena = Math.Ceiling((decimal)trajanje.TotalMinutes * (vozilo.Cena_po_satu / 60m));

            
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE Rezervacija " +
                               "SET id_vozila=@vozilo, datumVreme_pocetka=@pocetak, datumVreme_kraja=@kraj, cena=@cena " +
                               "WHERE id_rezervacija=@id";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@vozilo", voziloId);
                    cmd.Parameters.AddWithValue("@pocetak", pocetak);
                    cmd.Parameters.AddWithValue("@kraj", kraj);
                    cmd.Parameters.Add("@cena", OleDbType.Currency).Value = cena; 
                    cmd.Parameters.AddWithValue("@id", rezervacijaId);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Rezervacija izmenjena!");
            rezervacije.Clear();
            UcitajRezervacije();
            PrikaziRezervacije();
        }

       
        private void dgRez_SelectionChanged(object sender, EventArgs e)
        {
            if (dgRez.CurrentRow == null) return;


            cmbVozilo.SelectedValue = dgRez.CurrentRow.Cells["ID_vozila"].Value;


            DateTime pocetak = Convert.ToDateTime(dgRez.CurrentRow.Cells["DatumVreme_pocetka"].Value);
            DateTime kraj = Convert.ToDateTime(dgRez.CurrentRow.Cells["DatumVreme_kraja"].Value);

            if (pocetak < dtpPocetak.MinDate)
                pocetak = dtpPocetak.MinDate;
            if (pocetak > dtpPocetak.MaxDate)
                pocetak = dtpPocetak.MaxDate;

            if (kraj < dtpKraj.MinDate)
                kraj = dtpKraj.MinDate;
            if (kraj > dtpKraj.MaxDate)
                kraj = dtpKraj.MaxDate;

            dtpPocetak.Value = pocetak.Date;
            numSatiPocetak.Value = pocetak.Hour;
            numMinutiPocetak.Value = pocetak.Minute;

            dtpKraj.Value = kraj.Date;
            numSatiKraj.Value = kraj.Hour;
            numMinutiKraj.Value = kraj.Minute;
        }
    }
}
