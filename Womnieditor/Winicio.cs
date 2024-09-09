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

        private void cmdcsv_Click(object sender, EventArgs e)
        {
           Wcsv wcsv = new Wcsv();
           wcsv.Show();
           this.Hide();
        }

        private void cmdrtf_Click(object sender, EventArgs e)
        {
            Wrtf wrtf = new Wrtf();
            wrtf.Show();
            this.Hide();
        }

        private void cmdxml_Click(object sender, EventArgs e)
        {
            Wxml wxml = new Wxml();
            wxml.Show();
            this.Hide();
        }
    }
}
