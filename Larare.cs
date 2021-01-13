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
        /*
                  (string Namn, int PersonalID, long PersonNummer, string Email, int TelNr)

                 this.Namn = namn;
                 this.PersonalID = personalID;
                 this.PersonNummer = personNnummer;
                 this.Email = email;
                 this.TelNr = telNr;
          */

        public Larare(string Namn, int PersonalID, long PersonNummer, string Email, int TelNr)
        {
            this.Namn = namn;
            this.PersonalID = personalID;
            this.PersonNummer = personNnummer;
            this.Email = email;
            this.TelNr = telNr;
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
