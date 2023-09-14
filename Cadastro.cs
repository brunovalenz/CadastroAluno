using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Data;

namespace projeto4
{
    public partial class Cadastro : MaterialForm
    {
        bool isAlteracao = false;
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
            if (ValidarFormulario())
            {
                Salvar();
                materialTabControl1.SelectedIndex = 1;
            }

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
            var sql = "";
            if (isAlteracao)
            {
                sql = "UPDATE aluno SET " +
                          "matricula = @matricula," +
                          "data_nasc = @data_nasc," +
                          "nome = @nome," +
                          "endereco = @endereco," +
                          "bairro = @bairro," +
                          "cidade = @cidade," +
                          "estado= @estado," +
                          "senha = @senha" +
                          " WHERE id = @id";
            }
            else
            {
                sql = "INSERT INTO aluno(matricula, data_nasc, nome, endereco, bairro, cidade, estado, senha) VALUES (@matricula, @data_nasc, @nome, @endereco, @bairro, @cidade, @estado, @senha)";
            }

            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text);
            DateTime.TryParse(txtDataNasc.Text, out var dataNascimento);
            cmd.Parameters.AddWithValue("@data_nasc", dataNascimento);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereço.Text);
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
            cmd.Parameters.AddWithValue("@estado", cboEstado.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
            if (isAlteracao)
            {
                cmd.Parameters.AddWithValue("@id", txtID.Text);
            }
            cmd.Prepare();
            cmd.ExecuteNonQuery();

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

        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matricula é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (!DateTime.TryParse(txtDataNasc.Text, out DateTime _))
            {
                MessageBox.Show("Data é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataNasc.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEndereço.Text))
            {
                MessageBox.Show("Endereço é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereço.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Bairro é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Cidade é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }
            return true;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente deletar?", "IFSP",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um aluno!", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "DELETE FROM ALUNO WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridView1.SelectedRows[0];
                txtID.Text = linha.Cells["id"].Value.ToString();
                txtMatricula.Text = linha.Cells["matricula"].Value.ToString();
                txtDataNasc.Text = linha.Cells["data_nasc"].Value.ToString();
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtEndereço.Text = linha.Cells["endereco"].Value.ToString();
                txtBairro.Text = linha.Cells["bairro"].Value.ToString();
                txtCidade.Text = linha.Cells["cidade"].Value.ToString();
                cboEstado.Text = linha.Cells["estado"].Value.ToString();
                txtSenha.Text = linha.Cells["senha"].Value.ToString();
                materialTabControl1.SelectedIndex = 0;
                txtMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum aluno!", "IFSP",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            txtNome.Focus();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Salvar();
                materialTabControl1.SelectedIndex = 1;
            }
        }

       
    }

}
