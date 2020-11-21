namespace ElSuperIncreibleSistema
{
    partial class Inicio
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnpreciosdolar = new System.Windows.Forms.Button();
            this.btnprecioindividual = new System.Windows.Forms.Button();
            this.btninclusion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltitulo.Location = new System.Drawing.Point(13, 13);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(502, 25);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "El Super Increible Sistema de ZonaFranca";
            // 
            // btnpreciosdolar
            // 
            this.btnpreciosdolar.BackColor = System.Drawing.Color.Maroon;
            this.btnpreciosdolar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpreciosdolar.ForeColor = System.Drawing.Color.MistyRose;
            this.btnpreciosdolar.Location = new System.Drawing.Point(47, 84);
            this.btnpreciosdolar.Name = "btnpreciosdolar";
            this.btnpreciosdolar.Size = new System.Drawing.Size(163, 80);
            this.btnpreciosdolar.TabIndex = 1;
            this.btnpreciosdolar.Text = "Actualizacion de precios en base al dolar";
            this.btnpreciosdolar.UseVisualStyleBackColor = false;
            this.btnpreciosdolar.Click += new System.EventHandler(this.btnpreciosdolar_Click);
            // 
            // btnprecioindividual
            // 
            this.btnprecioindividual.BackColor = System.Drawing.Color.Maroon;
            this.btnprecioindividual.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprecioindividual.ForeColor = System.Drawing.Color.MistyRose;
            this.btnprecioindividual.Location = new System.Drawing.Point(302, 84);
            this.btnprecioindividual.Name = "btnprecioindividual";
            this.btnprecioindividual.Size = new System.Drawing.Size(163, 80);
            this.btnprecioindividual.TabIndex = 2;
            this.btnprecioindividual.Text = "Actualizacion de precio individual";
            this.btnprecioindividual.UseVisualStyleBackColor = false;
            this.btnprecioindividual.Click += new System.EventHandler(this.btnprecioindividual_Click);
            // 
            // btninclusion
            // 
            this.btninclusion.BackColor = System.Drawing.Color.Maroon;
            this.btninclusion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninclusion.ForeColor = System.Drawing.Color.MistyRose;
            this.btninclusion.Location = new System.Drawing.Point(167, 197);
            this.btninclusion.Name = "btninclusion";
            this.btninclusion.Size = new System.Drawing.Size(163, 80);
            this.btninclusion.TabIndex = 3;
            this.btninclusion.Text = "Inclusion de nuevos productos";
            this.btninclusion.UseVisualStyleBackColor = false;
            this.btninclusion.Click += new System.EventHandler(this.btninclusion_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(524, 321);
            this.Controls.Add(this.btninclusion);
            this.Controls.Add(this.btnprecioindividual);
            this.Controls.Add(this.btnpreciosdolar);
            this.Controls.Add(this.lbltitulo);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "El Super Increible Sistema de ZonaFranca";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inicio_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnpreciosdolar;
        private System.Windows.Forms.Button btnprecioindividual;
        private System.Windows.Forms.Button btninclusion;
    }
}

