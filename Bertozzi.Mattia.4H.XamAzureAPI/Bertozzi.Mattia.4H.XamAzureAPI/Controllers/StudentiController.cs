using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bertozzi.Mattia._4H.XamAzure.Models;

namespace Bertozzi.Mattia._4H.XamAzureAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentiController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Studente> Get()
        {
            List<Studente> Studenti = new List<Studente>();

            Studenti.Add(new Studente { Nome = "Maurizio", Cognome = "Conti", Immagine = "mconti.png", Dettagli = "Custode dei luoghi e delle chiavi di Hogwards" });
            Studenti.Add(new Studente { Nome = "Fabio", Cognome = "Corbelli", Immagine = "fcorbelli.jpg", Dettagli = "Grande vecchio" });
            Studenti.Add(new Studente { Nome = "Alex", Cognome = "Mazzoni", Immagine = "alex.mazzoni.Jpeg" });
            Studenti.Add(new Studente { Nome = "Mattia", Cognome = "Bertozzi", Immagine = "mattia.bertozzi.Jpeg" });

            return Studenti;
        }

    }
}
