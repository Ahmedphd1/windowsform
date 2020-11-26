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

    public partial class retteoplysninger : Form
    {
        public string navnefternavn { get; set; }
        public string nummerplade { get; set; }

        public retteoplysninger()
        {
            //vis data på label
            InitializeComponent();
        }

        private void retteoplysninger_retbruger_Click(object sender, EventArgs e)
        {
            // overfører textboksen til en variabel 
            string navn = retteoplysninger_navn.Text;
            string efternavn = retteoplysninger_efternavn.Text;
            string navnefternavn = navn + " " + efternavn;
            string bilnavn = retteoplysninger_bilnavn.Text;
            string nummerplade = retteoplysninger_nummerplade.Text;
            string model = retteoplysninger_model.Text;
            string anmærkning = retteoplysninger_anmærkning.Text;

            if (navn.Length > 1)
            {

                string updatename = "UPDATE testtable SET Name = @navn Where Name = @navnen";

                SqlCommand updatecommand = new SqlCommand(updatecar);

                updatecommand.Parameters.AddWithValue("@navn", nyefternavn);
                updatecommand.Parameters.AddWithValue("@navnen", navnefternavn);

                db.executeQuery(updatecommand);
            }

            if (efternavn.Length > 1)
            {

            }
            if (bilnavn.Length > 1)
            {

            }
            if (nummerplade.Length > 1)
            {

            }
            if (model.Length > 1)
            {

            }
            if (anmærkning.Length > 1)
            {

            }


        }
    }
}
