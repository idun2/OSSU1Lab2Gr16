using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Objektorientering
{
    interface IHögskola
    {
        string HögskolansNamn { get; set; }

        int Kontaktnummer { get; set; }

        List<string> KurserSomErbjuds { get; set; }

        Kurs ListaKurser(string KursNamn, int KursID);

    }

    class Högskola:IHögskola
    {

        public string HögskolansNamn { get; set; }
        public int Kontaktnummer { get; set; }

        public List<string> KurserSomErbjuds { get; set; }

        public Högskola (string HögskolansNamn, int Kontaktnummer)
        {
            this.HögskolansNamn = HögskolansNamn;
            this.Kontaktnummer = Kontaktnummer;
            this.KurserSomErbjuds = new List<string>();


        }

        public Kurs ListaKurser(string KursNamn, int KursID)

        { //foreach (string Kurser in KurserSomErbjuds){Console.WriteLine($"{Kurser.KursNamn}"); }

            


        }




    }



}
