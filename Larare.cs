using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogskolan_Sarob
{
    class Larare: Personal, ILarare
    {
        #region Variabler och ctor

        private string namn;
        private int personalID;
        private long personNummer;
        private long personNnummer;
        private string email;
        private int telNr;
   
     /*   private int lararLagsID;*/
        private string text1;
        private int v1;
        private long v2;
        private string text2;
        private int v3;



        public Larare(string Namn, int PersonalID, long PersonNummer, string Email, int TelNr /*int LararlagsID*/)
        {
            this.Namn = namn;
            this.PersonalID = personalID;
            this.PersonNummer = personNnummer;
            this.Email = email;
            this.TelNr = telNr;

          /*  this.LararLagsID = LararLagsID;*/
        }

     
        public void laddaLarareFranFil()
        {
            throw new NotImplementedException();
        }

        public void sparaLarareTillFil()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
