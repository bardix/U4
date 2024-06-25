using System;
using System.Collections.Generic;
namespace Es_con_console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creare e popolamento del CV
            CV mioCV = new CV
            {
                InformazioniPersonali = new InformazioniPersonali
                {
                    nome = "Marco",
                    cognome = "Puccio",
                    telefono = "+393288317446",
                    email = "info@marcopuccio.com"
                },
                StudiEffettuati = new List<Studi>
            {
                new Studi
                {
                    qualifica = "Qualifica",
                    istituto = "UniPa",
                    tipo = "Tipo",
                    dal = new DateTime(2016, 09, 12),
                    al = new DateTime(2019, 07, 22)
                },
                new Studi
                {
                    qualifica = "Specializzazione sviluppo software",
                    istituto = "Microsoft Center Milan",
                    tipo = "Specializzazione",
                    dal = new DateTime(2016, 09, 12),
                    al = new DateTime(2019, 07, 22)
                }
            },
                Impieghi = new List<Impiego>
            {
                new Impiego
                {
                    esperienza = new Esperienza
                    {
                        azienda = "Libero Professionista",
                        jobTitle = "IT Manager",
                        dal = new DateTime(2016, 09, 12),
                        al = new DateTime(2016, 09, 12),
                        descrizione = "Sviluppatore software",
                        compiti = "Compito"
                    }
                },
                new Impiego
                {
                    esperienza = new Esperienza
                    {
                        azienda = "Libero Professionista",
                        jobTitle = "Docenza e Formazione",
                        dal = new DateTime(2016, 09, 12),
                        al = new DateTime(2016, 09, 12),
                        descrizione = "Docente e formatore",
                        compiti = "Compito"
                    }
                }
            }
            };

            // Stampa dei dettagli del CV su schermo
            StampaDettagliCVSuSchermo(mioCV);
        }

        static void StampaDettagliCVSuSchermo(CV cv)
        {
            Console.WriteLine("++++ INIZIO Informazioni Personali: ++++");
            Console.WriteLine($"Nome: {cv.InformazioniPersonali.nome}");
            Console.WriteLine($"Cognome: {cv.InformazioniPersonali.cognome}");
            Console.WriteLine($"Telefono: {cv.InformazioniPersonali.telefono}");
            Console.WriteLine($"Email: {cv.InformazioniPersonali.email}");
            Console.WriteLine("++++ FINE Informazioni Personali: ++++");

            Console.WriteLine("++++ INIZIO Studi e Formazione: ++++");
            foreach (var studi in cv.StudiEffettuati)
            {
                Console.WriteLine($"Istituto: {studi.istituto}");
                Console.WriteLine($"Qualifica: {studi.qualifica}");
                Console.WriteLine($"Tipo: {studi.tipo}");
                Console.WriteLine($"Dal: {studi.dal:dd/MM/yyyy} al {studi.al:dd/MM/yyyy}");
            }
            Console.WriteLine("++++ FINE Studi e Formazione: ++++");

            Console.WriteLine("++++ INIZIO Esperienze professionali: ++++");
            foreach (var impiego in cv.Impieghi)
            {
                Console.WriteLine($"Presso: {impiego.esperienza.azienda}");
                Console.WriteLine($"Tipo di lavoro: {impiego.esperienza.jobTitle}");
                Console.WriteLine($"Compito: {impiego.esperienza.descrizione}");
                Console.WriteLine($"Dal: {impiego.esperienza.dal:dd/MM/yyyy} al {impiego.esperienza.al:dd/MM/yyyy}");
            }
            Console.WriteLine("++++ FINE Esperienze professionali: ++++");
        }
    }
}
