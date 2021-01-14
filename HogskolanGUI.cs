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
        private Button button2;
    

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
            this.button2 = new System.Windows.Forms.Button();
            this.personalNamnText.Location = new System.Drawing.Point(169, 26);
            this.personalNamnText.Size = new System.Drawing.Size(500, 20);
            this.personalNamnText.Text = "Lärarnamn";
            ///
            this.personalPersonalIDText.Location = new System.Drawing.Point(169, 57);
            this.personalPersonalIDText.Size = new System.Drawing.Size(200, 20);
            this.personalPersonalIDText.Text = "PersonalID";
            ///
            this.personalPersonnummerText.Location = new System.Drawing.Point(169, 80);
            this.personalPersonnummerText.Size = new System.Drawing.Size(100, 20);
            this.personalPersonnummerText.Text = "Personnummer";
            ///
            this.personalEmailText.Location = new System.Drawing.Point(169, 120);
            this.personalEmailText.Size = new System.Drawing.Size(100, 20);
            this.personalEmailText.Text = "Email";
            ///
            this.personalTelNrText.Location = new System.Drawing.Point(169, 150);
            this.personalTelNrText.Size = new System.Drawing.Size(100, 20);
            this.personalTelNrText.Text = "Telefonnummer";
            ///
         /*   this.personalLararLagsIDText.Location = new System.Drawing.Point(169, 170);
            this.personalLararLagsIDText.Size = new System.Drawing.Size(100, 20);
            this.personalLararLagsIDText.Text = "LärarlagsID"; */
            ///
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Size = new System.Drawing.Size(120, 300);
            this.button1.Location = new System.Drawing.Point(180, 210);
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.Text = "Lägg till";
            this.button2.Text = "Ta bort";
            this.button2.Location = new System.Drawing.Point(180, 250);
            this.button2.Size = new System.Drawing.Size(75, 23);
            ///this.button1.Location = new System.Drawing.Point(180, 250);
            ///this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.Delete_Click);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.button2.Click += new System.EventHandler(Delete_Click);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
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
            InitializeLararLista();
            listBox1.DataSource = lararLista;
            listBox1.DisplayMember = "Lägg till/Ta Bort Lärare";
            lararLista.AddingNew += new AddingNewEventHandler(lararLista_AddingNew);
            lararLista.ListChanged += new ListChangedEventHandler(lararLista_ListChanged);
          
        }

        #region childform

        /// <summary>
        /// Gör detta till en childform
        /// </summary>
        private static HogskolanGUI m_SChildform;
        public static HogskolanGUI GetChildInstance()
        {
            if (m_SChildform == null) //if not created yet, Create an instance

                m_SChildform = new HogskolanGUI();
            return m_SChildform;  //just created or created earlier.Return it

        }

        #endregion

        /// <summary>
        /// Deklarerar en ny bindinglist
        /// </summary>
        BindingList<Larare> lararLista;
        private void InitializeLararLista()
        {

            lararLista = new BindingList<Larare>();

            lararLista.AllowNew = true;
            lararLista.AllowRemove = true;


            lararLista.RaiseListChangedEvents = true;


            lararLista.AllowEdit = false;
        }

        #region Lägg till/ta bort

        /// <summary>
        /// Skapar nya objekt av typen Larare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void lararLista_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Larare(personalNamnText, int.Parse(personalPersonalIDText.Text), long.Parse(personalPersonnummerText.Text),
                personalEmailText, int.Parse(personalTelNrText.Text));

        }

        /// <summary>
        /// Lägger till de attribut som finns i objektet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Larare larare = lararLista.AddNew();

            personalNamnText.Text = personalNamnText.ToString();

          

            int.Parse(personalPersonalIDText.Text);

            long.Parse(personalPersonnummerText.Text);
            personalEmailText.Text = personalEmailText.ToString();
            int.Parse(personalTelNrText.Text);


        }

        /// <summary>
        /// Uppdaterar listan med nya objekt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void lararLista_ListChanged(object sender, ListChangedEventArgs e)
        {
            MessageBox.Show(e.ListChangedType.ToString());

        }

        /// <summary>
        /// Raderar ett visst objekt i listan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Click(object sender, EventArgs e)
        {
            lararLista.Clear();

        }
        #endregion
    }
}
