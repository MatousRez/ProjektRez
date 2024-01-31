using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Evidence_pojištění
{
    public class UzivatelskeRozhrani
    {
        // Metoda pro výpis úvodního textu
        public void VypisUvitani()
        {
            Console.WriteLine("Vítejte v aplikaci!");
        }

        // Metoda pro výběr a výpis možností
        public void VypisMenu()
        {
            Console.WriteLine("Vyberte z možností:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Zobrazit seznam pojištěných");
            Console.WriteLine("3 - Vyhledat pojištěného podle jména a příjmení");
            Console.WriteLine("4 - Konec");
        }

        // Metoda pro čtení vstupu od uživatele
        public string ZiskejVstup()
        {
            return Console.ReadLine()!;
        }

        // Metoda pro výpis zprávy s výzvou k pokračování
        public void VypisZpravuSKoncemAkce(string zprava)
        {
            Console.WriteLine(zprava);
            Console.WriteLine("Pokračujte libovolnou klávesou...");
            Console.ReadKey();
            Console.Clear();
        }

        // Metoda pro výpis zprávy
        public void VypisZpravu(string zprava)
        {
            Console.WriteLine(zprava);
        }
    }
}

