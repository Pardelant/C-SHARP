namespace _01_dibujarExagonos
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
            this.lbxExagono = new System.Windows.Forms.ListBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.tbxCaracter = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCaracter = new System.Windows.Forms.Label();
            this.btnPintar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxExagono
            // 
            this.lbxExagono.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxExagono.FormattingEnabled = true;
            this.lbxExagono.ItemHeight = 21;
            this.lbxExagono.Location = new System.Drawing.Point(12, 77);
            this.lbxExagono.Name = "lbxExagono";
            this.lbxExagono.Size = new System.Drawing.Size(466, 340);
            this.lbxExagono.TabIndex = 0;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(32, 30);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 1;
            // 
            // tbxCaracter
            // 
            this.tbxCaracter.Location = new System.Drawing.Point(195, 30);
            this.tbxCaracter.Name = "tbxCaracter";
            this.tbxCaracter.Size = new System.Drawing.Size(100, 20);
            this.tbxCaracter.TabIndex = 2;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(58, 11);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero";
            // 
            // lblCaracter
            // 
            this.lblCaracter.AutoSize = true;
            this.lblCaracter.Location = new System.Drawing.Point(222, 11);
            this.lblCaracter.Name = "lblCaracter";
            this.lblCaracter.Size = new System.Drawing.Size(47, 13);
            this.lblCaracter.TabIndex = 4;
            this.lblCaracter.Text = "Caracter";
            // 
            // btnPintar
            // 
            this.btnPintar.Location = new System.Drawing.Point(355, 30);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(75, 23);
            this.btnPintar.TabIndex = 5;
            this.btnPintar.Text = "Pintar";
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.pintarHexagono);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 439);
            this.Controls.Add(this.btnPintar);
            this.Controls.Add(this.lblCaracter);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.tbxCaracter);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.lbxExagono);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxExagono;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox tbxCaracter;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCaracter;
        private System.Windows.Forms.Button btnPintar;
    }
}

