namespace ElSuperIncreibleSistema
{
    partial class ActualizacionPrecioIndividual
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcostodolar = new System.Windows.Forms.TextBox();
            this.txtcostobolivar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpreciobolivar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpreciodolar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltitulo.Location = new System.Drawing.Point(12, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(410, 25);
            this.lbltitulo.TabIndex = 2;
            this.lbltitulo.Text = "Actualizacion de Precio Individual";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnbuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.ForeColor = System.Drawing.Color.MistyRose;
            this.btnbuscar.Location = new System.Drawing.Point(451, 66);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(134, 51);
            this.btnbuscar.TabIndex = 6;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(206, 79);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(215, 27);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Costo en dolares:";
            // 
            // txtcostodolar
            // 
            this.txtcostodolar.Location = new System.Drawing.Point(174, 185);
            this.txtcostodolar.Name = "txtcostodolar";
            this.txtcostodolar.Size = new System.Drawing.Size(164, 27);
            this.txtcostodolar.TabIndex = 8;
            this.txtcostodolar.TextChanged += new System.EventHandler(this.txtcostodolar_TextChanged);
            // 
            // txtcostobolivar
            // 
            this.txtcostobolivar.Location = new System.Drawing.Point(528, 185);
            this.txtcostobolivar.Name = "txtcostobolivar";
            this.txtcostobolivar.Size = new System.Drawing.Size(164, 27);
            this.txtcostobolivar.TabIndex = 10;
            this.txtcostobolivar.TextChanged += new System.EventHandler(this.txtcostobolivar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Costo en bolivares:";
            // 
            // txtpreciobolivar
            // 
            this.txtpreciobolivar.Location = new System.Drawing.Point(526, 251);
            this.txtpreciobolivar.Name = "txtpreciobolivar";
            this.txtpreciobolivar.Size = new System.Drawing.Size(164, 27);
            this.txtpreciobolivar.TabIndex = 14;
            this.txtpreciobolivar.TextChanged += new System.EventHandler(this.txtpreciobolivar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio en bolivares:";
            // 
            // txtpreciodolar
            // 
            this.txtpreciodolar.Location = new System.Drawing.Point(172, 251);
            this.txtpreciodolar.Name = "txtpreciodolar";
            this.txtpreciodolar.Size = new System.Drawing.Size(164, 27);
            this.txtpreciodolar.TabIndex = 12;
            this.txtpreciodolar.TextChanged += new System.EventHandler(this.txtpreciodolar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio en dolares:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(651, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "Modifique solo los campos que desea actualizar y luego presione el boton \r\nActual" +
    "izar.";
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.Maroon;
            this.btnactualizar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnactualizar.ForeColor = System.Drawing.Color.MistyRose;
            this.btnactualizar.Location = new System.Drawing.Point(556, 311);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(134, 51);
            this.btnactualizar.TabIndex = 16;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Maroon;
            this.btnvolver.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnvolver.ForeColor = System.Drawing.Color.MistyRose;
            this.btnvolver.Location = new System.Drawing.Point(12, 384);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(109, 45);
            this.btnvolver.TabIndex = 17;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // ActualizacionPrecioIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpreciobolivar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpreciodolar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcostobolivar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcostodolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitulo);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ActualizacionPrecioIndividual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizacion de Precio Individual";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizacionPrecioIndividual_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcostodolar;
        private System.Windows.Forms.TextBox txtcostobolivar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpreciobolivar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpreciodolar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnvolver;
    }
}