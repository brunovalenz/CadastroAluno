using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Data;

namespace projeto4
{
    public partial class Cadastro : MaterialForm
    {
        bool isAlteracao = false ;
        string cs = @"server=localhost;" +
                    "uid=root;" +
                    "pwd=;" +
                    "database=academico";


        public Cadastro()
        {
            InitializeComponent();
        }

        private void txtNome_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBoxEdit3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPage1.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                    continue;
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }

            }

        }

        private void Salvar()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            if (!isAlteracao)
            {
                var sql = "INSERT INTO aluno(Matricula, dt_nascimento, nome, endereco, bairro, cidade, estado, senha) VALUES (@Matricula, @dt_nascimento, @nome, @endereco, @bairro, @cidade, @estado, @senha)";
                var cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                DateTime.TryParse(txtDataNasc.Text, out var dataNascimento);
                cmd.Parameters.AddWithValue("@dt_nascimento", dataNascimento);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereço.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("@estado", cboEstado.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

            }
            else
            {

            }
            LimpaCampos();
        }

        private void CarregaGrid()
        {
            var con = new MySqlConnection(cs);
            con.Open();

            var sql = "SELECT * FROM aluno";

            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void materialTabControl1_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }

}
