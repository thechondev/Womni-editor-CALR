namespace Womnieditor
{
    partial class Winicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdtxt = new System.Windows.Forms.Button();
            this.cmdxml = new System.Windows.Forms.Button();
            this.cmdrtf = new System.Windows.Forms.Button();
            this.cmdcsv = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdtxt
            // 
            this.cmdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdtxt.Location = new System.Drawing.Point(43, 99);
            this.cmdtxt.Name = "cmdtxt";
            this.cmdtxt.Size = new System.Drawing.Size(109, 48);
            this.cmdtxt.TabIndex = 0;
            this.cmdtxt.Text = "txt";
            this.cmdtxt.UseVisualStyleBackColor = true;
            this.cmdtxt.Click += new System.EventHandler(this.cmdtxt_Click);
            // 
            // cmdxml
            // 
            this.cmdxml.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdxml.Location = new System.Drawing.Point(43, 277);
            this.cmdxml.Name = "cmdxml";
            this.cmdxml.Size = new System.Drawing.Size(109, 48);
            this.cmdxml.TabIndex = 1;
            this.cmdxml.Text = "xml";
            this.cmdxml.UseVisualStyleBackColor = true;
            this.cmdxml.Click += new System.EventHandler(this.cmdxml_Click);
            // 
            // cmdrtf
            // 
            this.cmdrtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdrtf.Location = new System.Drawing.Point(452, 277);
            this.cmdrtf.Name = "cmdrtf";
            this.cmdrtf.Size = new System.Drawing.Size(109, 48);
            this.cmdrtf.TabIndex = 3;
            this.cmdrtf.Text = "rtf";
            this.cmdrtf.UseVisualStyleBackColor = true;
            this.cmdrtf.Click += new System.EventHandler(this.cmdrtf_Click);
            // 
            // cmdcsv
            // 
            this.cmdcsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcsv.Location = new System.Drawing.Point(452, 99);
            this.cmdcsv.Name = "cmdcsv";
            this.cmdcsv.Size = new System.Drawing.Size(109, 48);
            this.cmdcsv.TabIndex = 2;
            this.cmdcsv.Text = "csv";
            this.cmdcsv.UseVisualStyleBackColor = true;
            this.cmdcsv.Click += new System.EventHandler(this.cmdcsv_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(149, 197);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(301, 24);
            this.lblInicio.TabIndex = 4;
            this.lblInicio.Text = "Seleccione uno de los editores";
            // 
            // Winicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.cmdrtf);
            this.Controls.Add(this.cmdcsv);
            this.Controls.Add(this.cmdxml);
            this.Controls.Add(this.cmdtxt);
            this.Name = "Winicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdtxt;
        private System.Windows.Forms.Button cmdxml;
        private System.Windows.Forms.Button cmdrtf;
        private System.Windows.Forms.Button cmdcsv;
        private System.Windows.Forms.Label lblInicio;
    }
}

