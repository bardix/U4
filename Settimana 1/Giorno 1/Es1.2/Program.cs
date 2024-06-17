namespace Es1._2 // contenitore logico
{
    internal class Program //unità minima di codice che rappresenta un contenitore di più metodi ed informazioni
    {
        static void Main(string[] args) //Metodo: principale contenitore di codice , il metodo Main rappresenta l'entry pint dell'applicazione
        {
            Console.WriteLine("Hello, World!"); 
            int x = 0;
            Console.WriteLine(x);
            string y = "questa è una  stringa";
            Console.WriteLine(y);

            Persona persona = new Persona();
            persona.età = 10;
            persona.nome = "Giorgio";

            Console.WriteLine(persona.età);
        }
    }
}

// 