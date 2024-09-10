using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Womnieditor
{
    public partial class Wxml : Form
    {
        public Wxml()
        {
            InitializeComponent();
        }

        private void cmdinicio_Click(object sender, EventArgs e)
        {
            Winicio winicio = new Winicio();
            winicio.Show();
            this.Hide();
        }

        private void cmdlxml_Click(object sender, EventArgs e)
        {
            openpatchtxt.Filter = "Archivos (*.xml)|*.xml";

            openpatchtxt.InitialDirectory = Application.StartupPath;
            if (openpatchtxt.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    DataSet ds = new DataSet();
                    ds.ReadXml(openpatchtxt.FileName);
                    dtGCSV.DataSource = ds.Tables[0];
                    dtGCSV.DataSource = dtGCSV.DataSource;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }


            }
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
                    openpatchtxt.Filter = "Archivos (*.xml)|*.xml";
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

        private void dtGCSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGCSV.CurrentCell.Value != null)
            {
                txtcelda.Text = dtGCSV[(dtGCSV.CurrentCell.ColumnIndex), (dtGCSV.CurrentCell.RowIndex)].Value.ToString();
            }

            else
            {
                dtGCSV.CurrentCell.Value = "";
            }

        }

        private void cmdmodcelda_Click(object sender, EventArgs e)
        {
            dtGCSV[(dtGCSV.CurrentCell.ColumnIndex), (dtGCSV.CurrentCell.RowIndex)].Value = txtcelda.Text;
        }

        private void cmdborcelda_Click(object sender, EventArgs e)
        {
            dtGCSV.Rows.RemoveAt(dtGCSV.CurrentCell.RowIndex);
        }

        int i = 0;

        private void cmdAgcolumna_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dtGCSV.DataSource;
            DataColumn newColumn = new DataColumn("Columna " + i, typeof(string));
            dataTable.Columns.Add(newColumn);

            i++;
        }

        int r = 0;
        private void cmdAgfila_Click(object sender, EventArgs e)
        {
            if (dtGCSV.ColumnCount != 0)
            {
                DataTable dataTable = (DataTable)dtGCSV.DataSource;
                DataRow newRow = dataTable.NewRow();
                
                dataTable.Rows.Add(newRow);

            }
            else
            {
                MessageBox.Show("No se pueden añadir filas si no hay columnas");
            }
        }

        private void cmdcreararchivo_Click(object sender, EventArgs e)
        {
            if (dtGCSV.ColumnCount == 0)
            {
                MessageBox.Show("No se pudo crear archivo, porque no hay datos en la tabla");
            }
            else
            {
                try
                {
                    savepatchCSV.InitialDirectory = Application.StartupPath;
                    savepatchCSV.Filter = "Archivos (*.xml)|*.xml";

                    if (savepatchCSV.ShowDialog() == DialogResult.OK)
                    {

                        using (StreamWriter file = new StreamWriter(savepatchCSV.FileName, false, Encoding.UTF8))
                        {
                            DataTable dataTable = (DataTable)dtGCSV.DataSource;

                            if (dataTable != null)
                            {
                                dataTable.WriteXml(savepatchCSV.FileName);
                                MessageBox.Show("Datos guardados en " + savepatchCSV.FileName);
                            }

                            file.Close();

                        }
                    }
                }
                catch
                {

                }
            }
        }


    }
}
