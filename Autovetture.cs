using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione_settimana_12_Giorno_1
{
    public class Autovetture
    {
        private string _marca;

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string kmTagliando(int attuale)
        {
            if(attuale > 10000)
            {
                return "tagliando da effettuare";
            } 
            else
            {
                return "torna tra qualche km :)";
            }
        }
    }
}
