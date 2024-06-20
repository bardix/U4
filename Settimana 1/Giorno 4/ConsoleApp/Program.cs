using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public static class Utente
    {
        private static string username;
        private static string password;
        private static DateTime? dataLogin = null;
        private static List<(string Username, DateTime DataLogin)> accessi = new List<(string, DateTime)>();

        public static bool Login(string user, string pass, string confPass)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(confPass))
            {
                Console.WriteLine("Username e password non possono essere vuoti.");
                return false;
            }

            if (pass != confPass)
            {
                Console.WriteLine("Le password non coincidono.");
                return false;
            }

            username = user;
            password = pass;
            dataLogin = DateTime.Now;
            accessi.Add((username, dataLogin.Value));
            Console.WriteLine($"Login effettuato con successo. Benvenuto, {username}!");
            return true;
        }

        public static void Logout()
        {
            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Nessun utente è loggato.");
                return;
            }

            Console.WriteLine($"Logout effettuato. Arrivederci, {username}!");
            username = null;
            password = null;
            dataLogin = null;
        }

        public static void VerificaOraDataLogin()
        {
            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Nessun utente è loggato.");
                return;
            }

            Console.WriteLine($"Ultimo login effettuato il {dataLogin.Value}");
        }

        public static void ListaAccessi()
        {
            if (accessi.Count == 0)
            {
                Console.WriteLine("Nessun accesso registrato.");
                return;
            }

            Console.WriteLine("Lista degli accessi:");
            foreach (var accesso in accessi)
            {
                Console.WriteLine($"Username: {accesso.Username}, Data e ora: {accesso.DataLogin}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===============OPERAZIONI==============");
                Console.WriteLine("Scegli l'operazione da effettuare:");
                Console.WriteLine("1.: Login");
                Console.WriteLine("2.: Logout");
                Console.WriteLine("3.: Verifica ora e data di login");
                Console.WriteLine("4.: Lista degli accessi");
                Console.WriteLine("5.: Esci");
                Console.WriteLine("========================================");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        Console.Write("Inserisci username: ");
                        string user = Console.ReadLine();
                        Console.Write("Inserisci password: ");
                        string pass = Console.ReadLine();
                        Console.Write("Conferma password: ");
                        string confPass = Console.ReadLine();
                        Utente.Login(user, pass, confPass);
                        break;
                    case "2":
                        Utente.Logout();
                        break;
                    case "3":
                        Utente.VerificaOraDataLogin();
                        break;
                    case "4":
                        Utente.ListaAccessi();
                        break;
                    case "5":
                        Console.WriteLine("Uscita dalla applicazione...");
                        return;
                    default:
                        Console.WriteLine("Scelta non valida. Riprova.");
                        break;
                }

                Console.WriteLine("\nPremi un tasto per continuare...");
                Console.ReadKey();
            }
        }
    }
}