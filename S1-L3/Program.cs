using Esercizio3;
class Program
{
    static void Main()
    {
        // Esercizio 1
        ContoCorrente conto = new ContoCorrente("Alessandro Incalza");
        conto.AccessoConto(1200);
        conto.Versamento(500);
        conto.Prelievo(300);

        // Esercizio 2
        string[] nomi = { "Anna", "Luca", "Marco", "Giulia", "Francesco" };
        Console.Write("Inserisci il nome da cercare: ");
        string nomeDaCercare = Console.ReadLine();
        if (nomi.Contains(nomeDaCercare))
        {
            Console.WriteLine($"Il nome {nomeDaCercare} è presente nell'array.");
        }
        else
        {
            Console.WriteLine($"Il nome {nomeDaCercare} non è presente nell'array.");
        }

        // Esercizio 3
        Console.Write("Inserisci la dimensione dell'array: ");
        int dimensione = int.Parse(Console.ReadLine());
        int[] numeri = new int[dimensione];

        for (int i = 0; i < dimensione; i++)
        {
            Console.Write($"Inserisci il numero {i + 1}: ");
            numeri[i] = int.Parse(Console.ReadLine());
        }

        int somma = numeri.Sum();
        double media = numeri.Average();
        Console.WriteLine($"La somma degli elementi è: {somma}");
        Console.WriteLine($"La media degli elementi è: {media}");
    }
}
