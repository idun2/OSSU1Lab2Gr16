using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering
{
    interface IPersonal
    {
        string Namn { get; set; }
        int PersonalID { get; set; }
        long PersonNummer { get; set; }
        string Email { get; set; }
        int TelNr { get; set; }
        bool AdminRights { get; set; }
        int LararLagsID { get; set; }
        string TaBort { get; set; }

        void laggTillLarare(string Namn, int PersonalID, long Personnummer, string Email, int TelNr, bool AdminRights, int LararLagsID);

        void listaLararare();

    }

    ///Personal

    class Personal : IPersonal
    {
        #region Variabler 

        private string namn;
        private int personalID;
        private long personNummer;
        private string email;
        private int telNr;
        private bool adminRights;
        private int lararLagsID;
        private string taBort;

        public string Namn { get; set; }
        public int PersonalID { get; set; }
        public long PersonNummer { get; set; }
        public string Email { get; set; }
        public int TelNr { get; set; }
        public bool AdminRights { get; set; }
        public int LararLagsID { get; set; }
        public string TaBort { get; set; }

        #endregion

        List<Larare> Teacher = new List<Larare>();

        #region Metoder

        public void laggTillLarare(string Namn, int PersonalID, long PersonNummer, string Email, int TelNr, bool AdminRights, int LararLagsID)
        {
            Teacher.Add(new Larare(Namn, PersonalID, PersonNummer, Email, TelNr, AdminRights, LararLagsID));
        }

        public void listaLararare()
        {
            foreach (Larare Larare in Teacher)
            {
                Console.WriteLine($"{ Larare.Namn }\t{ Larare.PersonalID }\t{ Larare.PersonNummer } ");
            }
        }



        public void taBortLarare()
        {
            listaLararare();

            Console.WriteLine("Vilken lärare vill du ta bort?");

            string TaBort = Console.ReadLine();

            Larare TaBortL = (Larare)Convert.ChangeType(TaBort, typeof(Larare));

            Teacher.Remove(TaBortL);
        }

        #endregion

    }





}
