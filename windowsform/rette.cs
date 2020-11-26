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
            retteoplysninger setvar = new retteoplysninger();
            string tekst = rette_navn_eller_nummerplade_text.Text;

            SqlCommand findname = new SqlCommand($"SELECT COUNT(*) from kontaktdata where NavnEfternavn like '{tekst}'");
            SqlCommand findplade = new SqlCommand($"SELECT COUNT(*) from biler where Nummerplade like '{tekst}'");


            // if statements der afgøre hvor værdierne skal tilskrives
            if (rette_navn_eller_nummerplade_text.Text.Contains(" ") && dbaccess.executescalar(findname) >= 1)
            {
                setvar.navnefternavn = rette_navn_eller_nummerplade_text.Text;

                var retteoplysninger = new retteoplysninger();
                retteoplysninger.Location = this.Location;
                retteoplysninger.StartPosition = FormStartPosition.Manual;
                retteoplysninger.FormClosing += delegate { this.Show(); };
                retteoplysninger.Show();
                this.Hide();

            }
            else if (rette_navn_eller_nummerplade_text.Text.Length > 2 && dbaccess.executescalar(findplade) >= 1)
            {
                setvar.nummerplade = rette_navn_eller_nummerplade_text.Text;

                var retteoplysninger = new retteoplysninger();
                retteoplysninger.Location = this.Location;
                retteoplysninger.StartPosition = FormStartPosition.Manual;
                retteoplysninger.FormClosing += delegate { this.Show(); };
                retteoplysninger.Show();
                this.Hide();
            }else if (dbaccess.executescalar(findname) == 0 && dbaccess.executescalar(findplade) == 0) // else statement der tjekker om brugeren findes i databasen
            {
                MessageBox.Show("Brugeren findes ikke. Venligst indtast ny bruger eller opret en ny bruger");
            }
    }
        private void formclosed(object sender, FormClosingEventArgs e)

        {
            if (e.CloseReason == CloseReason.UserClosing && boolean == false)
            {
                Application.Exit();
            }
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
