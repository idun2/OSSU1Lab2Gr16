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
        private bool adminRights;
        private int lararLagsID;
        private string text1;
        private int v1;
        private long v2;
        private string text2;
        private int v3;

        public Larare(string text1, int v1, long v2, string text2, int v3)
        {
            this.text1 = text1;
            this.v1 = v1;
            this.v2 = v2;
            this.text2 = text2;
            this.v3 = v3;
        }

        public Larare(string Namn, int PersonalID, long PersonNummer, string Email, int TelNr, int LararlagsID)
        {
            this.Namn = namn;
            this.PersonalID = personalID;
            this.PersonNummer = personNnummer;
            this.Email = email;
            this.TelNr = telNr;

            this.LararLagsID = LararLagsID;
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
