using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.Win32;

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

            MessageBox.Show("Todos los datos actuales en la tabla seran borrados, presione cancelar en la proxima ventana si desea guardar la tabla actual", "PRECAUCION");


            openpatchtxt.InitialDirectory = Application.StartupPath;
            openpatchtxt.Filter = "Archivos (*.csv)|*.csv";
            if (openpatchtxt.ShowDialog() == DialogResult.OK)
            {
                dtGCSV.Columns.Clear();
                dtGCSV.Rows.Clear();

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
                                col1.HeaderText = Encabezado[i];
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
            if (dtGCSV.CurrentCell.Value != null)
            {
                txtcelda.Text = dtGCSV[(dtGCSV.CurrentCell.ColumnIndex), (dtGCSV.CurrentCell.RowIndex)].Value.ToString();
            }

            else
            {
                dtGCSV.CurrentCell.Value = " ";
            }

        }

        private void cmdborcelda_Click(object sender, EventArgs e)
        {
            dtGCSV.Rows.RemoveAt(dtGCSV.CurrentCell.RowIndex);
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
                    savepatchCSV.Filter = "Archivos (*.csv)|*.csv";

                    if (savepatchCSV.ShowDialog() == DialogResult.OK)
                    {

                        using (StreamWriter file = new StreamWriter(savepatchCSV.FileName, false, Encoding.UTF8))
                        {

                            for (int i = 0; i < dtGCSV.Columns.Count; i++)
                            {
                                file.Write(dtGCSV.Columns[i].HeaderText);
                                if (i < dtGCSV.Columns.Count - 1)
                                {
                                    file.Write(",");
                                }
                            }
                            file.WriteLine();

                            for (int i = 0; i < dtGCSV.Rows.Count; i++)
                            {
                                for (int j = 0; j < dtGCSV.Columns.Count; j++)
                                {
                                    file.Write(dtGCSV.Rows[i].Cells[j].Value);
                                    if (j < dtGCSV.Columns.Count - 1)
                                    {
                                        file.Write(",");
                                    }
                                }
                                file.WriteLine();

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

        int i = 0;
        private void cmdAgcolumna_Click(object sender, EventArgs e)
        {


            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = ("Columna " + i);
            col1.Width = 200;
            col1.ReadOnly = true;
            dtGCSV.Columns.Add(col1);

            i++;

        }

        private void cmdAgfila_Click(object sender, EventArgs e)
        {
            if (dtGCSV.ColumnCount != 0)
            {
                dtGCSV.Rows.Insert(dtGCSV.RowCount - 1);
            }
            else
            {
                MessageBox.Show("No se pueden añadir filas si no hay columnas");
            }

        }

        private void cmdguardarcambios_Click(object sender, EventArgs e)
        {

            StringBuilder csvMemoria = new StringBuilder();

            // Añadir encabezados
            for (int i = 0; i < dtGCSV.Columns.Count; i++)
            {
                csvMemoria.Append(dtGCSV.Columns[i].HeaderText);
                if (i < dtGCSV.Columns.Count - 1)
                {
                    csvMemoria.Append(",");
                }
            }
            csvMemoria.AppendLine();

            // Añadir filas
            for (int i = 0; i < dtGCSV.Rows.Count; i++)
            {
                for (int j = 0; j < dtGCSV.Columns.Count; j++)
                { 
                        csvMemoria.Append(dtGCSV.Rows[i].Cells[j].Value);
                    if (j < dtGCSV.Columns.Count - 1)
                    {
                        csvMemoria.Append(",");
                    }
                }
                csvMemoria.AppendLine();
            }

            // Escribir en el archivo
            File.WriteAllText(openpatchtxt.FileName, csvMemoria.ToString(), Encoding.UTF8);

            MessageBox.Show("Cambios aplicados en " + openpatchtxt.FileName);

        }
    }

}    


