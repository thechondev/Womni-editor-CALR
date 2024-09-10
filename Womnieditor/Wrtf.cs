using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Womnieditor
{
    public partial class Wrtf : Form
    {
        private Stream myStream;
        int counter = 0;
        string line;

        public Wrtf()
        {
            InitializeComponent();
        }

        private void cmdCrtf_Click(object sender, EventArgs e)
        {
            openpatchtxt.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            openpatchtxt.Filter = "Archivos (*.rtf)|*.rtf";

            if (openpatchtxt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ruta = openpatchtxt.FileName;
                    if ((myStream = openpatchtxt.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(openpatchtxt.FileName);
                            rtfArchivo.LoadFile(openpatchtxt.FileName, RichTextBoxStreamType.RichText);

                            file.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            }
        }

        private void cmdfont_Click(object sender, EventArgs e)
        {

            FonDrtf.ShowDialog();
            rtfArchivo.SelectionFont = FonDrtf.Font;

        }

        private void cmdcolor_Click(object sender, EventArgs e)
        {
            ColDrtf.ShowDialog();
            rtfArchivo.SelectionColor = ColDrtf.Color;
        }

        private void cmdInimagen_Click(object sender, EventArgs e)
        {
            openpatchpic.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            openpatchpic.Filter = "image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openpatchpic.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(openpatchpic.FileName);
                    Clipboard.SetImage(image);
                    rtfArchivo.Paste();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            }
        }

        private void cmdguardarcambios_Click(object sender, EventArgs e)
        {

            if (openpatchtxt.FileName != "openFileDialog1")
            {
                rtfArchivo.SaveFile(openpatchtxt.FileName, RichTextBoxStreamType.RichText);
                MessageBox.Show("Texto guardado en " + openpatchtxt.FileName);

            }
            else
            {
                cmdcreararchivo.PerformClick();
            }
        }

        private void cmdcreararchivo_Click(object sender, EventArgs e)
        {
            savepatchrtf.Filter = "Rich Text Files|*.rtf|All Files|*.*";
            savepatchrtf.Title = "Save an RTF File";
            savepatchrtf.ShowDialog();
            rtfArchivo.SaveFile(savepatchrtf.FileName, RichTextBoxStreamType.RichText);

        }

        private void cmdborrararchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (openpatchtxt.FileName != "openFileDialog1")
                {
                    File.Delete(openpatchtxt.FileName);
                    MessageBox.Show("Archivo " + openpatchtxt.FileName + " borrado correctamente");
                }
                else
                {
                    openpatchtxt.InitialDirectory = System.Windows.Forms.Application.StartupPath;
                    openpatchtxt.Filter = "Archivos (*.rtf)|*.rtf";
                    if (openpatchtxt.ShowDialog() == DialogResult.OK)
                    {
                        File.Delete(openpatchtxt.FileName);
                        MessageBox.Show("Archivo " + openpatchtxt.FileName + " borrado correctamente");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        private void cmdinicio_Click(object sender, EventArgs e)
        {
            Winicio winicio = new Winicio();
            winicio.Show();
            this.Hide();
        }
    }
}
