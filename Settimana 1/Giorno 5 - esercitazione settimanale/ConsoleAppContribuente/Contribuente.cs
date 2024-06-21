using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppContribuente
{
    internal class Contribuente
    {
        // Proprietà
        public string Nome { get; }
        public string Cognome { get; }
        public DateTime DataNascita { get; }
        public string CodiceFiscale { get; }
        public char Sesso { get; }
        public string ComuneResidenza { get; }
        public decimal RedditoAnnuale { get; }

        // Costruttore
        public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale, char sesso, string comuneResidenza, decimal redditoAnnuale)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;
        }

        // Metodo per calcolare l'imposta
        public decimal CalcolaImposta()
        {
            decimal imposta = 0;

            // Calcolo dell'imposta in base ai vari scaglioni di reddito
            if (RedditoAnnuale <= 15000)
            {
                imposta = RedditoAnnuale * 0.23m;  // 23% su reddito fino a 15.000
            }
            else if (RedditoAnnuale <= 28000)
            {
                imposta = 3450 + (RedditoAnnuale - 15000) * 0.27m;  // 27% sulla parte eccedente 15.000
            }
            else if (RedditoAnnuale <= 55000)
            {
                imposta = 6960 + (RedditoAnnuale - 28000) * 0.38m;  // 38% sulla parte eccedente 28.000
            }
            else if (RedditoAnnuale <= 75000)
            {
                imposta = 17220 + (RedditoAnnuale - 55000) * 0.41m;  // 41% sulla parte eccedente 55.000
            }
            else
            {
                imposta = 25420 + (RedditoAnnuale - 75000) * 0.43m;  // 43% sulla parte eccedente 75.000
            }

            return imposta;
        }
    }
}
