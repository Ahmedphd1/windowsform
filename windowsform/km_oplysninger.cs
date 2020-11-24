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
using System.Text.RegularExpressions;

namespace windowsform
{
    public partial class km_oplysninger : Form
    {
        bool boolean = false;

        DBAccess dbaccess = new DBAccess();
        DataTable dt = new DataTable();

        // get og set metoder til at hente værdier fra en anden klasse
        public string navnefternavn { get; set; }
        public string nummerplade { get; set; }

        public km_oplysninger()
        {
            InitializeComponent();

            // fylder combobox op med bilnavne på den person lige efter at formen er blevet initialized
            if (navnefternavn.Length > 2)
            {

                string query = "Select Bilnavn from biler where NavnEfternavn = '" + navnefternavn + "'";

                dbaccess.readDatathroughAdapter(query, dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    km_oplysninger_combobox.Items.Add(dt.Rows[i]["Bilnavn"].ToString());
                }
            } else if (nummerplade.Length > 2)
            {
                string query = "Select Bilnavn from biler where Nummerplade = '" + nummerplade + "'";

                dbaccess.readDatathroughAdapter(query, dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    km_oplysninger_combobox.Items.Add(dt.Rows[i]["Bilnavn"].ToString());
                }
            }
        }


        // tilbage knap funktionalitet
        private void km_oplysninger_tilbage_Click(object sender, EventArgs e)
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

        // programmet lukkes når der bliver trykker på x knappen
        private void formclosed(object sender, FormClosingEventArgs e)

        {
            if (e.CloseReason == CloseReason.UserClosing && boolean == false)
            {
                Application.Exit();
            }

        }

        // opdater knap funktionlitet - opdater og viser information
        private void km_oplysninger_enter_Click(object sender, EventArgs e)
        {
            //variabler der kontrollere database kontatker 
            string bilvalgt = km_oplysninger_combobox.SelectedItem.ToString();
            string kmkørt = km_oplysninger_textbox.Text;
            int errorCounter = Regex.Matches(kmkørt, @"[a-zA-Z]").Count;

            // if statement der kontrollere om kontakt er indtastet korrekt 
            if (kmkørt.Equals("") || bilvalgt.Equals(""))
            {
                MessageBox.Show("Indtast venligst oplysninger og prøv igen!");
            }
            else if (errorCounter >= 1)
            {
                MessageBox.Show("KM må ikke indeholde speciale tegn eller bogstaver. Prøv igen!");
            }
            else
            {
                // finder oplysninger i databasen og manipulere værdierne
                DataTable dtfindkm = new DataTable();

                string findkm = "Select Km from biler where bilvalgt = '" + bilvalgt + "'";

                dbaccess.readDatathroughAdapter(findkm, dtfindkm);

                if (Convert.ToInt32(dtfindkm.Rows[0]["Km"]) >= 100000)
                {
                    MessageBox.Show("Bilen skal til service!");
                }

                string totalkmkørt = kmkørt + Convert.ToInt32(dtfindkm.Rows[0]["Km"]);

                DataTable dtnummerplade = new DataTable();

                string findnummerplade = "Select Nummerplade from biler where bilvalgt = '" + bilvalgt + "'";

                dbaccess.readDatathroughAdapter(findnummerplade, dtnummerplade);

                string updatecar = "Update biler SET Km = '" + @totalkmkørt + "' where Nummerplade '" + dtnummerplade.Rows[0]["Nummerplade"].ToString() + "'";

                SqlCommand updatecommand = new SqlCommand(updatecar);

                updatecommand.Parameters.AddWithValue("@Km", @totalkmkørt);

                int updaterow =  dbaccess.executeQuery(updatecommand);

                // opdatere databasen og udskriver oplysningerne på tekst 
                if (updaterow >= 1)
                {
                    MessageBox.Show("Bil opdateret!");

                    DataTable findoplysninger = new DataTable();

                    string findkontakt = "Select * from biler where bilvalgt = '" + bilvalgt + "'";

                    dbaccess.readDatathroughAdapter(findkontakt, findoplysninger);

                    km_oplysninger_richtext.Text = $"Navn: {findoplysninger.Rows[0]["NavnEfternavn"].ToString()} " +
                        $"/n Bilnavn: {findoplysninger.Rows[0]["Bilnavn"].ToString()} " +
                        $"/n Nummerplade: {findoplysninger.Rows[0]["Nummerplade"].ToString()} " +
                        $"/n Model: {findoplysninger.Rows[0]["Model"].ToString()} " +
                        $"/n Km kørt: {totalkmkørt}";
                }
            }

        }
    }
}
