using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione_settimana_12_Giorno_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autovetture auto1 = new Autovetture();
            auto1.Marca = "BMW";                    // set

            Autovetture auto2 = new Autovetture();
            auto2.Marca = "Ford";                   // set

            Console.WriteLine("Prima auto: " + auto1.Marca); // get
         // Console.WriteLine("\n"); va a capo in console

            Console.WriteLine("Seconda auto: " + auto2.Marca);

            auto1.Marca = "Ferrari";
            Console.WriteLine("Prima auto aggiornata: " + auto1.Marca);

            string Messaggio = auto1.kmTagliando(500); // richiamo metodo
            Console.WriteLine("Tagliando Auto 1: " + Messaggio);

            string Messaggio2 = auto2.kmTagliando(15000);
            Console.WriteLine("Tagliando Auto 2: " + Messaggio2);
            Console.WriteLine("\n");

            //////////////////////////////////////////////////////////////////////

            Animale animale1 = new Animale();
            animale1.Nome = "Calogero";
            animale1.Eta = 14;
            string Msg = animale1.razzaAnimale("gatto");
            Console.WriteLine(animale1.Nome + ". Ho " + animale1.Eta + " anni. " + Msg);

            Animale animale2 = new Animale();
            animale2.Nome = "Alfredo";
            animale2.Eta = 8;
            string Msg2 = animale2.razzaAnimale("cane");
            Console.WriteLine(animale2.Nome + ". Ho " + animale2.Eta + " anni. " + Msg2);

            ///////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n");

            Dipendente dipendente1 = new Dipendente();
            dipendente1.Nome = "Giovanni";
            dipendente1.Cognome = "Bho";
            dipendente1.Azienda = "Epicode";
            string MessGiorniLavorati = dipendente1.giorniLavorati(266);
            Console.WriteLine(dipendente1.Nome + " " + dipendente1.Cognome + " " + MessGiorniLavorati + " presso " + dipendente1.Azienda);

            ///////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n");


            Atleta atleta = new Atleta();
            atleta.Nome = "Franco";
            atleta.Sport = "Basket";
            atleta.stampaDatiAtleta();

            ///////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n");

            Veicolo mioVeicolo = new Veicolo();

            mioVeicolo.accendi();
            mioVeicolo.spegni();
            mioVeicolo.accendi();



            Console.ReadLine(); // attendo un input per chiudere la console
        }
    }
}
