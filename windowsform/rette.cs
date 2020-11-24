using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace windowsform
{

    public partial class rette : Form
    {
        bool boolean = false;
        DBAccess dbaccess = new DBAccess();
        retteoplysninger setvar = new retteoplysninger();

        public rette()
        {
            InitializeComponent();
        }

        private void rette_enter_Click(object sender, EventArgs e)
        {
            //værdierne på kontakten
            string navnefternavn = "";
            string nummerplade = "";
            SqlCommand findname = null;
            SqlCommand findnummerplade = null;

            retteoplysninger setvar = new retteoplysninger();

            // if statements der afgøre hvor værdierne skal tilskrives
            if (rette_navn_eller_nummerplade_text.Text.Contains(" "))
            {
                navnefternavn = rette_navn_eller_nummerplade_text.Text;
                findname = new SqlCommand($"SELECT COUNT(*) from biler where NavnEfternavn like '{navnefternavn}'");

                setvar.navnefternavn = rette_navn_eller_nummerplade_text.Text;
            }
            else
            {
                nummerplade = rette_navn_eller_nummerplade_text.Text;
                findnummerplade = new SqlCommand($"SELECT COUNT(*) from biler where Nummerplade like '{nummerplade}'");

                setvar.nummerplade = rette_navn_eller_nummerplade_text.Text;
            }

            // if statements der tjekker om værdierne er tomme.
            if (navnefternavn.Equals("") && nummerplade.Equals(""))
            {
                MessageBox.Show("Venligst indtast dit navn og efternavn eller nummerplade");

            }
            else if (dbaccess.executescalar(findname) < 1 || dbaccess.executescalar(findnummerplade) < 1) // else statement der tjekker om brugeren findes i databasen
            {
                MessageBox.Show("Brugeren findes ikke. Venligst indtast ny bruger eller opret en ny bruger");
            }
            else
            {
                var km_oplysninger = new km_oplysninger();
                km_oplysninger.Location = this.Location;
                km_oplysninger.StartPosition = FormStartPosition.Manual;
                km_oplysninger.FormClosing += delegate { this.Show(); };
                km_oplysninger.Show();
                this.Hide();

            }
    }
        private void formclosed(object sender, FormClosingEventArgs e)

        {
            if (e.CloseReason == CloseReason.UserClosing && boolean == false)
            {
                Application.Exit();
            }

        }
        private void rette_tilbage_Click(object sender, EventArgs e)
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

        private void rette_tilbage_Click_1(object sender, EventArgs e)
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
    }
}
