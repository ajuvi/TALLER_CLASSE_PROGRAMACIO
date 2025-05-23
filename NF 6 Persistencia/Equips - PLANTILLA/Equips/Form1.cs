using DAO_Pattern;
namespace Equips
{
    public partial class frmMain : Form
    {
        private DAOTeamFactory factory = new DAOTeamFactory();
        private IDAO<Team> dao;
        public frmMain()
        {
            dao = factory.CreateDAOTeamInstance(DataSource.XML);
            InitializeComponent();
        }

        private void Neteja()
        {
            txtABV.Text = "";
            txtNom.Text = "";
            txtPressupost.Text = "";
            imgLog.Image = null;
        }
        private void mnuItemGetTeam_Click(object sender, EventArgs e)
        {
            if (txtABV.Text != "" && txtABV.Text.Length == 3)
            {
                Team t = dao.GetValue(txtABV.Text);
                if (t != null)
                {
                    txtNom.Text = t.Name;
                    txtPressupost.Text = Convert.ToString(t.Budget);
                    imgLog.ImageLocation = t.LogoLink;
                    imgLog.SizeMode = PictureBoxSizeMode.Zoom;

                }
                else
                {
                    Neteja();
                    txtNom.Text = "NO EXISTEIX EQUIP SOL·LICITAT";
                }
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void llistarTotsElsEquipsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearEquiipToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imgLog_Click(object sender, EventArgs e)
        {

        }

        private void txtABV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtABV_Enter(object sender, EventArgs e)
        {
            Neteja();
        }
    }
}
