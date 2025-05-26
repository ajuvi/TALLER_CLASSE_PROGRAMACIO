namespace Equips
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuItemGetTeam = new ToolStripMenuItem();
            llistarTotsElsEquipsToolStripMenuItem = new ToolStripMenuItem();
            modificarEquipToolStripMenuItem = new ToolStripMenuItem();
            eliminarEquipToolStripMenuItem = new ToolStripMenuItem();
            crearEquiipToolStripMenuItem = new ToolStripMenuItem();
            lblAbreviatura = new Label();
            lblNom = new Label();
            lblPressupost = new Label();
            imgLog = new PictureBox();
            txtABV = new TextBox();
            txtNom = new TextBox();
            txtPressupost = new TextBox();
            dgvEquips = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquips).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuItemGetTeam, llistarTotsElsEquipsToolStripMenuItem, modificarEquipToolStripMenuItem, eliminarEquipToolStripMenuItem, crearEquiipToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1262, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuItemGetTeam
            // 
            mnuItemGetTeam.Name = "mnuItemGetTeam";
            mnuItemGetTeam.Size = new Size(135, 24);
            mnuItemGetTeam.Text = "Obtenir un equip";
            mnuItemGetTeam.Click += mnuItemGetTeam_Click;
            // 
            // llistarTotsElsEquipsToolStripMenuItem
            // 
            llistarTotsElsEquipsToolStripMenuItem.Name = "llistarTotsElsEquipsToolStripMenuItem";
            llistarTotsElsEquipsToolStripMenuItem.Size = new Size(163, 24);
            llistarTotsElsEquipsToolStripMenuItem.Text = "Llistar Tots Els Equips";
            llistarTotsElsEquipsToolStripMenuItem.Click += llistarTotsElsEquipsToolStripMenuItem_Click;
            // 
            // modificarEquipToolStripMenuItem
            // 
            modificarEquipToolStripMenuItem.Name = "modificarEquipToolStripMenuItem";
            modificarEquipToolStripMenuItem.Size = new Size(129, 24);
            modificarEquipToolStripMenuItem.Text = "Modificar Equip";
            // 
            // eliminarEquipToolStripMenuItem
            // 
            eliminarEquipToolStripMenuItem.Name = "eliminarEquipToolStripMenuItem";
            eliminarEquipToolStripMenuItem.Size = new Size(119, 24);
            eliminarEquipToolStripMenuItem.Text = "Eliminar Equip";
            eliminarEquipToolStripMenuItem.Click += eliminarEquipToolStripMenuItem_Click;
            // 
            // crearEquiipToolStripMenuItem
            // 
            crearEquiipToolStripMenuItem.Name = "crearEquiipToolStripMenuItem";
            crearEquiipToolStripMenuItem.Size = new Size(100, 24);
            crearEquiipToolStripMenuItem.Text = "Crear Equip";
            crearEquiipToolStripMenuItem.Click += crearEquiipToolStripMenuItem_Click;
            // 
            // lblAbreviatura
            // 
            lblAbreviatura.AutoSize = true;
            lblAbreviatura.Location = new Point(728, 74);
            lblAbreviatura.Margin = new Padding(2, 0, 2, 0);
            lblAbreviatura.Name = "lblAbreviatura";
            lblAbreviatura.Size = new Size(115, 20);
            lblAbreviatura.TabIndex = 1;
            lblAbreviatura.Text = "ABREVIATURA : ";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(728, 118);
            lblNom.Margin = new Padding(2, 0, 2, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(47, 20);
            lblNom.TabIndex = 2;
            lblNom.Text = "NOM:";
            // 
            // lblPressupost
            // 
            lblPressupost.AutoSize = true;
            lblPressupost.Location = new Point(728, 156);
            lblPressupost.Margin = new Padding(2, 0, 2, 0);
            lblPressupost.Name = "lblPressupost";
            lblPressupost.Size = new Size(98, 20);
            lblPressupost.TabIndex = 3;
            lblPressupost.Text = "PRESSUPOST:";
            // 
            // imgLog
            // 
            imgLog.Location = new Point(744, 221);
            imgLog.Margin = new Padding(2);
            imgLog.Name = "imgLog";
            imgLog.Size = new Size(482, 355);
            imgLog.TabIndex = 4;
            imgLog.TabStop = false;
            imgLog.Click += imgLog_Click;
            // 
            // txtABV
            // 
            txtABV.Location = new Point(874, 74);
            txtABV.Margin = new Padding(2);
            txtABV.Name = "txtABV";
            txtABV.Size = new Size(121, 27);
            txtABV.TabIndex = 5;
            txtABV.TextChanged += txtABV_TextChanged;
            txtABV.Enter += txtABV_Enter;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(874, 113);
            txtNom.Margin = new Padding(2);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(228, 27);
            txtNom.TabIndex = 6;
            // 
            // txtPressupost
            // 
            txtPressupost.Location = new Point(874, 156);
            txtPressupost.Margin = new Padding(2);
            txtPressupost.Name = "txtPressupost";
            txtPressupost.Size = new Size(121, 27);
            txtPressupost.TabIndex = 7;
            // 
            // dgvEquips
            // 
            dgvEquips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquips.Location = new Point(72, 87);
            dgvEquips.Margin = new Padding(2);
            dgvEquips.Name = "dgvEquips";
            dgvEquips.RowHeadersWidth = 62;
            dgvEquips.Size = new Size(554, 489);
            dgvEquips.TabIndex = 8;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 750);
            Controls.Add(dgvEquips);
            Controls.Add(txtPressupost);
            Controls.Add(txtNom);
            Controls.Add(txtABV);
            Controls.Add(imgLog);
            Controls.Add(lblPressupost);
            Controls.Add(lblNom);
            Controls.Add(lblAbreviatura);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "frmMain";
            Text = "APP EQUIPS";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquips).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuItemGetTeam;
        private Label lblAbreviatura;
        private Label lblNom;
        private Label lblPressupost;
        private PictureBox imgLog;
        private TextBox txtABV;
        private TextBox txtNom;
        private TextBox txtPressupost;
        private ToolStripMenuItem llistarTotsElsEquipsToolStripMenuItem;
        private ToolStripMenuItem modificarEquipToolStripMenuItem;
        private ToolStripMenuItem eliminarEquipToolStripMenuItem;
        private ToolStripMenuItem crearEquiipToolStripMenuItem;
        private DataGridView dgvEquips;
    }
}
