using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering

{



	public interface Ikurser

	{
		public int kursID { get; set; }
		public string Kurser { get; set; }
		public string kursNamn { get; set; }
		public string lärarlag { get; set; }
		public string kursAnsvarig { get; set; }
		public int antalStudenter { get; set; }
		public int antalLaborationer { get; set; }
		public string nylabb { get; set; }



		void Laborationer();
		void Registrerastudenter();
		void Registreralärare();
	}

	//implementera interface

	public class Kurs : Ikurser
	{



		public int kursID { get; set; }
		public string Kurser { get; set; }
		public string kursNamn { get; set; }
		public string lärarlag { get; set; }
		public string kursAnsvarig { get; set; }
		public int antalStudenter { get; set; }
		public int antalLaborationer { get; set; }
		public string nylabb { get; set; }




		public Kurs kurser

		{
			get { return kurser; }
		}




		public void Laborationer()
		{

		}

		public void Registreralärare()
		{

		}

		public void Registrerastudenter()
		{

		}

		//skapa kurser och utför metoder nedan




		public void Laborationer(int antalLaborationer, string nylabb, int antalStudenter)
		{

			//skapa laborationer och tilldela till kurs




		}

		public void Registrerastudenter(string kurser, string kursNamn, int kursID, string lärarlag, string kursansvarig, int antalStudenter)
		{

			//registrera till kurs
			//ta bort ur kurs
		}

		public void Registreralärare(string kurser, string kursNamn, string kursAnsvarig, string lärarlag)

		{

			//registrera till kurs
			//ta bort ur kurs

		}



	}

}

