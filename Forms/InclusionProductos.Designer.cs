namespace ElSuperIncreibleSistema
{
    partial class InclusionProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lbladvertencia = new System.Windows.Forms.Label();
            this.txtpreciobolivar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpreciodolar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcostobolivar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcostodolar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnincluir = new System.Windows.Forms.Button();
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
            this.lbltitulo.Size = new System.Drawing.Size(374, 25);
            this.lbltitulo.TabIndex = 3;
            this.lbltitulo.Text = "Inclusion de Nuevos Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Complete los campos solicitados para la inclusion de un nuevo producto.\r\nTenga en" +
    " cuenta que el nombre es unico para cada producto.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del producto:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(206, 100);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(249, 27);
            this.txtnombre.TabIndex = 6;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // lbladvertencia
            // 
            this.lbladvertencia.AutoSize = true;
            this.lbladvertencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lbladvertencia.Location = new System.Drawing.Point(38, 140);
            this.lbladvertencia.Name = "lbladvertencia";
            this.lbladvertencia.Size = new System.Drawing.Size(0, 18);
            this.lbladvertencia.TabIndex = 7;
            // 
            // txtpreciobolivar
            // 
            this.txtpreciobolivar.Location = new System.Drawing.Point(528, 270);
            this.txtpreciobolivar.Name = "txtpreciobolivar";
            this.txtpreciobolivar.Size = new System.Drawing.Size(164, 27);
            this.txtpreciobolivar.TabIndex = 22;
            this.txtpreciobolivar.TextChanged += new System.EventHandler(this.txtpreciobolivar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Precio en bolivares:";
            // 
            // txtpreciodolar
            // 
            this.txtpreciodolar.Location = new System.Drawing.Point(174, 270);
            this.txtpreciodolar.Name = "txtpreciodolar";
            this.txtpreciodolar.Size = new System.Drawing.Size(164, 27);
            this.txtpreciodolar.TabIndex = 20;
            this.txtpreciodolar.TextChanged += new System.EventHandler(this.txtpreciodolar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Precio en dolares:";
            // 
            // txtcostobolivar
            // 
            this.txtcostobolivar.Location = new System.Drawing.Point(528, 194);
            this.txtcostobolivar.Name = "txtcostobolivar";
            this.txtcostobolivar.Size = new System.Drawing.Size(164, 27);
            this.txtcostobolivar.TabIndex = 18;
            this.txtcostobolivar.TextChanged += new System.EventHandler(this.txtcostobolivar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Costo en bolivares:";
            // 
            // txtcostodolar
            // 
            this.txtcostodolar.Location = new System.Drawing.Point(174, 194);
            this.txtcostodolar.Name = "txtcostodolar";
            this.txtcostodolar.Size = new System.Drawing.Size(164, 27);
            this.txtcostodolar.TabIndex = 16;
            this.txtcostodolar.TextChanged += new System.EventHandler(this.txtcostodolar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Costo en dolares:";
            // 
            // btnincluir
            // 
            this.btnincluir.BackColor = System.Drawing.Color.Maroon;
            this.btnincluir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnincluir.ForeColor = System.Drawing.Color.MistyRose;
            this.btnincluir.Location = new System.Drawing.Point(558, 336);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(134, 51);
            this.btnincluir.TabIndex = 23;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = false;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Maroon;
            this.btnvolver.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnvolver.ForeColor = System.Drawing.Color.MistyRose;
            this.btnvolver.Location = new System.Drawing.Point(12, 384);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(109, 45);
            this.btnvolver.TabIndex = 24;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // InclusionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.txtpreciobolivar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpreciodolar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcostobolivar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcostodolar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbladvertencia);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitulo);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "InclusionProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inclusion de Nuevos Productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InclusionProductos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lbladvertencia;
        private System.Windows.Forms.TextBox txtpreciobolivar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpreciodolar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcostobolivar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcostodolar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btnvolver;
    }
}