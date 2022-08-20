using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojištění
{
    /// <summary>
    /// Databaze pro uložení pojištěnců
    /// </summary>
    internal class DataBaze
    {
        /// <summary>
        /// Seznam pojištěnců
        /// </summary>
        private List<Osoba> osobyBaze;

        /// <summary>
        /// Vytvoří novou instanci databazy
        /// </summary>
        public DataBaze()
        {
            osobyBaze = new List<Osoba>();
        }

        /// <summary>
        /// Dodává pojištěného v seznam pojištěnců
        /// </summary>
        /// <param name="jmeno">Jméno pojištěného</param>
        /// <param name="prijmeni">Přijmení pojištěného</param>
        /// <param name="vek">Věk pojištěného</param>
        /// <param name="telcislo">Telefonní číslo</param>
        public void PridejOsobu(string jmeno, string prijmeni, int vek, int telcislo)
        {
            osobyBaze.Add(new Osoba(jmeno, prijmeni, vek, telcislo));
        }

        /// <summary>
        /// Vyhledávání pojištěného v seznamu podle jména nebo přijmení
        /// </summary>
        /// <param name="jmeno">Jméno pojištěného</param>
        /// <param name="prijmeni">Přijmení pojištěného</param>
        /// <returns></returns>
        public List<Osoba> NajdiOsobu(string jmeno, string prijmeni)
        {
            //Seznam nalezených osob
            List<Osoba> nalezene = new List<Osoba>();
            
            foreach(Osoba os in osobyBaze)
            {
                if (jmeno.ToLower() == os.Jmeno.ToLower() || prijmeni.ToLower() == os.Prijmeni.ToLower())
                    nalezene.Add(os);
            }

            return nalezene;
        }

        /// <summary>
        /// Výpís všech pojištěnců
        /// </summary>
        /// <returns>Seznam všećh pojištěnců</returns>
        public List<Osoba> ZaznamPojistenich()
        {
            //Seznam všech pojištěnců
            List<Osoba> vsePojisteni = new List<Osoba>();
            foreach (Osoba os in osobyBaze)
            {
                vsePojisteni.Add(os);
            }

            return vsePojisteni;
        }

    }
}
