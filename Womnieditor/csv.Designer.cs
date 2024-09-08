namespace Womnieditor
{
    partial class Wcsv
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
            this.dtGCSV = new System.Windows.Forms.DataGridView();
            this.cmdcreararchivo = new System.Windows.Forms.Button();
            this.cmdguardarcambios = new System.Windows.Forms.Button();
            this.cmdborrararchivo = new System.Windows.Forms.Button();
            this.cmdlCVC = new System.Windows.Forms.Button();
            this.cmdinicio = new System.Windows.Forms.Button();
            this.openpatchtxt = new System.Windows.Forms.OpenFileDialog();
            this.cmdmodcelda = new System.Windows.Forms.Button();
            this.txtcelda = new System.Windows.Forms.TextBox();
            this.cmdborcelda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGCSV
            // 
            this.dtGCSV.AllowDrop = true;
            this.dtGCSV.AllowUserToOrderColumns = true;
            this.dtGCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGCSV.Location = new System.Drawing.Point(12, 12);
            this.dtGCSV.Name = "dtGCSV";
            this.dtGCSV.Size = new System.Drawing.Size(890, 319);
            this.dtGCSV.TabIndex = 0;
            this.dtGCSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGCSV_CellClick);
            // 
            // cmdcreararchivo
            // 
            this.cmdcreararchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcreararchivo.Location = new System.Drawing.Point(303, 358);
            this.cmdcreararchivo.Name = "cmdcreararchivo";
            this.cmdcreararchivo.Size = new System.Drawing.Size(79, 69);
            this.cmdcreararchivo.TabIndex = 11;
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
            this.cmdguardarcambios.TabIndex = 10;
            this.cmdguardarcambios.Text = "Guardar cambios";
            this.cmdguardarcambios.UseVisualStyleBackColor = true;
            // 
            // cmdborrararchivo
            // 
            this.cmdborrararchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdborrararchivo.Location = new System.Drawing.Point(206, 359);
            this.cmdborrararchivo.Name = "cmdborrararchivo";
            this.cmdborrararchivo.Size = new System.Drawing.Size(79, 69);
            this.cmdborrararchivo.TabIndex = 9;
            this.cmdborrararchivo.Text = "Borrar archivo";
            this.cmdborrararchivo.UseVisualStyleBackColor = true;
            this.cmdborrararchivo.Click += new System.EventHandler(this.cmdborrararchivo_Click);
            // 
            // cmdlCVC
            // 
            this.cmdlCVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdlCVC.Location = new System.Drawing.Point(12, 359);
            this.cmdlCVC.Name = "cmdlCVC";
            this.cmdlCVC.Size = new System.Drawing.Size(79, 69);
            this.cmdlCVC.TabIndex = 8;
            this.cmdlCVC.Text = "Cargar CVC";
            this.cmdlCVC.UseVisualStyleBackColor = true;
            this.cmdlCVC.Click += new System.EventHandler(this.cmdlCVC_Click);
            // 
            // cmdinicio
            // 
            this.cmdinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdinicio.Location = new System.Drawing.Point(810, 395);
            this.cmdinicio.Name = "cmdinicio";
            this.cmdinicio.Size = new System.Drawing.Size(92, 30);
            this.cmdinicio.TabIndex = 7;
            this.cmdinicio.Text = "Inicio";
            this.cmdinicio.UseVisualStyleBackColor = true;
            this.cmdinicio.Click += new System.EventHandler(this.cmdinicio_Click);
            // 
            // openpatchtxt
            // 
            this.openpatchtxt.FileName = "openFileDialog1";
            // 
            // cmdmodcelda
            // 
            this.cmdmodcelda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdmodcelda.Location = new System.Drawing.Point(596, 358);
            this.cmdmodcelda.Name = "cmdmodcelda";
            this.cmdmodcelda.Size = new System.Drawing.Size(169, 32);
            this.cmdmodcelda.TabIndex = 12;
            this.cmdmodcelda.Text = "modfificar celda";
            this.cmdmodcelda.UseVisualStyleBackColor = true;
            this.cmdmodcelda.Click += new System.EventHandler(this.cmdmodcelda_Click);
            // 
            // txtcelda
            // 
            this.txtcelda.Location = new System.Drawing.Point(408, 384);
            this.txtcelda.Name = "txtcelda";
            this.txtcelda.Size = new System.Drawing.Size(169, 20);
            this.txtcelda.TabIndex = 13;
            // 
            // cmdborcelda
            // 
            this.cmdborcelda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdborcelda.Location = new System.Drawing.Point(596, 396);
            this.cmdborcelda.Name = "cmdborcelda";
            this.cmdborcelda.Size = new System.Drawing.Size(169, 32);
            this.cmdborcelda.TabIndex = 14;
            this.cmdborcelda.Text = "borrar fila";
            this.cmdborcelda.UseVisualStyleBackColor = true;
            this.cmdborcelda.Click += new System.EventHandler(this.cmdborcelda_Click);
            // 
            // Wcsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.cmdborcelda);
            this.Controls.Add(this.cmdmodcelda);
            this.Controls.Add(this.txtcelda);
            this.Controls.Add(this.cmdcreararchivo);
            this.Controls.Add(this.cmdguardarcambios);
            this.Controls.Add(this.cmdborrararchivo);
            this.Controls.Add(this.cmdlCVC);
            this.Controls.Add(this.cmdinicio);
            this.Controls.Add(this.dtGCSV);
            this.Name = "Wcsv";
            this.Text = "csv";
            ((System.ComponentModel.ISupportInitialize)(this.dtGCSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGCSV;
        private System.Windows.Forms.Button cmdcreararchivo;
        private System.Windows.Forms.Button cmdguardarcambios;
        private System.Windows.Forms.Button cmdborrararchivo;
        private System.Windows.Forms.Button cmdlCVC;
        private System.Windows.Forms.Button cmdinicio;
        private System.Windows.Forms.OpenFileDialog openpatchtxt;
        private System.Windows.Forms.Button cmdmodcelda;
        private System.Windows.Forms.TextBox txtcelda;
        private System.Windows.Forms.Button cmdborcelda;
    }
}