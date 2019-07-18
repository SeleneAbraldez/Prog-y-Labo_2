namespace Ejercicio_23
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPesos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEuroEuro = new System.Windows.Forms.TextBox();
            this.txtDolarEuro = new System.Windows.Forms.TextBox();
            this.txtEuroDolar = new System.Windows.Forms.TextBox();
            this.txtEuroPesos = new System.Windows.Forms.TextBox();
            this.txtDolarDolar = new System.Windows.Forms.TextBox();
            this.txtPesosEuro = new System.Windows.Forms.TextBox();
            this.txtPesosDolar = new System.Windows.Forms.TextBox();
            this.txtPesosPesos = new System.Windows.Forms.TextBox();
            this.txtDolarPesos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dólar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pesos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Euro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dólar";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(103, 42);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuro.TabIndex = 6;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(103, 74);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolar.TabIndex = 7;
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(103, 105);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesos.TabIndex = 8;
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(219, 40);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConvertEuro.TabIndex = 9;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(219, 72);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDolar.TabIndex = 10;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConvertPesos
            // 
            this.btnConvertPesos.Location = new System.Drawing.Point(219, 103);
            this.btnConvertPesos.Name = "btnConvertPesos";
            this.btnConvertPesos.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPesos.TabIndex = 11;
            this.btnConvertPesos.Text = "->";
            this.btnConvertPesos.UseVisualStyleBackColor = true;
            this.btnConvertPesos.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pesos";
            // 
            // txtEuroEuro
            // 
            this.txtEuroEuro.Enabled = false;
            this.txtEuroEuro.Location = new System.Drawing.Point(309, 42);
            this.txtEuroEuro.Name = "txtEuroEuro";
            this.txtEuroEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuroEuro.TabIndex = 13;
            // 
            // txtDolarEuro
            // 
            this.txtDolarEuro.Enabled = false;
            this.txtDolarEuro.Location = new System.Drawing.Point(309, 74);
            this.txtDolarEuro.Name = "txtDolarEuro";
            this.txtDolarEuro.Size = new System.Drawing.Size(100, 20);
            this.txtDolarEuro.TabIndex = 14;
            // 
            // txtEuroDolar
            // 
            this.txtEuroDolar.Enabled = false;
            this.txtEuroDolar.Location = new System.Drawing.Point(424, 42);
            this.txtEuroDolar.Name = "txtEuroDolar";
            this.txtEuroDolar.Size = new System.Drawing.Size(100, 20);
            this.txtEuroDolar.TabIndex = 16;
            // 
            // txtEuroPesos
            // 
            this.txtEuroPesos.Enabled = false;
            this.txtEuroPesos.Location = new System.Drawing.Point(542, 42);
            this.txtEuroPesos.Name = "txtEuroPesos";
            this.txtEuroPesos.Size = new System.Drawing.Size(100, 20);
            this.txtEuroPesos.TabIndex = 17;
            // 
            // txtDolarDolar
            // 
            this.txtDolarDolar.Enabled = false;
            this.txtDolarDolar.Location = new System.Drawing.Point(424, 74);
            this.txtDolarDolar.Name = "txtDolarDolar";
            this.txtDolarDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolarDolar.TabIndex = 18;
            // 
            // txtPesosEuro
            // 
            this.txtPesosEuro.Enabled = false;
            this.txtPesosEuro.Location = new System.Drawing.Point(309, 105);
            this.txtPesosEuro.Name = "txtPesosEuro";
            this.txtPesosEuro.Size = new System.Drawing.Size(100, 20);
            this.txtPesosEuro.TabIndex = 15;
            // 
            // txtPesosDolar
            // 
            this.txtPesosDolar.Enabled = false;
            this.txtPesosDolar.Location = new System.Drawing.Point(424, 105);
            this.txtPesosDolar.Name = "txtPesosDolar";
            this.txtPesosDolar.Size = new System.Drawing.Size(100, 20);
            this.txtPesosDolar.TabIndex = 19;
            // 
            // txtPesosPesos
            // 
            this.txtPesosPesos.Enabled = false;
            this.txtPesosPesos.Location = new System.Drawing.Point(542, 105);
            this.txtPesosPesos.Name = "txtPesosPesos";
            this.txtPesosPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesosPesos.TabIndex = 20;
            // 
            // txtDolarPesos
            // 
            this.txtDolarPesos.Enabled = false;
            this.txtDolarPesos.Location = new System.Drawing.Point(542, 74);
            this.txtDolarPesos.Name = "txtDolarPesos";
            this.txtDolarPesos.Size = new System.Drawing.Size(100, 20);
            this.txtDolarPesos.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 152);
            this.Controls.Add(this.txtDolarPesos);
            this.Controls.Add(this.txtPesosPesos);
            this.Controls.Add(this.txtPesosDolar);
            this.Controls.Add(this.txtDolarDolar);
            this.Controls.Add(this.txtEuroPesos);
            this.Controls.Add(this.txtEuroDolar);
            this.Controls.Add(this.txtPesosEuro);
            this.Controls.Add(this.txtDolarEuro);
            this.Controls.Add(this.txtEuroEuro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnConvertPesos);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPesos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEuroEuro;
        private System.Windows.Forms.TextBox txtDolarEuro;
        private System.Windows.Forms.TextBox txtEuroDolar;
        private System.Windows.Forms.TextBox txtEuroPesos;
        private System.Windows.Forms.TextBox txtDolarDolar;
        private System.Windows.Forms.TextBox txtPesosEuro;
        private System.Windows.Forms.TextBox txtPesosDolar;
        private System.Windows.Forms.TextBox txtPesosPesos;
        private System.Windows.Forms.TextBox txtDolarPesos;
    }
}

