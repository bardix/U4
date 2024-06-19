namespace RicercaNomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definire la dimensione dell'array
            int dimensioneArray = 5;
            string[] nomi = new string[dimensioneArray];

            // Caricare l'array con nomi
            for (int i = 0; i < dimensioneArray; i++)
            {
                Console.Write($"Inserisci il nome {i + 1}: ");
                nomi[i] = Console.ReadLine();
            }

            // Specificare un nome da ricercare
            Console.Write("Inserisci il nome da ricercare: ");
            string nomeDaRicercare = Console.ReadLine();

            // Verificare se il nome è presente nell'array
            bool nomeTrovato = false;
            foreach (string nome in nomi)
            {
                if (nome.Equals(nomeDaRicercare, StringComparison.OrdinalIgnoreCase))
                {
                    nomeTrovato = true;
                    break;
                }
            }

            // Stampare il risultato della ricerca
            if (nomeTrovato)
            {
                Console.WriteLine("Il nome è presente nell'array.");
            }
            else
            {
                Console.WriteLine("Il nome non è presente nell'array.");
            }
        }
    }
}