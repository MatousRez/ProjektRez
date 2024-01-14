using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojištění
{
    public class PojistenaOsoba
    {
        // Atributy
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Vek { get; private set; }
        public string Telefon {  get; private set; }

        // Konstruktor
        public PojistenaOsoba(string jmeno, string prijmeni, int vek, string telefon)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Telefon = telefon;
        }

        // Metoda pro výpis informací
        public override string ToString()
        {
            return $"Jméno: {Jmeno}, Příjmení: {Prijmeni}, Věk: {Vek}, Telefon: {Telefon}";
        }
    }
}
