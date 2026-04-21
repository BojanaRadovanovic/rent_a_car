using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TVP2_rentAcar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        List<Vozilo> vozila = new List<Vozilo>();
        List<Kategorija> kategorije = new List<Kategorija>();
        List<Rezervacija> rezervacije = new List<Rezervacija>();

        
        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Korisnik\Desktop\II_projekat_NRT_146_23\TVP2_rentAcar\TVP2_rentAcar\RentACarDB.accdb";

        
        private void Form1_Load(object sender, EventArgs e)
        {
            UcitajKategorije();
            UcitajVozila();
            UcitajRezervacije();
            PrikaziVozila(vozila);
            PokreniAnimaciju();
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
                            Cena = reader["cena"] != DBNull.Value ? Convert.ToDecimal(reader["cena"]) : 0
                        });
                    }
                }
            }
        }
        
      
        private void PrikaziVozila(List<Vozilo> lista)
        {
            dgVozila.DataSource = null;
            dgVozila.DataSource = lista;
        }
        
        private void UcitajVozila()
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Vozilo";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                vozila.Add(new Vozilo
                {
                    ID_vozila = (int)reader["id_vozila"],
                    ID_kategorije = (int)reader["id_kategorije"],
                    Naziv = reader["naziv"].ToString(),
                    Marka = reader["marka"].ToString(),
                    Model = reader["model"].ToString(),
                    God_proizv = (int)reader["godina_proizvodnje"],
                    Cena_po_satu = Convert.ToDecimal(reader["cena_po_satu"])
                });
            }

            reader.Close();
            conn.Close();
        }

        
        private void UcitajKategorije()
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Kategorija";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                kategorije.Add(new Kategorija
                {
                    ID_kategorije = (int)reader["id_kategorije"],
                    Naziv = reader["naziv"].ToString(),
                    Opis = reader["opis"].ToString()
                });
            }

            reader.Close();
            conn.Close();

            cmbKategorija.DataSource = kategorije;
            cmbKategorija.DisplayMember = "Naziv"; 
            cmbKategorija.ValueMember = "ID_kategorije"; 
            cmbKategorija.SelectedIndex = -1;  
        }




        private void btnFilter_Click(object sender, EventArgs e)
        {
            
            DateTime od = dtpOd.Value.Date;
            DateTime doDan = dtpDo.Value.Date;

            if (doDan < od)
            {
                MessageBox.Show("Krajnji datum mora biti posle početnog.");
                return;
            }

            
            DateTime doExcl = doDan.AddDays(1);

            
            decimal odCena, doCena;
            if (!decimal.TryParse(txtOd.Text, out odCena)) odCena = 0m;
            if (!decimal.TryParse(txtDo.Text, out doCena)) doCena = decimal.MaxValue;

           
            int? kat = (cmbKategorija.SelectedIndex != -1) ? (int?)cmbKategorija.SelectedValue : null;

            
            var filtrirana = vozila.Where(v =>
                (!kat.HasValue || v.ID_kategorije == kat.Value) &&
                v.Cena_po_satu >= odCena && v.Cena_po_satu <= doCena &&
                JeVoziloSlobodno(v.ID_vozila, od, doExcl)
            ).ToList();

            PrikaziVozila(filtrirana);
        }

       
        private bool JeVoziloSlobodno(int voziloId, DateTime od, DateTime doExcl)
        {
            foreach (var r in rezervacije)
            {
                if (r.ID_vozila != voziloId) continue;

                
                bool preklapaSe = !(r.DatumVreme_kraja <= od || r.DatumVreme_pocetka >= doExcl);
                if (preklapaSe) return false;
            }
            return true;
        }


        private void btnDodajRez_Click(object sender, EventArgs e)
        {
            using (var forma = new DodajRez(connStr, vozila))
            {
                if (forma.ShowDialog(this) == DialogResult.OK)
                {
                    rezervacije.Clear();
                    UcitajRezervacije();

                   
                    ZaustaviAnimaciju();
                    PokreniAnimaciju();
                }
            }
        }


        private void btnDodajV_Click(object sender, EventArgs e)
        {
            using (var frm = new DodajVozilo(connStr))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    kategorije.Clear();
                    vozila.Clear();
                    UcitajKategorije();
                    UcitajVozila();
                    PrikaziVozila(vozila);
                }
            }
        }

      
        private Vozilo NajpopularnijeVozilo()
        {
            List<int> idVozila = new List<int>();
            List<int> brojRezervacija = new List<int>();

            foreach (Rezervacija r in rezervacije)
            {
                bool pronadjeno = false;
                for (int i = 0; i < idVozila.Count; i++)
                {
                    if (idVozila[i] == r.ID_vozila)
                    {
                        brojRezervacija[i] = brojRezervacija[i] + 1;
                        pronadjeno = true;
                        break;
                    }
                }

                if (!pronadjeno)
                {
                    idVozila.Add(r.ID_vozila);
                    brojRezervacija.Add(1);
                }
            }


            int maxBroj = 0;
            int idNajpopularnijeg = 0;
            for (int i = 0; i < brojRezervacija.Count; i++)
            {
                if (brojRezervacija[i] > maxBroj)
                {
                    maxBroj = brojRezervacija[i];
                    idNajpopularnijeg = idVozila[i];
                }
            }

         
            for (int i = 0; i < vozila.Count; i++)
            {
                if (vozila[i].ID_vozila == idNajpopularnijeg)
                {
                    return vozila[i];
                }
            }

            return null;
        }

        
        private Thread nitBoja;
        private bool animacijaAktivna = false;

        private void PokreniAnimaciju()
        {
            Vozilo voz = NajpopularnijeVozilo();
            if (voz == null)
                return;

            lblPopularno.Text = voz.Naziv + "-" + voz.Marka;
            animacijaAktivna = true;

            nitBoja = new Thread(() =>
            {
                Color[] boje = new Color[]
                {
                   
                    Color.LightPink,
                    Color.HotPink,
                    Color.DeepPink,
                    Color.Pink,
                    Color.Magenta
                };

                int indexBoje = 0;

                while (animacijaAktivna)
                {

                    lblPopularno.Invoke((Action)(() =>
                    {
                        lblPopularno.ForeColor = boje[indexBoje];
                        lblPopularno.Font = new Font("Comic Sans MS", lblPopularno.Font.Size, lblPopularno.Font.Style);
                    }));

                    indexBoje = (indexBoje + 1) % boje.Length;
                    Thread.Sleep(500);
                }
            });

            nitBoja.IsBackground = true;
            nitBoja.Start();
        }

        private void ZaustaviAnimaciju()
        {
            animacijaAktivna = false;
            if (nitBoja != null && nitBoja.IsAlive)
            {
                nitBoja.Join();
            }
        }

        private void btnIzvestaj_Click(object sender, EventArgs e)
        {
            Izvestaj izv = new Izvestaj();
            izv.ShowDialog();
        }

        
    }
}
