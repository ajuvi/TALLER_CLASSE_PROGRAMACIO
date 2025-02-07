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
    public partial class FrmSecundari : Form
    {

        //private double numero;

        public FrmSecundari()
        {
            InitializeComponent();
        }

        public FrmSecundari(double numero)
        {
            InitializeComponent();
            //this.numero = numero;

            txtNumero.Text = numero.ToString();

        }

        public double Numero
        {
            get 
            {
                return Convert.ToDouble(txtNumero.Text);
            }
            set
            {
                txtNumero.Text = value.ToString();
            }
        }

        private void btnTornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
