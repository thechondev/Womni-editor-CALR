using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Womnieditor
{
    public partial class Wcsv : Form
    {
        public Wcsv()
        {
            InitializeComponent();
        }
        private Stream myStream;
        int counter = 0;
        string line;
        private void cmdinicio_Click(object sender, EventArgs e)
        {
            Winicio winicio = new Winicio();
            winicio.Show();
            this.Hide();
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
                    openpatchtxt.Filter = "Archivos (*.csv)|*.csv";
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

        private void cmdlCVC_Click(object sender, EventArgs e)
        {
            char delimitador = ',';
            string[] valores;
            string[] Encabezado;

            openpatchtxt.InitialDirectory = Application.StartupPath;
            openpatchtxt.Filter = "Archivos (*.csv)|*.csv";
            if (openpatchtxt.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    if ((myStream = openpatchtxt.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(openpatchtxt.FileName);
                            line = file.ReadLine();
                            Encabezado = line.Split(delimitador);

                            for (int i = 0; i < Encabezado.Length; i++)
                            {
                                DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
                                col1.HeaderText = Encabezado[i] ;
                                col1.Width = 200;
                                col1.ReadOnly = true;
                                dtGCSV.Columns.Add(col1);
                            }

                            if ((myStream = openpatchtxt.OpenFile()) != null)
                            {
                                using (myStream)
                                { 
                                    while ((line = file.ReadLine()) != null)
                                    {
                                        valores = line.Split(delimitador);

                                        dtGCSV.Rows.Add(valores.ToArray());
                                        dtGCSV.BeginEdit(true);
                                        
                                        //txtArchivo.Text = txtArchivo.Text + line;
                                        //counter++;
                                    }

                                }
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

        private void cmdmodcelda_Click(object sender, EventArgs e)
        {
            dtGCSV[(dtGCSV.CurrentCell.ColumnIndex), (dtGCSV.CurrentCell.RowIndex)].Value = txtcelda.Text;
        }

        private void dtGCSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcelda.Text = dtGCSV[(dtGCSV.CurrentCell.ColumnIndex), (dtGCSV.CurrentCell.RowIndex)].Value.ToString();
        }

        private void cmdborcelda_Click(object sender, EventArgs e)
        {
            dtGCSV.Rows.RemoveAt(dtGCSV.CurrentCell.RowIndex);
        }

        private void cmdcreararchivo_Click(object sender, EventArgs e)
        {

            
        }
    }
}
