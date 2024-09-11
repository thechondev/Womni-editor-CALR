using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Womnieditor
{
    public partial class Wtxt : Form
    {
        public Wtxt()
        {
            InitializeComponent();

        }

        private Stream myStream;
        int counter = 0;
        string line;

        private void Wtxt_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void cmdinicio_Click(object sender, EventArgs e)
        {
            Winicio winicio = new Winicio();
            winicio.Show();
            this.Hide();
        }

        private void cmdlCAlineas_Click(object sender, EventArgs e)
        {
            
            openpatchtxt.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            openpatchtxt.Filter = "Archivos (*.txt)|*.txt";
            MessageBox.Show("Todos el texto actual sera borrado, presione cancelar en la proxima ventana si desea guardar la tabla actual", "PRECAUCION");

            if (openpatchtxt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtArchivo.Clear();

                    string ruta = openpatchtxt.FileName;
                    if ((myStream = openpatchtxt.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(openpatchtxt.FileName);
                            while ((line = file.ReadLine()) != null)
                            {
                                txtArchivo.Text = txtArchivo.Text + line;
                                counter++;
                            }

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

        private void cmdguardarcambios_Click(object sender, EventArgs e)
        {
            string texto = txtArchivo.Text;
            

            File.WriteAllText(openpatchtxt.FileName, texto);
            MessageBox.Show("Texto guardado en "+openpatchtxt.FileName );
        }

        private void cmdcreararchivo_Click(object sender, EventArgs e)
        {
            savepatchtxt.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            savepatchtxt.FileName = "texto 1";
            savepatchtxt.ShowDialog();
            using (StreamWriter filewrite = new StreamWriter(savepatchtxt.FileName))
            {
                filewrite.Write(txtArchivo.Text);
            }
        }

        private void cmdborrararchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if(openpatchtxt.FileName != "openFileDialog1")
                {
                    File.Delete(openpatchtxt.FileName);
                    MessageBox.Show("Archivo "+openpatchtxt.FileName+" borrado correctamente" );
                }
                else
                {
                    openpatchtxt.InitialDirectory = System.Windows.Forms.Application.StartupPath;
                    openpatchtxt.Filter = "Archivos (*.txt)|*.txt";
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
    }
}
