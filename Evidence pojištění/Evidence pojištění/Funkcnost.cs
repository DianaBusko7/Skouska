using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojištění
{
    /// <summary>
    /// Funkčnost programu
    /// </summary>
    internal class Funkcnost
    {
        /// <summary>
        /// instance databazy
        /// </summary>
        private DataBaze databaze;
        public Funkcnost()
        {
            databaze = new DataBaze();
        }
        /// <summary>
        /// Zjistí jméno pojištěného od uživatele
        /// </summary>
        /// <returns>Jméno pojištěného</returns>
        private string ZjistiJmeno()
        {
            string jmeno;
            Console.WriteLine("Zadejte jméno pojisteného:");
            do
            {
                jmeno = Console.ReadLine();
                if(string.IsNullOrEmpty(jmeno)) //ošetření prazdného vstupu
                    Console.WriteLine("Chybné zadání, zadejte jméno znovu");
            }
            while (jmeno.Length == 0);
                return jmeno;

        }
        /// <summary>
        /// Zjistí příjmení pojištěného od uživatele
        /// </summary>
        /// <returns>Příjmení pojištěného</returns>
        private string ZjistiPrijmeni()
        {
            string prijmeni;
            Console.WriteLine("Zadejte příjmení pojisteného:");
            do
            {
                prijmeni = Console.ReadLine();
                if(string.IsNullOrEmpty(prijmeni)) //ošetření prazdného vstupu
                    Console.WriteLine("Chybné zadání, zadejte příjmení znovu");
            }
            while (prijmeni.Length == 0);
            return prijmeni;
        }
        /// <summary>
        /// Zjistí telefonní číslo pojištěného od uživatele
        /// </summary>
        /// <returns>Telefonní číslo pojištěného</returns>
        private int ZjistiTelCislo()
        {
            int telcislo;
            bool x;
            Console.WriteLine("Zadejte telefonní číslo:");
            do
            {
                x = int.TryParse(Console.ReadLine(), out telcislo);  
                if(!x)    //ošetření vstupu, přijímá pouze čísla
                    Console.WriteLine("Chybné zadání, zadejte telefonní číslo znovu");
            }
            
            while (!x);
            return telcislo;
        }
        /// <summary>
        /// Zjistí věk pojištěného od uživatele
        /// </summary>
        /// <returns>Věk pojištěného</returns>
        private int ZjistiVek()
        {
            int vek;
            bool x;
            Console.WriteLine("Zadejte věk:");
            do
            {
                x = int.TryParse(Console.ReadLine(), out vek);
                if (!x)    //ošetření vstupu, přijímá pouze čísla a nepřijímá věk vice než 120
                    Console.WriteLine("Chybné zadání, zadejte věk znovu");
                else if (vek < 0 || vek > 120)
                {
                    x = false;
                    Console.WriteLine("Chybné zadání, zadejte věk znovu");
                }                    
            }
            while (!x);
            return vek;
        }
        /// <summary>
        /// Přidávání dat pojištěného v seznam pojištěnců databazy
        /// </summary>
        public void PridejOsobu()
        {
            string jmeno = ZjistiJmeno();
            string prijmeni = ZjistiPrijmeni();
            int vek = ZjistiVek();
            int telcislo = ZjistiTelCislo();

            databaze.PridejOsobu(jmeno, prijmeni, vek, telcislo);
            Console.WriteLine("\nData byla ulozena. Pokračujte libolovnou klávesou...");
        }
        /// <summary>
        /// Vypis tabulky všech pojištěnců
        /// </summary>
        public void VypisPojistenich()
        {
            //seznam všech osob
            List<Osoba> osoby = databaze.ZaznamPojistenich();
            VypisHlavicku();
            // Výpis záznamů
            foreach (Osoba s in osoby)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nPokračujte libolovnou klávesou...");
        }
        /// <summary>
        /// Vyhledávání pojištěného v databází podle jména nebo přijmení
        /// </summary>
        public void VyhledaniPojisteneho()
        {
            string jmeno = ZjistiJmeno();
            string prijmeni = ZjistiPrijmeni();
            List<Osoba> osoby = databaze.NajdiOsobu(jmeno, prijmeni);

            VypisHlavicku();
            if (osoby.Count() > 0)
            {
                //Výpis nalezených osob
                foreach (Osoba s in osoby)
                    Console.WriteLine(s);
            }
            else
                // Nenalezeno
                Console.WriteLine("\nNebyl nalezen žádný pojištěnec.");

            Console.WriteLine("\nPokračujte libolovnou klávesou...");
        }
        /// <summary>
        /// Vypis hlavičky menu
        /// </summary>
        public void VypisUvodniObrazovku()
        {
            Console.Clear();
                Console.WriteLine("---------------------------------" +
                    "\nEvidence pojíštěnych".ToUpper() +
                    "\n---------------------------------");
        }
        /// <summary>
        /// Vypisuje hlavičku tabulky pojištěnců
        /// </summary>
        public void VypisHlavicku()
        {
            Console.WriteLine("\n{0,-20} | {1,-20} | {2,-5} | {3,-15}", "Jmeno", "Prijmeni", "Vek", "Telefonní Cislo");
            Console.WriteLine("-------------------- | -------------------- | ----- | ---------------");
        }
    }
}
