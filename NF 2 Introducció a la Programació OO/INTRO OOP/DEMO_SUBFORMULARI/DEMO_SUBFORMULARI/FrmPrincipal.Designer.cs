namespace DEMO_SUBFORMULARI
{
    partial class FrmPrincipal
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
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCalcul = new System.Windows.Forms.TextBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Location = new System.Drawing.Point(234, 21);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(233, 16);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "INFO PASSADA AL SUBFORMULARI";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(234, 150);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(265, 16);
            this.lblInfo2.TabIndex = 1;
            this.lblInfo2.Text = "INFO RETRONADA DEL SUBFORMULARI";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(237, 59);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(216, 22);
            this.txtNumero.TabIndex = 2;
            // 
            // txtCalcul
            // 
            this.txtCalcul.Location = new System.Drawing.Point(237, 107);
            this.txtCalcul.Name = "txtCalcul";
            this.txtCalcul.Size = new System.Drawing.Size(213, 22);
            this.txtCalcul.TabIndex = 3;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(32, 38);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(137, 100);
            this.btnCarregar.TabIndex = 4;
            this.btnCarregar.Text = "CARREGAR SUBFORMULARI";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 210);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.txtCalcul);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Name = "FrmPrincipal";
            this.Text = "DEMO AMB SUBFORMULARI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCalcul;
        private System.Windows.Forms.Button btnCarregar;
    }
}

