using Evidence_pojištění;

//instance třídy Funkcnost
Funkcnost funk = new Funkcnost();
char volba = '0';

//cyklus výběru akce
while (volba != '4')
{
    funk.VypisUvodniObrazovku();
    Console.WriteLine();
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojisteného");
    Console.WriteLine("2 - Vypsat všechny pojistené");
    Console.WriteLine("3 - Vyhledat pojisteného");
    Console.WriteLine("4 - Konec");

    volba = Console.ReadKey().KeyChar;
    Console.WriteLine();

    // reakce na volbu
    switch(volba)
    {
        case '1':
            funk.PridejOsobu();
            break;
        case '2':
            funk.VypisPojistenich();
            break;
        case '3':
            funk.VyhledaniPojisteneho();
            break;
        case '4':
            Console.WriteLine("Libovolnou klávesou ukončíte program...");
            break;
        default:
            Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
            break;
    }

    Console.ReadKey();
}



