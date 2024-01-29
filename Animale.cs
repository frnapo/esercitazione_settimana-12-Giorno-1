using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione_settimana_12_Giorno_1
{
    public class Animale
    {
        private string _name;
        private int _age;

        public string Nome
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Eta
        {
            get { return _age; }
            set { _age = value; }
        }

        public string razzaAnimale(string razza)
        {
            switch (razza)
            {
                case "gatto":
                    return "Sono un gatto!";
                case "cane":
                    return "Sono un cane!";
                case "pesce":
                    return "Sono un pesce!";
                default:
                    return "Razza sconosciuta";
            }
        }
    }
}