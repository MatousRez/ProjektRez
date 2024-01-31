using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Evidence_pojištění
{
    public class EvidencePojisteni
    {
        // Atribut pro ukládání pojištěných osob
        private List<PojistenaOsoba> seznamPojistenych;

        // Konstruktor
        public EvidencePojisteni()
        {
            seznamPojistenych = new List<PojistenaOsoba>();
        }

        // Metoda pro přidání nového pojištěného
        public void PridatPojisteneho(PojistenaOsoba novaOsoba)
        {
            if (novaOsoba != null)
            {
                // Validace jména před přidáním do seznamu
                if (string.IsNullOrWhiteSpace(novaOsoba.Jmeno) || string.IsNullOrWhiteSpace(novaOsoba.Prijmeni))
                {
                    Console.WriteLine("Chyba: Jméno a příjmení nesmí být prázdné nebo obsahovat pouze bílé znaky.");
                    return;
                }

                seznamPojistenych.Add(novaOsoba);
                Console.WriteLine("Nový pojištěný byl úspěšně přidán.");
            }
            else
            {
                Console.WriteLine("Chyba: Nelze přidat prázdného pojištěného.");
            }
        }

        // Metoda pro získání seznamu pojištěných
        public List<PojistenaOsoba> ZiskaSeznam()
        {
            return seznamPojistenych;
        }

        // Metoda pro výpis všech pojištěných
        public void VypisSeznam()
        {
            if (seznamPojistenych.Count > 0)
            {
                Console.WriteLine("Seznam pojištěných osob:");
                foreach (var osoba in seznamPojistenych)
                {
                    Console.WriteLine(osoba.ToString());
                }
            }
            else
            {
                Console.WriteLine("Seznam pojištěných je prázdný.");
            }
        }

        // Metoda pro vyhledání pojištěného podle jména a příjmení
        public PojistenaOsoba? VyhledejOsobu(string jmeno, string prijmeni)
        {
            return seznamPojistenych.Find(osoba => osoba.Jmeno == jmeno && osoba.Prijmeni == prijmeni);
        }
    }
}

