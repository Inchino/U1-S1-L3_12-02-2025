using System;

namespace Esercizio3
{
    public class ContoCorrente
    {
        private string titolare;
        private double saldo;
        private bool aperto;

        public ContoCorrente(string titolare)
        {
            this.titolare = titolare;
            this.saldo = 0;
            this.aperto = false;
        }

        public void AccessoConto(double importo)
        {
            if (!aperto && importo >= 1000)
            {
                saldo = importo;
                aperto = true;
                Console.WriteLine($"Accesso avvenuto con successo! Benvenuto {titolare}, il tuo saldo è di {saldo} euro.");
            }
            else
            {
                Console.WriteLine($"Accesso negato! Assicurati di depositare almeno 1000 euro e che il conto sia in regola.");
            }
        }

        public void Versamento(double importo)
        {
            if (aperto && importo > 0)
            {
                saldo += importo;
                Console.WriteLine($"Versamento di {importo} euro effettuato. Saldo attuale: {saldo} euro.");
            }
            else
            {
                Console.WriteLine("Impossibile effettuare il versamento. Verifica che il conto sia aperto e l'importo sia positivo.");
            }
        }

        public void Prelievo(double importo)
        {
            if (aperto && importo > 0 && importo <= saldo)
            {
                saldo -= importo;
                Console.WriteLine($"Prelievo di {importo} euro effettuato. Saldo attuale: {saldo} euro.");
            }
            else
            {
                Console.WriteLine("Impossibile effettuare il prelievo. Verifica il saldo e che il conto sia aperto.");
            }
        }
    }
}
