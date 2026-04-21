using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP2_rentAcar
{
    public class Vozilo
    {
        
        int id_vozila, id_kategorije, god_proizv;
        string naziv, marka, model;
        decimal cena_po_satu;

        
        public Vozilo(int id_vozila, int id_kategorije, int god_proizv, string naziv, string marka, string model, decimal cena_po_satu)
        {
            this.id_vozila = id_vozila;
            this.id_kategorije = id_kategorije;
            this.god_proizv = god_proizv;
            this.naziv = naziv;
            this.marka = marka;
            this.model = model;
            this.cena_po_satu = cena_po_satu;
        }

       
        public Vozilo()
        {

        }

        
        public int ID_vozila
        {
            get { return id_vozila; }
            set { id_vozila = value; }
        }
        public int ID_kategorije
        {
            get { return id_kategorije; }
            set { id_kategorije = value; }
        }
        public int God_proizv
        {
            get { return god_proizv; }
            set { god_proizv = value; }
        }
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public decimal Cena_po_satu
        {
            get { return cena_po_satu; }
            set { cena_po_satu = value; }
        }
    }
}
