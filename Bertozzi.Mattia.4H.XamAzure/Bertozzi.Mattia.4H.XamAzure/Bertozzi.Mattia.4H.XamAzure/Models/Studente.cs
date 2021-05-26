using System;
using System.Collections.Generic;
using System.Text;

namespace Bertozzi.Mattia._4H.XamAzure.Models
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Immagine { get; set; }
        public string Dettagli { get; set; }

        public string NomeCognome
        {
            get
            {
                return $"{Nome} {Cognome}";
            }
        }

        public Studente() { }


        public string URLImmagine
        {
            get
            {
                return @"https://bertozzi-mattia-4h-xamazureapi-gg2.conveyor.cloud/Images/" + Immagine;
            }
        }
    }
}
