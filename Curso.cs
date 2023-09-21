using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Data;

namespace projeto4
{
    public partial class Curso : MaterialForm
    {
        bool isAlteracao = false;
        string cs = @"server=localhost;" +
                    "uid=root;" +
                    "pwd=;" +
                    "database=academico";


        public Curso()
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
                sql = "UPDATE curso SET " +
                          "nome = @nome," +
                          "tipo = @tipo," +
                          "ano_criacao = @ano_criacao" +
                          " WHERE id = @id";
            }
            else
            {
                sql = "INSERT INTO curso(nome, tipo, ano_criacao) VALUES (@nome, @tipo, @ano_criacao)";
            }
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@tipo", cboTipo.Text);
            cmd.Parameters.AddWithValue("@ano_criacao", txtAno.Text);
            
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

            var sql = "SELECT * FROM curso";

            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboTipo.Text))
            {
                MessageBox.Show("Tipo é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTipo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAno.Text))
            {
                MessageBox.Show("Ano de criação é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAno.Focus();
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
                MessageBox.Show("Selecione um curso!", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "DELETE FROM CURSO WHERE id = @id";
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
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                cboTipo.Text = linha.Cells["tipo"].Value.ToString();
                txtAno.Text = linha.Cells["ano_criacao"].Value.ToString();
                materialTabControl1.SelectedIndex = 0;
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "IFSP",
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
            materialTabControl1.SelectedIndex = 0;
            txtNome.Focus();
        }

        private void txtNome_Click_1(object sender, EventArgs e)
        {

        }
    }

}
