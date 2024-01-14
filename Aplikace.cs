namespace Evidence_pojištění
{
    public class Aplikace
    {
        public EvidencePojisteni evidencePojisteni;
        public UzivatelskeRozhrani uzivatelskeRozhrani;

        // Konstruktor
        public Aplikace()
        {
            evidencePojisteni = new EvidencePojisteni();
            uzivatelskeRozhrani = new UzivatelskeRozhrani();
        }

        // Hlavní metoda pro spuštění aplikace
        public void SpustitAplikaci()
        {
            while (true)
            {
                uzivatelskeRozhrani.VypisMenu();
                string volba = uzivatelskeRozhrani.ZiskejVstup();

                switch (volba)
                {
                    case "1":
                        PridatPojisteneho();
                        break;
                    case "2":
                        ZobrazitSeznam();
                        break;
                    case "3":
                        VyhledatPojisteneho();
                        break;
                    case "4":
                        return; // Konec aplikace
                    default:
                        uzivatelskeRozhrani.VypisZpravu("Neplatná volba, zadejte prosím znovu.");
                        break;
                }
            }
        }

        // Metoda pro přidání nového pojištěného
        private void PridatPojisteneho()
        {
            string jmeno = ZiskejVstupOdUzivatele("Zadejte jméno pojištěného: ");
            string prijmeni = ZiskejVstupOdUzivatele("Zadejte příjmení pojištěného: ");
            string telefon = ZiskejVstupOdUzivatele("Zadejte telefonní číslo pojištěného: ");
            int vek = ZiskejIntVstupOdUzivatele("Zadejte věk pojištěného: ");

            PojistenaOsoba novaOsoba = new PojistenaOsoba(jmeno, prijmeni, vek, telefon);
            evidencePojisteni.PridatPojisteneho(novaOsoba);
        }

        // Metoda pro zobrazení seznamu pojištěných
        private void ZobrazitSeznam()
        {
            var seznam = evidencePojisteni.ZiskaSeznam();
            uzivatelskeRozhrani.VypisZpravu("Seznam pojištěných osob:");

            foreach (var osoba in seznam)
            {
                uzivatelskeRozhrani.VypisZpravu(osoba.ToString());
            }
        }

        // Metoda pro vyhledání pojištěného podle jména a příjmení
        private void VyhledatPojisteneho()
        {
            uzivatelskeRozhrani.VypisZpravu("Vyhledání pojištěného:");
            string jmeno = ZiskejVstupOdUzivatele("Jméno: ");
            string prijmeni = ZiskejVstupOdUzivatele("Příjmení: ");

            PojistenaOsoba nalezenaOsoba = evidencePojisteni.VyhledejOsobu(jmeno, prijmeni);

            if (nalezenaOsoba != null)
            {
                uzivatelskeRozhrani.VypisZpravu($"Nalezený pojištěný: {nalezenaOsoba}");
            }
            else
            {
                uzivatelskeRozhrani.VypisZpravu("Pojištěný nebyl nalezen.");
            }
        }

        // Pomocná metoda pro čtení vstupu od uživatele
        private string ZiskejVstupOdUzivatele(string prompt)
        {
            uzivatelskeRozhrani.VypisZpravu(prompt);
            return uzivatelskeRozhrani.ZiskejVstup();
        }

        // Pomocná metoda pro čtení celočíselného vstupu od uživatele
        private int ZiskejIntVstupOdUzivatele(string prompt)
        {
            while (true)
            {
                string vstup = ZiskejVstupOdUzivatele(prompt);

                if (int.TryParse(vstup, out int cislo))
                {
                    return cislo;
                }

                uzivatelskeRozhrani.VypisZpravu("Neplatný vstup. Zadejte prosím platné číslo.");
            }
        }
    }
}

