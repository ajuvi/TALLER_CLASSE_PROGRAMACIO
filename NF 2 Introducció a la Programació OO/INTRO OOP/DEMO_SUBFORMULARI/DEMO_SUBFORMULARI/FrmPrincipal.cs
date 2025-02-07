using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO_SUBFORMULARI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtNumero.Text);

            FrmSecundari frm2 = new FrmSecundari();
            frm2.Numero = numero;
            frm2.ShowDialog();

            txtCalcul.Text = "" + frm2.Numero;

        }
    }
}
