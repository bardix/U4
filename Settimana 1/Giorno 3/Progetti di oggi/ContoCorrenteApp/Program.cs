namespace ContoCorrenteApp
{
    public class ContoCorrente
    {
        // Proprietà del Conto Corrente
        public string Intestatario { get; private set; }
        public string NumeroConto { get; private set; }
        public decimal Saldo { get; private set; }
        private bool ContoAperto { get; set; }

        // Costruttore
        public ContoCorrente(string intestatario, string numeroConto)
        {
            Intestatario = intestatario;
            NumeroConto = numeroConto;
            Saldo = 0;
            ContoAperto = false;
        }

        // Metodo per aprire il conto
        public bool ApriConto(decimal primoVersamento)
        {
            if (ContoAperto)
            {
                Console.WriteLine("Il conto è già aperto.");
                return false;
            }

            if (primoVersamento < 1000)
            {
                Console.WriteLine("Il primo versamento deve essere almeno 1000 euro.");
                return false;
            }

            Saldo += primoVersamento;
            ContoAperto = true;
            Console.WriteLine($"Conto aperto con successo. Saldo iniziale: {Saldo} euro.");
            return true;
        }

        // Metodo per fare un versamento
        public void Versamento(decimal importo)
        {
            if (!ContoAperto)
            {
                Console.WriteLine("Il conto non è aperto. Impossibile effettuare il versamento.");
                return;
            }

            Saldo += importo;
            Console.WriteLine($"Versamento di {importo} euro effettuato con successo. Saldo attuale: {Saldo} euro.");
        }

        // Metodo per fare un prelevamento
        public void Prelevamento(decimal importo)
        {
            if (!ContoAperto)
            {
                Console.WriteLine("Il conto non è aperto. Impossibile effettuare il prelevamento.");
                return;
            }

            if (importo > Saldo)
            {
                Console.WriteLine("Saldo insufficiente per effettuare il prelevamento.");
                return;
            }

            Saldo -= importo;
            Console.WriteLine($"Prelevamento di {importo} euro effettuato con successo. Saldo attuale: {Saldo} euro.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente conto = new ContoCorrente("Mario Rossi", "123456789");
            conto.ApriConto(1000);
            conto.Versamento(500);
            conto.Prelevamento(300);
            conto.Prelevamento(1500);  // Tentativo di prelevare più del saldo disponibile
        }
    }
}