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
        DataSet ds = new DataSet();

        private void cmdinicio_Click(object sender, EventArgs e)
        {
            Winicio winicio = new Winicio();
            winicio.Show();
            this.Hide();
        }

        private void cmdlxml_Click(object sender, EventArgs e)
        {
            openpatchtxt.Filter = "Archivos (*.xml)|*.xml";
            MessageBox.Show("Todos los datos actuales en la tabla seran borrados, presione cancelar en la proxima ventana si desea guardar la tabla actual", "PRECAUCION");


            openpatchtxt.InitialDirectory = Application.StartupPath;
            if (openpatchtxt.ShowDialog() == DialogResult.OK)
            {

                if (dtGCSV.DataSource != null)
                {
                    dtGCSV.DataSource = null;
                    dtGCSV.Columns.Clear();
                    dtGCSV.Rows.Clear();
                }
                else
                {
                    dtGCSV.Columns.Clear();
                    dtGCSV.Rows.Clear();
                }

                try
                {


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

        int i = 1;

        private void cmdAgcolumna_Click(object sender, EventArgs e)
        {
            if (dtGCSV.DataSource != null)
            {
                DataTable dataTable = (DataTable)dtGCSV.DataSource;
                DataColumn newColumn = new DataColumn("Columna " + i, typeof(string));
                dataTable.Columns.Add(newColumn);
            }
            else
            {
                DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
                col1.HeaderText = ("Columna " + i);
                col1.Width = 200;
                col1.ReadOnly = true;
                dtGCSV.Columns.Add(col1);
            }

            i++;
        }

        int r = 0;
        private void cmdAgfila_Click(object sender, EventArgs e)
        {
            if (dtGCSV.ColumnCount != 0)
            {
                if (dtGCSV.DataSource != null)
                {
                    DataTable dataTable = (DataTable)dtGCSV.DataSource;
                    DataRow newRow = dataTable.NewRow();

                    dataTable.Rows.Add(newRow);
                }
                else
                {
                    dtGCSV.Rows.Add();
                }

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
                            else
                            {
                                DataTable dt = new DataTable();

                                // Creador de columnas del DataTable
                                foreach (DataGridViewColumn column in dtGCSV.Columns)
                                {
                                    column.GetType();
                                    Type columnType = column.ValueType ?? typeof(string);
                                    dt.Columns.Add(column.HeaderText, columnType);
                                }

                                // Creador de filas del DataTable
                                foreach (DataGridViewRow row in dtGCSV.Rows)
                                {
                                    if (row.IsNewRow) continue; 
                                    DataRow dataRow = dt.NewRow();
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        dataRow[cell.ColumnIndex] = cell.Value;
                                    }
                                    dt.Rows.Add(dataRow);
                                }
                                file.Close();
                                DataTable Newdata = (DataTable)dt;
                                Newdata.TableName = (savepatchCSV.FileName);
                                Newdata.WriteXml(savepatchCSV.FileName);
                                MessageBox.Show("Datos guardados en " + savepatchCSV.FileName);


                            }

                            file.Close();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmdguardarcambios_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = new StreamWriter(openpatchtxt.FileName, false, Encoding.UTF8))
            {
                DataTable dataTable = (DataTable)dtGCSV.DataSource;

                if (dataTable != null)
                {
                    file.Close(); //cerrado para editar
                    dataTable.WriteXml(openpatchtxt.FileName);
                    MessageBox.Show("Datos guardados en " + openpatchtxt.FileName);
                    file.Close(); //cerrado para evitar errores
                }
                else
                {
                    MessageBox.Show("No se ha creado un archivo para guardar los cambios");
                }

            }
        }
    }
}
