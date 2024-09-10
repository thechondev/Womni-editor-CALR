namespace Womnieditor
{
    partial class Wrtf
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
            this.rtfArchivo = new System.Windows.Forms.RichTextBox();
            this.cmdcreararchivo = new System.Windows.Forms.Button();
            this.cmdguardarcambios = new System.Windows.Forms.Button();
            this.cmdborrararchivo = new System.Windows.Forms.Button();
            this.cmdCrtf = new System.Windows.Forms.Button();
            this.cmdinicio = new System.Windows.Forms.Button();
            this.openpatchtxt = new System.Windows.Forms.OpenFileDialog();
            this.ColDrtf = new System.Windows.Forms.ColorDialog();
            this.FonDrtf = new System.Windows.Forms.FontDialog();
            this.cmdfont = new System.Windows.Forms.Button();
            this.cmdcolor = new System.Windows.Forms.Button();
            this.cmdInimagen = new System.Windows.Forms.Button();
            this.openpatchpic = new System.Windows.Forms.OpenFileDialog();
            this.savepatchrtf = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // rtfArchivo
            // 
            this.rtfArchivo.Location = new System.Drawing.Point(12, 12);
            this.rtfArchivo.Name = "rtfArchivo";
            this.rtfArchivo.Size = new System.Drawing.Size(776, 300);
            this.rtfArchivo.TabIndex = 0;
            this.rtfArchivo.Text = "";
            // 
            // cmdcreararchivo
            // 
            this.cmdcreararchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcreararchivo.Location = new System.Drawing.Point(303, 368);
            this.cmdcreararchivo.Name = "cmdcreararchivo";
            this.cmdcreararchivo.Size = new System.Drawing.Size(79, 69);
            this.cmdcreararchivo.TabIndex = 16;
            this.cmdcreararchivo.Text = "Crear Archivo";
            this.cmdcreararchivo.UseVisualStyleBackColor = true;
            this.cmdcreararchivo.Click += new System.EventHandler(this.cmdcreararchivo_Click);
            // 
            // cmdguardarcambios
            // 
            this.cmdguardarcambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdguardarcambios.Location = new System.Drawing.Point(109, 369);
            this.cmdguardarcambios.Name = "cmdguardarcambios";
            this.cmdguardarcambios.Size = new System.Drawing.Size(79, 69);
            this.cmdguardarcambios.TabIndex = 15;
            this.cmdguardarcambios.Text = "Guardar cambios";
            this.cmdguardarcambios.UseVisualStyleBackColor = true;
            this.cmdguardarcambios.Click += new System.EventHandler(this.cmdguardarcambios_Click);
            // 
            // cmdborrararchivo
            // 
            this.cmdborrararchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdborrararchivo.Location = new System.Drawing.Point(206, 369);
            this.cmdborrararchivo.Name = "cmdborrararchivo";
            this.cmdborrararchivo.Size = new System.Drawing.Size(79, 69);
            this.cmdborrararchivo.TabIndex = 14;
            this.cmdborrararchivo.Text = "Borrar archivo";
            this.cmdborrararchivo.UseVisualStyleBackColor = true;
            this.cmdborrararchivo.Click += new System.EventHandler(this.cmdborrararchivo_Click);
            // 
            // cmdCrtf
            // 
            this.cmdCrtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCrtf.Location = new System.Drawing.Point(12, 369);
            this.cmdCrtf.Name = "cmdCrtf";
            this.cmdCrtf.Size = new System.Drawing.Size(79, 69);
            this.cmdCrtf.TabIndex = 13;
            this.cmdCrtf.Text = "Cargar RTF";
            this.cmdCrtf.UseVisualStyleBackColor = true;
            this.cmdCrtf.Click += new System.EventHandler(this.cmdCrtf_Click);
            // 
            // cmdinicio
            // 
            this.cmdinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdinicio.Location = new System.Drawing.Point(696, 388);
            this.cmdinicio.Name = "cmdinicio";
            this.cmdinicio.Size = new System.Drawing.Size(92, 30);
            this.cmdinicio.TabIndex = 12;
            this.cmdinicio.Text = "Inicio";
            this.cmdinicio.UseVisualStyleBackColor = true;
            this.cmdinicio.Click += new System.EventHandler(this.cmdinicio_Click);
            // 
            // openpatchtxt
            // 
            this.openpatchtxt.FileName = "openFileDialog1";
            // 
            // cmdfont
            // 
            this.cmdfont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdfont.Location = new System.Drawing.Point(416, 368);
            this.cmdfont.Name = "cmdfont";
            this.cmdfont.Size = new System.Drawing.Size(149, 30);
            this.cmdfont.TabIndex = 17;
            this.cmdfont.Text = "cambiar fuente";
            this.cmdfont.UseVisualStyleBackColor = true;
            this.cmdfont.Click += new System.EventHandler(this.cmdfont_Click);
            // 
            // cmdcolor
            // 
            this.cmdcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcolor.Location = new System.Drawing.Point(416, 408);
            this.cmdcolor.Name = "cmdcolor";
            this.cmdcolor.Size = new System.Drawing.Size(149, 30);
            this.cmdcolor.TabIndex = 18;
            this.cmdcolor.Text = "cambiar color";
            this.cmdcolor.UseVisualStyleBackColor = true;
            this.cmdcolor.Click += new System.EventHandler(this.cmdcolor_Click);
            // 
            // cmdInimagen
            // 
            this.cmdInimagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInimagen.Location = new System.Drawing.Point(571, 369);
            this.cmdInimagen.Name = "cmdInimagen";
            this.cmdInimagen.Size = new System.Drawing.Size(79, 69);
            this.cmdInimagen.TabIndex = 19;
            this.cmdInimagen.Text = "Insertar imagen";
            this.cmdInimagen.UseVisualStyleBackColor = true;
            this.cmdInimagen.Click += new System.EventHandler(this.cmdInimagen_Click);
            // 
            // openpatchpic
            // 
            this.openpatchpic.FileName = "openFileDialog1";
            // 
            // Wrtf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdInimagen);
            this.Controls.Add(this.cmdcolor);
            this.Controls.Add(this.cmdfont);
            this.Controls.Add(this.cmdcreararchivo);
            this.Controls.Add(this.cmdguardarcambios);
            this.Controls.Add(this.cmdborrararchivo);
            this.Controls.Add(this.cmdCrtf);
            this.Controls.Add(this.cmdinicio);
            this.Controls.Add(this.rtfArchivo);
            this.Name = "Wrtf";
            this.Text = "Wrtf";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfArchivo;
        private System.Windows.Forms.Button cmdcreararchivo;
        private System.Windows.Forms.Button cmdguardarcambios;
        private System.Windows.Forms.Button cmdborrararchivo;
        private System.Windows.Forms.Button cmdCrtf;
        private System.Windows.Forms.Button cmdinicio;
        private System.Windows.Forms.OpenFileDialog openpatchtxt;
        private System.Windows.Forms.ColorDialog ColDrtf;
        private System.Windows.Forms.FontDialog FonDrtf;
        private System.Windows.Forms.Button cmdfont;
        private System.Windows.Forms.Button cmdcolor;
        private System.Windows.Forms.Button cmdInimagen;
        private System.Windows.Forms.OpenFileDialog openpatchpic;
        private System.Windows.Forms.SaveFileDialog savepatchrtf;
    }
}