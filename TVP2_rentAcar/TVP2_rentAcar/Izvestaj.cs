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

namespace TVP2_rentAcar
{
    public partial class Izvestaj : Form
    {
        public Izvestaj()
        {
            InitializeComponent();
        }


        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Korisnik\Desktop\II_projekat_NRT_146_23\TVP2_rentAcar\TVP2_rentAcar\RentACarDB.accdb";

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            DateTime od = dtpOd.Value.Date;
            DateTime doo = dtpDo.Value.Date;

            string query = @"SELECT k.naziv AS Kategorija, COUNT(r.id_rezervacija) AS BrojRezervacija
                 FROM (Kategorija k 
                       INNER JOIN Vozilo v ON k.id_kategorije = v.id_kategorije)
                       INNER JOIN Rezervacija r ON v.id_vozila = r.id_vozila
                 WHERE r.datumVreme_pocetka >= @od AND r.datumVreme_kraja <= @do
                 GROUP BY k.naziv";

            using (OleDbConnection con = new OleDbConnection(connStr))
            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@od", od);
                cmd.Parameters.AddWithValue("@do", doo);

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);


                dgvIzvestaj.DataSource = dt;


                chart1.Series.Clear();
                chart1.Series.Add("Rezervacije");
                chart1.Series["Rezervacije"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                foreach (DataRow row in dt.Rows)
                {
                    string kategorija = row["Kategorija"].ToString();
                    int broj = Convert.ToInt32(row["BrojRezervacija"]);

                    chart1.Series["Rezervacije"].Points.AddXY(kategorija, broj);
                }


                chart1.Series["Rezervacije"].IsValueShownAsLabel = true;
                chart1.Series["Rezervacije"].Label = "#VALX (#PERCENT{P0})";
            }
        }
    }
}
