using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP2_rentAcar
{
    public class Rezervacija
    {
        int id_rezervacije, id_vozila, id_klijenta;
        decimal cena;
        DateTime datumVreme_pocetka, datumVreme_kraja;

       
        public Rezervacija(int id_rezervacije, int id_vozila, int id_klijenta, DateTime datumVreme_pocetka, DateTime datumVreme_kraja, decimal cena)
        {
            this.id_rezervacije = id_rezervacije;
            this.id_vozila = id_vozila;
            this.id_klijenta = id_klijenta;
            this.datumVreme_pocetka = datumVreme_pocetka;
            this.datumVreme_kraja = datumVreme_kraja;
            this.cena = cena;
        }
      
        public Rezervacija() { }

        
        public int ID_rezervacije
        {
            get { return id_rezervacije; }
            set { id_rezervacije = value; }
        }
        public int ID_vozila
        {
            get { return id_vozila; }
            set { id_vozila = value; }
        }
        public int ID_klijenta
        {
            get { return id_klijenta; }
            set { id_klijenta = value; }
        }
        public DateTime DatumVreme_pocetka
        {
            get { return datumVreme_pocetka; }
            set { datumVreme_pocetka = value; }
        }
        public DateTime DatumVreme_kraja
        {
            get { return datumVreme_kraja; }
            set { datumVreme_kraja = value; }
        }
        public decimal Cena
        {
            get { return cena; }
            set { cena = value; }
        }

    }
}
