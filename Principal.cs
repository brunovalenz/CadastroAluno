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

        private void principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.MdiParent = this;
            professor.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.MdiParent = this;
            curso.Show();
        }

        private void relat�rioAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relat�rioAluno relatorioAluno = new Relat�rioAluno();
            relatorioAluno.MdiParent = this;
            relatorioAluno.Show();
        }

    }
}