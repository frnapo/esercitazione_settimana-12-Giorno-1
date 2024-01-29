using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione_settimana_12_Giorno_1
{
    public class Dipendente
    {
        private string _name;
        private string _surname;
        private string _company;
        public string Nome 
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Cognome 
        { 
            get { return _surname; }
            set { _surname = value; }
        }

        public string Azienda 
        { 
            get { return _company; }
            set { _company = value; }
        }

        public string giorniLavorati(int giorni)
        {
            return $"ha lavorato {giorni} quest'anno";
        }
    }
}
