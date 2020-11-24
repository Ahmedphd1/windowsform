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
            InitializeComponent();
        }
    }
}
