namespace WindowsForm_PaletayTempera
{
    partial class frmPaleta
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
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.listBTemperas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMas
            // 
            this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.Location = new System.Drawing.Point(71, 152);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(80, 40);
            this.btnMas.TabIndex = 0;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(172, 152);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(80, 40);
            this.btnMenos.TabIndex = 1;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // listBTemperas
            // 
            this.listBTemperas.FormattingEnabled = true;
            this.listBTemperas.Location = new System.Drawing.Point(12, 12);
            this.listBTemperas.Name = "listBTemperas";
            this.listBTemperas.Size = new System.Drawing.Size(294, 134);
            this.listBTemperas.TabIndex = 2;
            this.listBTemperas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBTemperas_MouseClick);
            this.listBTemperas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBTemperas_MouseDoubleClick);
            // 
            // frmPaleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 201);
            this.Controls.Add(this.listBTemperas);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Name = "frmPaleta";
            this.Text = "Paleta";
            this.Load += new System.EventHandler(this.frmPaleta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.ListBox listBTemperas;
    }
}

