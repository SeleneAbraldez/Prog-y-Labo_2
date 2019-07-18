namespace FrmTest
{
    partial class FrmTest2
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
            this.btnBoton1 = new System.Windows.Forms.Button();
            this.btnBoton2 = new System.Windows.Forms.Button();
            this.btnBoton3 = new System.Windows.Forms.Button();
            this.btnBoton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoton1
            // 
            this.btnBoton1.Location = new System.Drawing.Point(33, 12);
            this.btnBoton1.Name = "btnBoton1";
            this.btnBoton1.Size = new System.Drawing.Size(118, 54);
            this.btnBoton1.TabIndex = 0;
            this.btnBoton1.Text = "button1";
            this.btnBoton1.UseVisualStyleBackColor = true;
            this.btnBoton1.Click += new System.EventHandler(this.BtnBoton1_Click);
            // 
            // btnBoton2
            // 
            this.btnBoton2.Location = new System.Drawing.Point(33, 72);
            this.btnBoton2.Name = "btnBoton2";
            this.btnBoton2.Size = new System.Drawing.Size(118, 54);
            this.btnBoton2.TabIndex = 1;
            this.btnBoton2.Text = "button2";
            this.btnBoton2.UseVisualStyleBackColor = true;
            // 
            // btnBoton3
            // 
            this.btnBoton3.Location = new System.Drawing.Point(33, 132);
            this.btnBoton3.Name = "btnBoton3";
            this.btnBoton3.Size = new System.Drawing.Size(118, 54);
            this.btnBoton3.TabIndex = 2;
            this.btnBoton3.Text = "button3";
            this.btnBoton3.UseVisualStyleBackColor = true;
            // 
            // btnBoton4
            // 
            this.btnBoton4.Location = new System.Drawing.Point(33, 192);
            this.btnBoton4.Name = "btnBoton4";
            this.btnBoton4.Size = new System.Drawing.Size(118, 54);
            this.btnBoton4.TabIndex = 3;
            this.btnBoton4.Text = "Operar";
            this.btnBoton4.UseVisualStyleBackColor = true;
            this.btnBoton4.Click += new System.EventHandler(this.btnBoton4_Click);
            // 
            // FrmTest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 267);
            this.Controls.Add(this.btnBoton4);
            this.Controls.Add(this.btnBoton3);
            this.Controls.Add(this.btnBoton2);
            this.Controls.Add(this.btnBoton1);
            this.Name = "FrmTest2";
            this.Text = "FrmTest2";
            this.Load += new System.EventHandler(this.FrmTest2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoton1;
        private System.Windows.Forms.Button btnBoton2;
        private System.Windows.Forms.Button btnBoton3;
        private System.Windows.Forms.Button btnBoton4;
    }
}