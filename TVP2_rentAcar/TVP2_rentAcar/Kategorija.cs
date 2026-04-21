using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP2_rentAcar
{
    public class Kategorija
    {
        int id_kategorije;
        string naziv, opis;

        public Kategorija(int id_kategorije, string naziv, string opis)
        {
            this.id_kategorije = id_kategorije;
            this.naziv = naziv;
            this.opis = opis;
        }

        public Kategorija() { }

        public int ID_kategorije
        {
            get { return id_kategorije; }
            set { id_kategorije = value; }
        }
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }
    }
}
