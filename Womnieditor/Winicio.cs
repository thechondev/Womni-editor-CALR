using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Womnieditor
{
    public partial class Winicio : Form
    {
        public Winicio()
        {
            InitializeComponent();
        }

        private void cmdtxt_Click(object sender, EventArgs e)
        {
            Wtxt wtxt = new Wtxt();
            wtxt.Show();
            this.Hide();
        }
    }
}
