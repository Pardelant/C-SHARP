namespace _04_houstonVerificacion
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
            this.lblText1 = new System.Windows.Forms.Label();
            this.txbBloque1 = new System.Windows.Forms.TextBox();
            this.txbBloque2 = new System.Windows.Forms.TextBox();
            this.txbVector1 = new System.Windows.Forms.TextBox();
            this.txbVector2 = new System.Windows.Forms.TextBox();
            this.lblVectores = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMostrarVector1 = new System.Windows.Forms.Label();
            this.lblMostrarVector2 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(17, 15);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(60, 13);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "Nº Bloques";
            // 
            // txbBloque1
            // 
            this.txbBloque1.Location = new System.Drawing.Point(29, 31);
            this.txbBloque1.Name = "txbBloque1";
            this.txbBloque1.Size = new System.Drawing.Size(23, 20);
            this.txbBloque1.TabIndex = 1;
            // 
            // txbBloque2
            // 
            this.txbBloque2.Location = new System.Drawing.Point(29, 57);
            this.txbBloque2.Name = "txbBloque2";
            this.txbBloque2.Size = new System.Drawing.Size(23, 20);
            this.txbBloque2.TabIndex = 2;
            // 
            // txbVector1
            // 
            this.txbVector1.Location = new System.Drawing.Point(82, 31);
            this.txbVector1.Name = "txbVector1";
            this.txbVector1.Size = new System.Drawing.Size(165, 20);
            this.txbVector1.TabIndex = 3;
            // 
            // txbVector2
            // 
            this.txbVector2.Location = new System.Drawing.Point(82, 57);
            this.txbVector2.Name = "txbVector2";
            this.txbVector2.Size = new System.Drawing.Size(165, 20);
            this.txbVector2.TabIndex = 4;
            // 
            // lblVectores
            // 
            this.lblVectores.AutoSize = true;
            this.lblVectores.Location = new System.Drawing.Point(131, 15);
            this.lblVectores.Name = "lblVectores";
            this.lblVectores.Size = new System.Drawing.Size(48, 13);
            this.lblVectores.TabIndex = 5;
            this.lblVectores.Text = "vectores";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMostrarVector1
            // 
            this.lblMostrarVector1.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblMostrarVector1.Location = new System.Drawing.Point(79, 90);
            this.lblMostrarVector1.Name = "lblMostrarVector1";
            this.lblMostrarVector1.Size = new System.Drawing.Size(168, 18);
            this.lblMostrarVector1.TabIndex = 7;
            // 
            // lblMostrarVector2
            // 
            this.lblMostrarVector2.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblMostrarVector2.Location = new System.Drawing.Point(79, 122);
            this.lblMostrarVector2.Name = "lblMostrarVector2";
            this.lblMostrarVector2.Size = new System.Drawing.Size(168, 18);
            this.lblMostrarVector2.TabIndex = 8;
            // 
            // lblRes
            // 
            this.lblRes.BackColor = System.Drawing.SystemColors.Info;
            this.lblRes.Location = new System.Drawing.Point(79, 149);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(168, 18);
            this.lblRes.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 176);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblMostrarVector2);
            this.Controls.Add(this.lblMostrarVector1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblVectores);
            this.Controls.Add(this.txbVector2);
            this.Controls.Add(this.txbVector1);
            this.Controls.Add(this.txbBloque2);
            this.Controls.Add(this.txbBloque1);
            this.Controls.Add(this.lblText1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.TextBox txbBloque1;
        private System.Windows.Forms.TextBox txbBloque2;
        private System.Windows.Forms.TextBox txbVector1;
        private System.Windows.Forms.TextBox txbVector2;
        private System.Windows.Forms.Label lblVectores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMostrarVector1;
        private System.Windows.Forms.Label lblMostrarVector2;
        private System.Windows.Forms.Label lblRes;
    }
}

