using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hogskolan_Sarob
{
    public class Larare : Personal, ILarare
    {
        #region Variabler och ctor

        private string namn;
        private int personalID;
        private long personNummer;
        private long personNnummer;
        private string email;
        private int telNr;
        private TextBox personalNamnText;
        private int v1;
        private long v2;
        private TextBox personalEmailText;
        private int v3;

        public Larare(string Namn, int PersonalID, long PersonNummer, string Email, int TelNr)
        {
            this.Namn = namn;
            this.PersonalID = personalID;
            this.PersonNummer = personNnummer;
            this.Email = email;
            this.TelNr = telNr;
        }

        public Larare(TextBox personalNamnText, int v1, long v2, TextBox personalEmailText, int v3)
        {
            this.personalNamnText = personalNamnText;
            this.v1 = v1;
            this.v2 = v2;
            this.personalEmailText = personalEmailText;
            this.v3 = v3;
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