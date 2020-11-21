namespace ElSuperIncreibleSistema
{
    partial class ActualizacionPreciosDolar
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
            this.txttasadolar = new System.Windows.Forms.TextBox();
            this.btnpreciosdolar = new System.Windows.Forms.Button();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnexportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltitulo.Location = new System.Drawing.Point(12, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(490, 25);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Actualizacion de Precios en base al Dolar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tasa del dolar:";
            // 
            // txttasadolar
            // 
            this.txttasadolar.Location = new System.Drawing.Point(150, 74);
            this.txttasadolar.Name = "txttasadolar";
            this.txttasadolar.Size = new System.Drawing.Size(215, 27);
            this.txttasadolar.TabIndex = 1;
            this.txttasadolar.TextChanged += new System.EventHandler(this.txttasadolar_TextChanged);
            // 
            // btnpreciosdolar
            // 
            this.btnpreciosdolar.BackColor = System.Drawing.Color.Maroon;
            this.btnpreciosdolar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnpreciosdolar.ForeColor = System.Drawing.Color.MistyRose;
            this.btnpreciosdolar.Location = new System.Drawing.Point(416, 61);
            this.btnpreciosdolar.Name = "btnpreciosdolar";
            this.btnpreciosdolar.Size = new System.Drawing.Size(134, 51);
            this.btnpreciosdolar.TabIndex = 3;
            this.btnpreciosdolar.Text = "Actualizar";
            this.btnpreciosdolar.UseVisualStyleBackColor = false;
            this.btnpreciosdolar.Click += new System.EventHandler(this.btnpreciosdolar_Click);
            // 
            // dgvproductos
            // 
            this.dgvproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvproductos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvproductos.Location = new System.Drawing.Point(16, 142);
            this.dgvproductos.MultiSelect = false;
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.ReadOnly = true;
            this.dgvproductos.Size = new System.Drawing.Size(676, 220);
            this.dgvproductos.TabIndex = 4;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Maroon;
            this.btnvolver.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnvolver.ForeColor = System.Drawing.Color.MistyRose;
            this.btnvolver.Location = new System.Drawing.Point(12, 384);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(109, 45);
            this.btnvolver.TabIndex = 5;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvoler_Click);
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.Color.Maroon;
            this.btnexportar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnexportar.ForeColor = System.Drawing.Color.MistyRose;
            this.btnexportar.Location = new System.Drawing.Point(558, 378);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(134, 51);
            this.btnexportar.TabIndex = 6;
            this.btnexportar.Text = "Exportar a Excel";
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // ActualizacionPreciosDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.dgvproductos);
            this.Controls.Add(this.btnpreciosdolar);
            this.Controls.Add(this.txttasadolar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitulo);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ActualizacionPreciosDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizacion de Precios en base al Dolar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizacionPreciosDolar_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttasadolar;
        private System.Windows.Forms.Button btnpreciosdolar;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnexportar;
    }
}