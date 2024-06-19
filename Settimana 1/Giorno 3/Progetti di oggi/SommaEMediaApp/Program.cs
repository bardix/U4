namespace SommaEMediaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inserire la dimensione dell'array
            Console.Write("Inserisci la dimensione dell'array: ");
            int dimensioneArray = int.Parse(Console.ReadLine());

            // Dichiarare l'array
            int[] numeri = new int[dimensioneArray];

            // Caricare l'array con numeri interi
            for (int i = 0; i < dimensioneArray; i++)
            {
                Console.Write($"Inserisci il numero {i + 1}: ");
                numeri[i] = int.Parse(Console.ReadLine());
            }

            // Calcolare la somma e la media
            int somma = 0;
            foreach (int numero in numeri)
            {
                somma += numero;
            }
            double media = (double)somma / dimensioneArray;

            // Restituire la somma e la media
            Console.WriteLine($"La somma di tutti i numeri inseriti è: {somma}");
            Console.WriteLine($"La media aritmetica di tutti i numeri inseriti è: {media}");
        }
    }
}