using ReaLTaiizor;
using ReaLTaiizor.Forms;

namespace projeto4
{
    public partial class principal : MaterialForm
    {
        public principal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.MdiParent = this;
            cadastro.Show();

            
        }

        private void op��esToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}