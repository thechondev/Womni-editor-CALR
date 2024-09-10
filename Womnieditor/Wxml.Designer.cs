namespace Womnieditor
{
    partial class Wxml
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdborcelda = new System.Windows.Forms.Button();
            this.cmdmodcelda = new System.Windows.Forms.Button();
            this.cmdcreararchivo = new System.Windows.Forms.Button();
            this.cmdguardarcambios = new System.Windows.Forms.Button();
            this.cmdborrararchivo = new System.Windows.Forms.Button();
            this.cmdlxml = new System.Windows.Forms.Button();
            this.cmdinicio = new System.Windows.Forms.Button();
            this.dtGCSV = new System.Windows.Forms.DataGridView();
            this.savepatchCSV = new System.Windows.Forms.SaveFileDialog();
            this.openpatchtxt = new System.Windows.Forms.OpenFileDialog();
            this.cmdAgfila = new System.Windows.Forms.Button();
            this.cmdAgcolumna = new System.Windows.Forms.Button();
            this.txtcelda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdborcelda
            // 
            this.cmdborcelda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdborcelda.Location = new System.Drawing.Point(596, 396);
            this.cmdborcelda.Name = "cmdborcelda";
            this.cmdborcelda.Size = new System.Drawing.Size(169, 32);
            this.cmdborcelda.TabIndex = 23;
            this.cmdborcelda.Text = "borrar fila";
            this.cmdborcelda.UseVisualStyleBackColor = true;
            this.cmdborcelda.Click += new System.EventHandler(this.cmdborcelda_Click);
            // 
            // cmdmodcelda
            // 
            this.cmdmodcelda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdmodcelda.Location = new System.Drawing.Point(596, 358);
            this.cmdmodcelda.Name = "cmdmodcelda";
            this.cmdmodcelda.Size = new System.Drawing.Size(169, 32);
            this.cmdmodcelda.TabIndex = 21;
            this.cmdmodcelda.Text = "modfificar celda";
            this.cmdmodcelda.UseVisualStyleBackColor = true;
            this.cmdmodcelda.Click += new System.EventHandler(this.cmdmodcelda_Click);
            // 
            // cmdcreararchivo
            // 
            this.cmdcreararchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcreararchivo.Location = new System.Drawing.Point(303, 358);
            this.cmdcreararchivo.Name = "cmdcreararchivo";
            this.cmdcreararchivo.Size = new System.Drawing.Size(79, 69);
            this.cmdcreararchivo.TabIndex = 20;
            this.cmdcreararchivo.Text = "Crear Archivo";
            this.cmdcreararchivo.UseVisualStyleBackColor = true;
            this.cmdcreararchivo.Click += new System.EventHandler(this.cmdcreararchivo_Click);
            // 
            // cmdguardarcambios
            // 
            this.cmdguardarcambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdguardarcambios.Location = new System.Drawing.Point(109, 359);
            this.cmdguardarcambios.Name = "cmdguardarcambios";
            this.cmdguardarcambios.Size = new System.Drawing.Size(79, 69);
            this.cmdguardarcambios.TabIndex = 19;
            this.cmdguardarcambios.Text = "Guardar cambios";
            this.cmdguardarcambios.UseVisualStyleBackColor = true;
            // 
            // cmdborrararchivo
            // 
            this.cmdborrararchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdborrararchivo.Location = new System.Drawing.Point(206, 359);
            this.cmdborrararchivo.Name = "cmdborrararchivo";
            this.cmdborrararchivo.Size = new System.Drawing.Size(79, 69);
            this.cmdborrararchivo.TabIndex = 18;
            this.cmdborrararchivo.Text = "Borrar archivo";
            this.cmdborrararchivo.UseVisualStyleBackColor = true;
            this.cmdborrararchivo.Click += new System.EventHandler(this.cmdborrararchivo_Click);
            // 
            // cmdlxml
            // 
            this.cmdlxml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdlxml.Location = new System.Drawing.Point(12, 359);
            this.cmdlxml.Name = "cmdlxml";
            this.cmdlxml.Size = new System.Drawing.Size(79, 69);
            this.cmdlxml.TabIndex = 17;
            this.cmdlxml.Text = "Cargar xml";
            this.cmdlxml.UseVisualStyleBackColor = true;
            this.cmdlxml.Click += new System.EventHandler(this.cmdlxml_Click);
            // 
            // cmdinicio
            // 
            this.cmdinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdinicio.Location = new System.Drawing.Point(810, 395);
            this.cmdinicio.Name = "cmdinicio";
            this.cmdinicio.Size = new System.Drawing.Size(92, 30);
            this.cmdinicio.TabIndex = 16;
            this.cmdinicio.Text = "Inicio";
            this.cmdinicio.UseVisualStyleBackColor = true;
            this.cmdinicio.Click += new System.EventHandler(this.cmdinicio_Click);
            // 
            // dtGCSV
            // 
            this.dtGCSV.AllowDrop = true;
            this.dtGCSV.AllowUserToOrderColumns = true;
            this.dtGCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGCSV.Location = new System.Drawing.Point(12, 12);
            this.dtGCSV.Name = "dtGCSV";
            this.dtGCSV.Size = new System.Drawing.Size(890, 319);
            this.dtGCSV.TabIndex = 15;
            this.dtGCSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGCSV_CellClick);
            // 
            // openpatchtxt
            // 
            this.openpatchtxt.FileName = "openFileDialog1";
            // 
            // cmdAgfila
            // 
            this.cmdAgfila.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgfila.Location = new System.Drawing.Point(402, 390);
            this.cmdAgfila.Name = "cmdAgfila";
            this.cmdAgfila.Size = new System.Drawing.Size(84, 42);
            this.cmdAgfila.TabIndex = 26;
            this.cmdAgfila.Text = "Crear nueva fila";
            this.cmdAgfila.UseVisualStyleBackColor = true;
            this.cmdAgfila.Click += new System.EventHandler(this.cmdAgfila_Click);
            // 
            // cmdAgcolumna
            // 
            this.cmdAgcolumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgcolumna.Location = new System.Drawing.Point(492, 390);
            this.cmdAgcolumna.Name = "cmdAgcolumna";
            this.cmdAgcolumna.Size = new System.Drawing.Size(79, 42);
            this.cmdAgcolumna.TabIndex = 25;
            this.cmdAgcolumna.Text = "Crear nueva columna";
            this.cmdAgcolumna.UseVisualStyleBackColor = true;
            this.cmdAgcolumna.Click += new System.EventHandler(this.cmdAgcolumna_Click);
            // 
            // txtcelda
            // 
            this.txtcelda.Location = new System.Drawing.Point(402, 358);
            this.txtcelda.Name = "txtcelda";
            this.txtcelda.Size = new System.Drawing.Size(169, 20);
            this.txtcelda.TabIndex = 24;
            // 
            // Wxml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.cmdAgfila);
            this.Controls.Add(this.cmdAgcolumna);
            this.Controls.Add(this.txtcelda);
            this.Controls.Add(this.cmdborcelda);
            this.Controls.Add(this.cmdmodcelda);
            this.Controls.Add(this.cmdcreararchivo);
            this.Controls.Add(this.cmdguardarcambios);
            this.Controls.Add(this.cmdborrararchivo);
            this.Controls.Add(this.cmdlxml);
            this.Controls.Add(this.cmdinicio);
            this.Controls.Add(this.dtGCSV);
            this.Name = "Wxml";
            this.Text = "Wxlx";
            ((System.ComponentModel.ISupportInitialize)(this.dtGCSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdborcelda;
        private System.Windows.Forms.Button cmdmodcelda;
        private System.Windows.Forms.Button cmdcreararchivo;
        private System.Windows.Forms.Button cmdguardarcambios;
        private System.Windows.Forms.Button cmdborrararchivo;
        private System.Windows.Forms.Button cmdlxml;
        private System.Windows.Forms.Button cmdinicio;
        private System.Windows.Forms.DataGridView dtGCSV;
        private System.Windows.Forms.SaveFileDialog savepatchCSV;
        private System.Windows.Forms.OpenFileDialog openpatchtxt;
        private System.Windows.Forms.Button cmdAgfila;
        private System.Windows.Forms.Button cmdAgcolumna;
        private System.Windows.Forms.TextBox txtcelda;
    }
}