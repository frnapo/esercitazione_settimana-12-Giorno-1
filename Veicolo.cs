using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione_settimana_12_Giorno_1
{
    public class Veicolo
    {
        public bool Acceso { get; private set; }

        public void accendi()
        {
            if (!Acceso)
            {
                Acceso = true;
                Console.WriteLine("Il veicolo è stato acceso.");
            }
        }

        public void spegni()
        {
            if (Acceso)
            {
                Acceso = false;
                Console.WriteLine("Il veicolo è stato spento.");
            }
        }
    }
}