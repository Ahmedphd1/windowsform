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
    public partial class opretbruger : Form
    {
        DBAccess dbaccess = new DBAccess();
        bool boolean = false;


        public opretbruger()
        {
            InitializeComponent();
        }

        private void opretbruger_tilbage_Click(object sender, EventArgs e)
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

        // lukker programmet hvis brugeren trykker på x
        private void formclosed(object sender, FormClosingEventArgs e)

        {
            if (e.CloseReason == CloseReason.UserClosing && boolean == false)
            {
                Application.Exit();
            }

        }
        // knappen der opretter en ny bruger i databasen
        private void opretbruger_opret_Click(object sender, EventArgs e)
        {
            // overfører textboksen til en variabel 
            string navn = opretbruger_navn.Text;
            string efternavn = opretbruger_efternavn.Text;
            string navnefternavn = navn + " " + efternavn;
            string bilnavn = opretbruger_bil.Text;
            string nummerplade = opretbruger_nummerplade.Text;
            string model = opretbruger_model.Text;
            string anmærkning = "aktiv";

            SqlCommand findname = new SqlCommand($"SELECT COUNT(*) from kontaktdata where NavnEfternavn like '{navnefternavn}'");

            // if/else statements der bestemmer hvad der skal ske hvis en af følgende er hændende
            if (navn.Equals(""))
            {
                MessageBox.Show("Venligst indtast dit navn");
            }
            else if (efternavn.Equals(""))
            {
                MessageBox.Show("Venligst indtast dit efternavn");
            }
            else if (efternavn.Equals(""))
            {
                MessageBox.Show("Venligst indtast dit efternavn");
            }
            else if (bilnavn.Equals(""))
            {
                MessageBox.Show("Venligst indtast din bilnavn");
            }
            else if (nummerplade.Equals(""))
            {
                MessageBox.Show("Venligst indtast din nummerplade");
            }
            else if (model.Equals(""))
            {
                MessageBox.Show("Venligst indtast modellen på bilen");
            } else if (dbaccess.executescalar(findname) < 1)
                {

                MessageBox.Show("Brugeren findes allerede: Prøv igen");

            } else
            {
                SqlCommand createname = new SqlCommand("insert into kontaktdata(NavnEfternavn, Anmærkning) values(@navnefternavn, @anmærkning)");
                // insert object der aktivere de metoder der tilføjer ny data til sql databasen

                createname.Parameters.AddWithValue("@navnefternavn", navnefternavn);
                createname.Parameters.AddWithValue("@anmærkning", anmærkning);

                int row = dbaccess.executeQuery(createname); // tæller column nummer

                // tjækker hvis column er blevet opretttet
                if (row == 1)
                {

                    SqlCommand createcar = new SqlCommand("insert into biler(NavnEfternavn, Bilnavn, Nummerplade, Model) values(@navnefternavn, bilnavn, nummerplade, model)"); // insert object der aktivere de metoder der tilføjer ny data til sql databasen
                    createname.Parameters.AddWithValue("@navnefternavn", navnefternavn);
                    createname.Parameters.AddWithValue("@bilnavn", bilnavn);
                    createname.Parameters.AddWithValue("@nummerplade", nummerplade);
                    createname.Parameters.AddWithValue("@model", model);

                    MessageBox.Show("Bruger Oprettet");

                } else
                {
                    MessageBox.Show("An error occured. Try again");
                }
            }
        }
    }
}
