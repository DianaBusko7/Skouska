using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojištění
{
    /// <summary>
    /// Reprezentace osoby pojištěného
    /// </summary>
    internal class Osoba
    {
        /// <summary>
        /// Jméno pojištěného
        /// </summary>
        public string Jmeno { get; private set; }
        /// <summary>
        /// Přijmeni pojištěného
        /// </summary>
        public string Prijmeni { get; private set; }
        /// <summary>
        /// Věk pojištěného
        /// </summary>
        public int Vek { get; private set; }
        /// <summary>
        /// Telefonní číslo
        /// </summary>
        public int TelCislo { get; private set; }
        /// <summary>
        /// Vytvoří novou instanci pojištěného
        /// </summary>
        /// <param name="jmeno">Jméno pojištěného</param>
        /// <param name="prijmeni">Přijmení pojištěného</param>
        /// <param name="vek">Věk pojištěného</param>
        /// <param name="telcislo">Telefonní číslo</param>
        public Osoba(string jmeno, string prijmeni, int vek, int telcislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelCislo = telcislo;
        }



        /// <summary>
        /// Vrátí textovou reprezentaci pojisteného
        /// </summary>
        /// <returns>Textová reprezentace pojisteného</returns>
        public override string ToString()
        {
            return String.Format("{0,-20} | {1,-20} | {2,-5} | {3,-15}", Jmeno, Prijmeni, Vek, TelCislo);
        }
    }
}
