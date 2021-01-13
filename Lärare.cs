using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering
{

    interface ILarare
    {
        void sparaLarareTillFil();

        void laddaLarareFranFil();


    }

    ///lärarklass

    class Larare : Personal, ILarare
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
        private string taBort;



        public Larare(string Namn, int PersonalID, long PersonNummer, string Email, int TelNr, bool AdminRights, int LararlagsID)
        {
            this.Namn = namn;
            this.PersonalID = personalID;
            this.PersonNummer = personNnummer;
            this.Email = email;
            this.TelNr = telNr;
            this.AdminRights = adminRights;
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
