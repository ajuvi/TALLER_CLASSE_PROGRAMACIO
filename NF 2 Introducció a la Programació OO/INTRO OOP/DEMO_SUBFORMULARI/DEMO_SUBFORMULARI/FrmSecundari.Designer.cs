namespace DEMO_SUBFORMULARI
{
    partial class FrmSecundari
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
            this.btnTornar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTornar
            // 
            this.btnTornar.Location = new System.Drawing.Point(156, 65);
            this.btnTornar.Name = "btnTornar";
            this.btnTornar.Size = new System.Drawing.Size(167, 60);
            this.btnTornar.TabIndex = 0;
            this.btnTornar.Text = "TORNA AL FORMULARI PRINCIPAL";
            this.btnTornar.UseVisualStyleBackColor = true;
            this.btnTornar.Click += new System.EventHandler(this.btnTornar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(75, 141);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(320, 22);
            this.txtNumero.TabIndex = 1;
            // 
            // FrmSecundari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 213);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnTornar);
            this.Name = "FrmSecundari";
            this.Text = "SUBFORMULARI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTornar;
        private System.Windows.Forms.TextBox txtNumero;
    }
}