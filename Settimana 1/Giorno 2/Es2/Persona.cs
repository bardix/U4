using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Es2
{
    internal class Persona
    {
        public string Nome;
        public string Cognome;
        public int Eta;

        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetCognome()
        {
            return Cognome;
        }

        public int GetEta()
        {
            return Eta;
        }

        public string GetDettagli()
        {
            return $"Nome: {Nome}, Cognome: {Cognome}, Età: {Eta}";
        }


    }
}
