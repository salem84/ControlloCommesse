using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlloCommesseWeb.Models
{
    public class ElementiResoconto
    {
        public string Titolo { get; set; }
        public TimeSpan Totale { get; set; }
        public int NumeroAttivita { get; set; }
    }
}
