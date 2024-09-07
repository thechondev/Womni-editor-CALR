namespace Womnieditor
{
    partial class Wtxt
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
            this.cmdinicio = new System.Windows.Forms.Button();
            this.openpatchtxt = new System.Windows.Forms.OpenFileDialog();
            this.cmdlCAlineas = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.cmdborrararchivo = new System.Windows.Forms.Button();
            this.cmdguardarcambios = new System.Windows.Forms.Button();
            this.cmdcreararchivo = new System.Windows.Forms.Button();
            this.saveFileDialogtxt = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // cmdinicio
            // 
            this.cmdinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdinicio.Location = new System.Drawing.Point(644, 381);
            this.cmdinicio.Name = "cmdinicio";
            this.cmdinicio.Size = new System.Drawing.Size(92, 30);
            this.cmdinicio.TabIndex = 0;
            this.cmdinicio.Text = "Inicio";
            this.cmdinicio.UseVisualStyleBackColor = true;
            this.cmdinicio.Click += new System.EventHandler(this.cmdinicio_Click);
            // 
            // openpatchtxt
            // 
            this.openpatchtxt.FileName = "openFileDialog1";
            // 
            // cmdlCAlineas
            // 
            this.cmdlCAlineas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdlCAlineas.Location = new System.Drawing.Point(45, 357);
            this.cmdlCAlineas.Name = "cmdlCAlineas";
            this.cmdlCAlineas.Size = new System.Drawing.Size(92, 79);
            this.cmdlCAlineas.TabIndex = 1;
            this.cmdlCAlineas.Text = "Cargar linea a linea";
            this.cmdlCAlineas.UseVisualStyleBackColor = true;
            this.cmdlCAlineas.Click += new System.EventHandler(this.cmdlCAlineas_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(45, 23);
            this.txtArchivo.Multiline = true;
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(691, 284);
            this.txtArchivo.TabIndex = 2;
            // 
            // cmdborrararchivo
            // 
            this.cmdborrararchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdborrararchivo.Location = new System.Drawing.Point(289, 357);
            this.cmdborrararchivo.Name = "cmdborrararchivo";
            this.cmdborrararchivo.Size = new System.Drawing.Size(92, 79);
            this.cmdborrararchivo.TabIndex = 4;
            this.cmdborrararchivo.Text = "Borrar archivo";
            this.cmdborrararchivo.UseVisualStyleBackColor = true;
            this.cmdborrararchivo.Click += new System.EventHandler(this.cmdborrararchivo_Click);
            // 
            // cmdguardarcambios
            // 
            this.cmdguardarcambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdguardarcambios.Location = new System.Drawing.Point(167, 357);
            this.cmdguardarcambios.Name = "cmdguardarcambios";
            this.cmdguardarcambios.Size = new System.Drawing.Size(92, 79);
            this.cmdguardarcambios.TabIndex = 5;
            this.cmdguardarcambios.Text = "Guardar cambios";
            this.cmdguardarcambios.UseVisualStyleBackColor = true;
            this.cmdguardarcambios.Click += new System.EventHandler(this.cmdguardarcambios_Click);
            // 
            // cmdcreararchivo
            // 
            this.cmdcreararchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcreararchivo.Location = new System.Drawing.Point(411, 357);
            this.cmdcreararchivo.Name = "cmdcreararchivo";
            this.cmdcreararchivo.Size = new System.Drawing.Size(92, 79);
            this.cmdcreararchivo.TabIndex = 6;
            this.cmdcreararchivo.Text = "Crear Archivo";
            this.cmdcreararchivo.UseVisualStyleBackColor = true;
            this.cmdcreararchivo.Click += new System.EventHandler(this.cmdcreararchivo_Click);
            // 
            // Wtxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdcreararchivo);
            this.Controls.Add(this.cmdguardarcambios);
            this.Controls.Add(this.cmdborrararchivo);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.cmdlCAlineas);
            this.Controls.Add(this.cmdinicio);
            this.Name = "Wtxt";
            this.Text = "Wtxt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Wtxt_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdinicio;
        private System.Windows.Forms.OpenFileDialog openpatchtxt;
        private System.Windows.Forms.Button cmdlCAlineas;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button cmdborrararchivo;
        private System.Windows.Forms.Button cmdguardarcambios;
        private System.Windows.Forms.Button cmdcreararchivo;
        private System.Windows.Forms.SaveFileDialog saveFileDialogtxt;
    }
}