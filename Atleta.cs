using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione_settimana_12_Giorno_1
{
    public class Atleta
    {
        public string Nome {  get; set; }
        public string Sport { get; set; }

        public void stampaDatiAtleta()
        {
            Console.WriteLine("Nome dell'atleta: " + Nome);
            Console.WriteLine("Sport praticato: " + Sport);
        }

    }
}
