namespace ConsoleAppMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Definizione del menu con prezzi
            Dictionary<int, (string, decimal)> menu = new Dictionary<int, (string, decimal)>
            {
                { 1, ("Coca Cola 150 ml", 2.50m) },
                { 2, ("Insalata di pollo", 5.20m) },
                { 3, ("Pizza Margherita", 10.00m) },
                { 4, ("Pizza 4 Formaggi", 12.50m) },
                { 5, ("Pizza patatine fritte", 3.50m) },
                { 6, ("Insalata di riso", 8.00m) },
                { 7, ("Frutta di stagione", 5.00m) },
                { 8, ("Pizza fritta", 5.00m) },
                { 9, ("Piadina vegetariana", 6.00m) },
                { 10, ("Panino Hamburger", 7.90m) }
            };

            List<int> ordini = new List<int>();

            while (true)
            {
                // Visualizza il menu
                Console.WriteLine("==============MENU==============");
                foreach (var voce in menu)
                {
                    Console.WriteLine($"{voce.Key}: {voce.Value.Item1} (€ {voce.Value.Item2:F2})");
                }
                Console.WriteLine("11: Stampa conto finale e conferma");
                Console.WriteLine("==============MENU==============");

                // Richiede la selezione dell'utente
                Console.Write("Seleziona un'opzione: ");
                if (int.TryParse(Console.ReadLine(), out int scelta) && (scelta >= 1 && scelta <= 11))
                {
                    if (scelta == 11)
                    {
                        // Stampa il conto finale e termina il programma
                        StampaContoFinale(menu, ordini);
                        break;
                    }
                    else
                    {
                        // Aggiunge l'ordine alla lista
                        ordini.Add(scelta);
                        Console.WriteLine($"{menu[scelta].Item1} aggiunto al tuo ordine.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Opzione non valida. Riprova.\n");
                }
            }
        }

        static void StampaContoFinale(Dictionary<int, (string, decimal)> menu, List<int> ordini)
        {
            decimal totale = 0;
            Console.WriteLine("\n=============CONTO FINALE=============");
            foreach (int ordine in ordini)
            {
                var item = menu[ordine];
                Console.WriteLine($"{item.Item1}: € {item.Item2:F2}");
                totale += item.Item2;
            }

            decimal servizio = 3.00m;
            totale += servizio;
            Console.WriteLine($"Servizio al tavolo: € {servizio:F2}");
            Console.WriteLine($"TOTALE DA PAGARE: € {totale:F2}");
            Console.WriteLine("======================================");
        }
    }
}