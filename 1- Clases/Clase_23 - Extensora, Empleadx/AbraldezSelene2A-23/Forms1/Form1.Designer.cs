namespace Forms1
{
    partial class Form1
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
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtBSueldo = new System.Windows.Forms.TextBox();
            this.txtBLegajo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbManejador = new System.Windows.Forms.ComboBox();
            this.lblManejador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(15, 36);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(152, 20);
            this.txtBNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(9, 72);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(45, 13);
            this.lblLegajo.TabIndex = 2;
            this.lblLegajo.Text = "Legajo: ";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(9, 124);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(46, 13);
            this.lblSueldo.TabIndex = 3;
            this.lblSueldo.Text = "Sueldo: ";
            // 
            // txtBSueldo
            // 
            this.txtBSueldo.Location = new System.Drawing.Point(15, 140);
            this.txtBSueldo.Name = "txtBSueldo";
            this.txtBSueldo.Size = new System.Drawing.Size(152, 20);
            this.txtBSueldo.TabIndex = 4;
            // 
            // txtBLegajo
            // 
            this.txtBLegajo.Location = new System.Drawing.Point(15, 88);
            this.txtBLegajo.Name = "txtBLegajo";
            this.txtBLegajo.Size = new System.Drawing.Size(152, 20);
            this.txtBLegajo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(37, 239);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbManejador
            // 
            this.cbManejador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManejador.FormattingEnabled = true;
            this.cbManejador.Location = new System.Drawing.Point(16, 198);
            this.cbManejador.Name = "cbManejador";
            this.cbManejador.Size = new System.Drawing.Size(150, 21);
            this.cbManejador.Sorted = true;
            this.cbManejador.TabIndex = 7;
            this.cbManejador.SelectedIndexChanged += new System.EventHandler(this.cbManejador_SelectedIndexChanged);
            // 
            // lblManejador
            // 
            this.lblManejador.AutoSize = true;
            this.lblManejador.Location = new System.Drawing.Point(53, 182);
            this.lblManejador.Name = "lblManejador";
            this.lblManejador.Size = new System.Drawing.Size(57, 13);
            this.lblManejador.TabIndex = 8;
            this.lblManejador.Text = "Manejador";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 274);
            this.Controls.Add(this.lblManejador);
            this.Controls.Add(this.cbManejador);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBLegajo);
            this.Controls.Add(this.txtBSueldo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBNombre);
            this.Name = "Form1";
            this.Text = "Empleadx";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtBSueldo;
        private System.Windows.Forms.TextBox txtBLegajo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbManejador;
        private System.Windows.Forms.Label lblManejador;
    }
}

