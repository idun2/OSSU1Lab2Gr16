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
    public partial class StartGUI : Form
    {
        public StartGUI()
        {
            InitializeComponent();
        }

        private void läggTillTaBortLärareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HogskolanGUI objfrmHome = HogskolanGUI.GetChildInstance();
            objfrmHome.MdiParent = this;
            objfrmHome.WindowState = FormWindowState.Maximized;
            objfrmHome.Show();
            objfrmHome.BringToFront();
        }
    }
}
