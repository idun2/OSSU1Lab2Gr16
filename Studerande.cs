using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering
{
    public class Studerande
    {

        public List<Studerande> studentInfo = new List<Studerande>();

        public string studentID { get; set; }

        public string namn { get; set; }

        public long personNummer { get; set; }

        public string Email { get; set; }

        public int TelNr { get; set; }

        public string registreradPåKurser { get; set; }

        public string betyg { get; set; }

        Studerande(string studentID, string namn, long personNummer, string Email, int TelNr, string registreradPåKurser)
        {

            this.studentID = studentID;
            this.namn = namn;
            this.personNummer = personNummer;
            this.Email = Email;
            this.TelNr = TelNr;



        }


        public void ListaStudenter()
        {

            foreach (var student in studentInfo)
            {

                Console.WriteLine($"studentID:{student.studentID}\tNamn:{student.namn}\tPersonnummer:{student.personNummer}\tEmail:{student.Email}\tTelefonnummer:{student.TelNr} ");


            }



        }


        public void LäggTillStudent(string studentID, string namn, long personNummer, string Email, int TelNr, string registreradPåKurser)
        {
            Console.Write("Ange nytt studentID:");
            studentID = Console.ReadLine();
            Console.Write("Ange studentens namn:");
            namn = Console.ReadLine();
            Console.Write("Ange personnummer:");
            personNummer = long.Parse(Console.ReadLine());
            Console.Write("Ange Email:");
            Email = Console.ReadLine();
            Console.Write("Ange telefonnummer:");
            TelNr = int.Parse(Console.ReadLine());


            studentInfo.Add(new Studerande(studentID, namn, personNummer, Email, TelNr, registreradPåKurser));


        }

        public void TabortStudent()
        {


            Console.WriteLine("Vilken student vill du tabort?");
            Console.Write("Ange studentID:");
            string tabortStudentID = Console.ReadLine();




        }

        public void LäggTillBetyg()
        {




        }



        public void TabortBetyg()
        {




        }



    }
}


