namespace _02_piramides
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
            this.lblNiveles = new System.Windows.Forms.Label();
            this.lbl_niveles = new System.Windows.Forms.Label();
            this.lbl_sobrante = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbBloques = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNiveles
            // 
            this.lblNiveles.AutoSize = true;
            this.lblNiveles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNiveles.Location = new System.Drawing.Point(1081, 92);
            this.lblNiveles.Name = "lblNiveles";
            this.lblNiveles.Size = new System.Drawing.Size(0, 13);
            this.lblNiveles.TabIndex = 0;
            // 
            // lbl_niveles
            // 
            this.lbl_niveles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_niveles.Location = new System.Drawing.Point(280, 18);
            this.lbl_niveles.Name = "lbl_niveles";
            this.lbl_niveles.Size = new System.Drawing.Size(125, 35);
            this.lbl_niveles.TabIndex = 1;
            // 
            // lbl_sobrante
            // 
            this.lbl_sobrante.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_sobrante.Location = new System.Drawing.Point(280, 68);
            this.lbl_sobrante.Name = "lbl_sobrante";
            this.lbl_sobrante.Size = new System.Drawing.Size(125, 35);
            this.lbl_sobrante.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(148, 32);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(101, 53);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular Niveles";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbBloques
            // 
            this.txbBloques.Location = new System.Drawing.Point(10, 49);
            this.txbBloques.Name = "txbBloques";
            this.txbBloques.Size = new System.Drawing.Size(106, 20);
            this.txbBloques.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(420, 120);
            this.Controls.Add(this.txbBloques);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbl_sobrante);
            this.Controls.Add(this.lbl_niveles);
            this.Controls.Add(this.lblNiveles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNiveles;
        private System.Windows.Forms.Label lbl_niveles;
        private System.Windows.Forms.Label lbl_sobrante;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbBloques;
    }
}

