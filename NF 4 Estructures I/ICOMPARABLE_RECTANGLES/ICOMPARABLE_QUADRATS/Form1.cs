using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICOMPARABLE_RECTANGLES
{
    public partial class Form1 : Form
    {
        const string FILE_NAME = "rectangles.csv";
        private List<Rectangle> rectangles;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rectangles = LlegirRectangles();
            MostrarDadesDataGrid();
        }

        private void MostrarDadesDataGrid()
        {
            this.dgvRectangles.DataSource = rectangles.ToArray();
        }

        private List<Rectangle> LlegirRectangles()
        {
            List<Rectangle> items = new List<Rectangle>();
            StreamReader sr = new StreamReader(FILE_NAME);
            String linia;
            sr.ReadLine(); //llegir la capçalera
            linia = sr.ReadLine();
            while (linia != null)
            {
                items.Add(new Rectangle(linia));
                linia = sr.ReadLine();
            }

            return items;
        }

        private void btnOrdenarNom_Click(object sender, EventArgs e)
        {
            rectangles.Sort();
            MostrarDadesDataGrid();

            //IComparer<Rectangle> comparador = Comparer<Rectangle>.Default;
            //rectangles.Sort(comparador);
            //MostrarDadesDataGrid();

        }

        private void btnOrdenarX_Click(object sender, EventArgs e)
        {
            rectangles.Sort(new Rectangle.ComparadorX());
            MostrarDadesDataGrid();
        }

        private void btnOrdenarAmplada_Click(object sender, EventArgs e)
        {
            rectangles.Sort(new Rectangle.ComparadorAmplada());
            MostrarDadesDataGrid();
        }

        private void btnOrdenarArea_Click(object sender, EventArgs e)
        {
            rectangles.Sort(new Rectangle.ComparadorArea());
            rectangles.Reverse();
            MostrarDadesDataGrid();
        }
    }
}
