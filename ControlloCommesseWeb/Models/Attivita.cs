using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlloCommesseWeb.Models
{
    public class Attivita
    {
        public string Titolo { get; set; }
        public int IdCommessa { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }

        public TimeSpan OreFatte
        {
            get
            {
                //Aggiungo un minuto per arrotondare i secondi
                var diff = DataFine.TimeOfDay - DataInizio.TimeOfDay + new TimeSpan(0, 1, 0);
                return new TimeSpan(diff.Hours, diff.Minutes, 0);
            }
        }
    }
}
