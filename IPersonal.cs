using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogskolan_Sarob
{
    interface IPersonal
    {
        string Namn { get; set; }
        int PersonalID { get; set; }
        long PersonNummer { get; set; }
        string Email { get; set; }
        int TelNr { get; set; }

        int LararLagsID { get; set; }
        string TaBort { get; set; }



        void laggTillLarare(string Namn, int PersonalID, long Personnummer, string Email, int TelNr, int LararLagsID);

        void listaLararare();
    }
}
