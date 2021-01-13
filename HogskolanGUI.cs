using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hogskolan_Sarob
{
    public partial class HogskolanGUI : Form
    {
        #region variabler och ctor

        private TextBox personalNamnText;
        private TextBox personalPersonalIDText;
        private TextBox personalPersonnummerText;
        private TextBox personalEmailText;
        private TextBox personalTelNrText;
        private ListBox listBox1;
        private Button button1;
        private TextBox personalLararLagsIDText;
        private string S;

        public HogskolanGUI()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.personalNamnText = new System.Windows.Forms.TextBox();
            this.personalPersonalIDText = new System.Windows.Forms.TextBox();
            this.personalPersonnummerText = new System.Windows.Forms.TextBox();
            this.personalEmailText = new System.Windows.Forms.TextBox();
            this.personalTelNrText = new System.Windows.Forms.TextBox();
            this.personalLararLagsIDText = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.personalNamnText.Location = new System.Drawing.Point(169, 26);
            this.personalNamnText.Size = new System.Drawing.Size(100, 20);
            this.personalNamnText.Text = "Bracket";
            ///
            this.personalPersonalIDText.Location = new System.Drawing.Point(169, 57);
            this.personalPersonalIDText.Size = new System.Drawing.Size(100, 20);
            this.personalPersonalIDText.Text = "4343";
            ///
            this.personalPersonnummerText.Location = new System.Drawing.Point(169, 26);
            this.personalPersonnummerText.Size = new System.Drawing.Size(100, 20);
            this.personalPersonnummerText.Text = "Bracket";
            ///
            this.personalEmailText.Location = new System.Drawing.Point(169, 26);
            this.personalEmailText.Size = new System.Drawing.Size(100, 20);
            this.personalEmailText.Text = "Bracket";
            ///
            this.personalTelNrText.Location = new System.Drawing.Point(169, 26);
            this.personalTelNrText.Size = new System.Drawing.Size(100, 20);
            this.personalTelNrText.Text = "Bracket";
            ///
            this.personalLararLagsIDText.Location = new System.Drawing.Point(169, 26);
            this.personalLararLagsIDText.Size = new System.Drawing.Size(100, 20);
            this.personalLararLagsIDText.Text = "Bracket";
            ///
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.button1.Location = new System.Drawing.Point(180, 83);
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.Text = "Add New Item";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.personalNamnText);
            this.Controls.Add(this.personalPersonalIDText);
            this.Controls.Add(this.personalPersonnummerText);
            this.Controls.Add(this.personalEmailText);
            this.Controls.Add(this.personalTelNrText);
            this.Controls.Add(this.personalLararLagsIDText);
            this.Text = "Lägg till lärare";
            this.Load += new EventHandler(Form1_Load);
        }

        #endregion

        void Form1_Load(object sender, EventArgs e)
        {
            InitializeListOfParts();
            listBox1.DataSource = lararLista;
            listBox1.DisplayMember = "Lägg till/Ta Bort Lärare";
            lararLista.AddingNew += new AddingNewEventHandler(lararLista_AddingNew);
            lararLista.ListChanged += new ListChangedEventHandler(lararLista_ListChanged);
        }


        // Declare a new BindingListOfT with the Part business object.
        BindingList<Larare> lararLista;
        private void InitializeListOfParts()
        {

            lararLista = new BindingList<Larare>();

            lararLista.AllowNew = true;
            lararLista.AllowRemove = true;


            lararLista.RaiseListChangedEvents = true;


            lararLista.AllowEdit = false;


            lararLista.Add(new Larare("Rasmus", "123", "198911224130", "Rasmus@HS.se", "0704554488", "0"));

        }


        void lararLista_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Larare(personalNamnText.Text, int.Parse(personalPersonalIDText.Text), long.Parse(personalPersonnummerText.Text),
                personalEmailText.Text, int.Parse(personalLararLagsIDText.Text)
                ///string Namn, int PersonalID, long PersonNummer, string Email, int TelNr, int LararlagsID
                );
        }

        // Add the new part unless the part number contains
        // spaces. In that case cancel the add.
        private void button1_Click(object sender, EventArgs e)
        {
            Larare newPart = lararLista.AddNew();



            personalNamnText.Text = "Ange namn";
            personalPersonalIDText.Text =  = int.Parse("Ange personalID"); 
            personalPersonnummerText.Text = "Ange personnummer";
            personalEmailText.Text = "Ange email";
            personalTelNrText.Text = "Ange telefonnummer";


        }

        void lararLista_ListChanged(object sender, ListChangedEventArgs e)
        {
            MessageBox.Show(e.ListChangedType.ToString());
        }

    }
}
