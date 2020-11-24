using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsform
{
    public partial class opretbrugerbil : Form
    {

        bool boolean = false;
        public opretbrugerbil()
        {
            InitializeComponent();
        }

        private void opretbrugerbil_tilbage_Click(object sender, EventArgs e)
        {

            var hovedmenu = new hovedmenu();
            hovedmenu.Location = this.Location;
            hovedmenu.StartPosition = FormStartPosition.Manual;
            hovedmenu.FormClosing += delegate { this.Show(); };
            hovedmenu.Show();
            boolean = true;
            this.Close();
            boolean = false;

        }

        private void formclosed(object sender, FormClosingEventArgs e)

        {
            if (e.CloseReason == CloseReason.UserClosing && boolean == false)
            {
                Application.Exit();
            }

        }

        private void opretbrugerbil_bruger_Click(object sender, EventArgs e)
        {

            var opretbruger = new opretbruger();
            opretbruger.Location = this.Location;
            opretbruger.StartPosition = FormStartPosition.Manual;
            opretbruger.FormClosing += delegate { this.Show(); };
            opretbruger.Show();
            boolean = true;
            this.Close();
            boolean = false;

        }

        private void opretbrugerbil_logind_Click(object sender, EventArgs e)
        {

            var opretbil = new tilføjbil();
            opretbil.Location = this.Location;
            opretbil.StartPosition = FormStartPosition.Manual;
            opretbil.FormClosing += delegate { this.Show(); };
            opretbil.Show();
            boolean = true;
            this.Close();
            boolean = false;

        }
    }
}
