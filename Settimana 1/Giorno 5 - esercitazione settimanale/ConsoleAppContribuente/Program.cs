namespace ConsoleAppContribuente
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imposta la codifica della console a UTF-8 per supportare il simbolo dell'euro
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Richiesta dati contribuente
            Console.Write("Inserisci il nome: ");
            string nome = Console.ReadLine();  // Legge il nome dell'utente

            Console.Write("Inserisci il cognome: ");
            string cognome = Console.ReadLine();  // Legge il cognome dell'utente

            Console.Write("Inserisci la data di nascita (gg/mm/aaaa): ");
            DateTime dataNascita = DateTime.Parse(Console.ReadLine());  // Legge e converte la data di nascita

            Console.Write("Inserisci il codice fiscale: ");
            string codiceFiscale = Console.ReadLine();  // Legge il codice fiscale

            Console.Write("Inserisci il sesso (M/F): ");
            char sesso = Char.Parse(Console.ReadLine().ToUpper());  // Legge e converte il sesso in maiuscolo

            Console.Write("Inserisci il comune di residenza: ");
            string comuneResidenza = Console.ReadLine();  // Legge il comune di residenza

            Console.Write("Inserisci il reddito annuale: ");
            decimal redditoAnnuale = decimal.Parse(Console.ReadLine());  // Legge e converte il reddito annuale

            // Creazione oggetto contribuente
            Contribuente contribuente = new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);

            // Calcolo imposta da versare
            decimal imposta = contribuente.CalcolaImposta();

            // Stampa risultati
            Console.WriteLine("============================================");
            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
            Console.WriteLine($"Contribuente: {contribuente.Nome} {contribuente.Cognome},");
            Console.WriteLine($"nato il {contribuente.DataNascita.ToShortDateString()} ({contribuente.Sesso}),");
            Console.WriteLine($"residente in {contribuente.ComuneResidenza},");
            Console.WriteLine($"codice fiscale: {contribuente.CodiceFiscale}");
            Console.WriteLine($"Reddito dichiarato: {contribuente.RedditoAnnuale:C}");
            Console.WriteLine($"IMPOSTA DA VERSARE: {imposta} €"); // Simbolo dell'euro inserito direttamente
            Console.WriteLine("============================================");
        }
    }
}