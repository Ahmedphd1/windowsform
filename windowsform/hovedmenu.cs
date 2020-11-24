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
    public partial class hovedmenu : Form
    {
        public hovedmenu()
        {
            InitializeComponent();
        }

        private void hovedmenu_km_input_Click(object sender, EventArgs e) // knap for km_input som navigere til et andet form
        {
            var km_input = new km_indput();
            km_input.Location = this.Location;
            km_input.StartPosition = FormStartPosition.Manual;
            km_input.FormClosing += delegate { this.Show(); };
            km_input.Show();
            this.Hide();

        }

        private void hovedmenu_opret_Click(object sender, EventArgs e)// knap der navigere til et andet form
        {
            var opret = new opretbrugerbil();
            opret.Location = this.Location;
            opret.StartPosition = FormStartPosition.Manual;
            opret.FormClosing += delegate { this.Show(); };
            opret.Show();
            this.Hide();
        }

        private void hovedmenu_udtræk_Click(object sender, EventArgs e)// knap der navigere til et andet form
        {
            var udtræk = new udtræk();
            udtræk.Location = this.Location;
            udtræk.StartPosition = FormStartPosition.Manual;
            udtræk.FormClosing += delegate { this.Show(); };
            udtræk.Show();
            this.Hide();
        }

        private void hovedmenu_rette_Click(object sender, EventArgs e)// knap der navigere til et andet form
        {
            var rette = new rette();
            rette.Location = this.Location;
            rette.StartPosition = FormStartPosition.Manual;
            rette.FormClosing += delegate { this.Show(); };
            rette.Show();
            this.Hide();
        }
    }
}
