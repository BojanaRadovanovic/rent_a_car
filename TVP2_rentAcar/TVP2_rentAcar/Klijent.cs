using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP2_rentAcar
{
    public class Klijent
    {
        int id_klijenta;
        string ime, prezime, adresa, telefon, vozackaKategorija;

        public Klijent(int id_klijenta, string ime, string prezime, string adresa, string telefon, string vozackaKategorija)
        {
            this.id_klijenta = id_klijenta;
            this.ime = ime;
            this.prezime = prezime;
            this.adresa = adresa;
            this.telefon = telefon;
            this.vozackaKategorija = vozackaKategorija;
        }

        public Klijent() { }


        public int ID_klijenta
        {
            get { return id_klijenta; }
            set { id_klijenta = value; }
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        public string VozackaKategorija
        {
            get { return vozackaKategorija; }
            set { vozackaKategorija = value; }
        }
    }
}
