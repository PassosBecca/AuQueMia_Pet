using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;

namespace AUqueMIA_Pets
{
    public partial class frmTutor : Form
    {

        MySqlConnection conexao;
        string acao = "";
        public frmTutor() => InitializeComponent();



        private void frmTutor_Load(object sender, EventArgs e)
        {
            try
            {
                string strConexao = "server=localhost;" +
                    "user=root;" +
                    "database=petshop";
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                //MessageBox.Show("Conectado ao Servidor!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtCpf.Enabled = true;
            txtTelefone.Enabled = true;
        }

        public void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtCpf.Enabled = false;
            txtTelefone.Enabled = false;
        }


        public void limparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCpf.Text = string.Empty;
            txtTelefone.Text = string.Empty;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btNovo.Enabled = true;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            acao = "novo";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
            limparCampos();
            listagem.Items.Clear();
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            btNovo.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                MySqlCommand? comando = new MySqlCommand(
                "insert into tutor (cpf,nome,endereco,telefone)" +
                        " values ('" + txtCpf.Text + "','" + txtNome.Text + "','" + txtEndereco.Text + "','" + txtTelefone.Text + "')", conexao);


                var dados = comando.ExecuteReader();
                dados.Close();
                comando = null;


                MessageBox.Show("Salvo com sucesso!");

                desabilitarCampos();
                limparCampos();

                btCancelar.Enabled = false;
                btSalvar.Enabled = false;
                btNovo.Enabled = true;
            }

            if (acao == "novo")
            {
                MySqlCommand? comando = new MySqlCommand(
                "insert into tutor (cpf,nome,endereco,telefone)" +
                        " values ('" + txtCpf.Text + "','" + txtNome.Text + "','" + txtEndereco.Text + "','" + txtTelefone + "')", conexao);
            }
            if (acao == "editar")
            {
                MySqlCommand? comando = new MySqlCommand(
                    "update tutor set nome='" + txtNome.Text + "',endereco='" + txtEndereco.Text + "',cpf='" + txtCpf.Text +
                    "',telefone='" + txtTelefone.Text + "' where cpf = " + txtCpf.Text, conexao);
            }

            else
            {
                //MessageBox.Show("Preencha corretamente os campos:" + mensagem);
            }
        }
        string mensagem = string.Empty;
        private bool validarCampos()
        {
            mensagem = "";
            if (txtNome.Text.Length < 3)
                mensagem += "\nDigite o campo nome";
            if (txtEndereco.Text.Length < 5)
                mensagem += "\nO endereço precisa ter mais que 5 caracteres.";
            if (txtCpf.Text.Length == 10)
                mensagem += "\nO CPF deve conter 11 dígitos.";
            if (txtTelefone.Text.Length == 10)
                mensagem += "\nDigite o código da área e o número do telefone";

            if (mensagem.Length == 0)
                return true;
            else
                return false;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btNovo.Enabled = false;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;
            acao = "editar";
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "Confirmação", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MySqlCommand? comando = new MySqlCommand(
                    "delete from tutor where cpf = " + cpf.Text,
                    conexao);
                var dados = comando.ExecuteReader();
                dados.Close();
                comando = null;
                MessageBox.Show("Excluído com sucesso!");
                desabilitarCampos();
                limparCampos();
                btNovo.Enabled = true;
                btSalvar.Enabled = false;
                btCancelar.Enabled = false;
                btEditar.Enabled = false;
                btExcluir.Enabled = false;
                listagem.Clear();
            }
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            btCancelar.Enabled = true;
            try
            {
                listagem.Columns.Clear();
                listagem.GridLines = true;
                listagem.View = View.Details;
                listagem.AllowColumnReorder = true;
                listagem.FullRowSelect = true;

                listagem.Columns.Add("CPF", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("Nome", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("Endereço", 130, HorizontalAlignment.Left);
                listagem.Columns.Add("Telefone", 90, HorizontalAlignment.Left);
                string sql = "SELECT * FROM tutor order by nome";
                MySqlCommand? cmd = new MySqlCommand(sql, conexao);

                //ESTRUTURAR OS DADOS RECEBIDOS DO MYSQL E MOSTRAR AO USUÁRIO
                // reader = leitor
                MySqlDataReader dados = cmd.ExecuteReader();

                listagem.Items.Clear();

                while (dados.Read())
                {
                    string[] linha = { dados.GetString(0), //pega o cpf
                    dados.GetString(1), // pega o nome
                    dados.GetString(2), // pega o endereco
                    dados.GetString(3) }; // pega o telefone



                    ListViewItem estrutura_da_linha = new ListViewItem(linha);

                    listagem.Items.Add(estrutura_da_linha);
                }
                dados.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu errado, erro: " + ex.Message);
            }
        }

        private void pesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            btCancelar.Enabled = true;
            try
            {
                listagem.Columns.Clear();
                listagem.GridLines = true;
                listagem.View = View.Details;
                listagem.AllowColumnReorder = true;
                listagem.FullRowSelect = true;
                listagem.Columns.Add("CPF", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("Nome", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("Endereço", 130, HorizontalAlignment.Left);
                listagem.Columns.Add("Telefone", 90, HorizontalAlignment.Left);
                string sql = "SELECT * FROM tutor where nome like '" + pesquisar.Text + "%' order by nome";
                MySqlCommand? cmd = new MySqlCommand(sql, conexao);

                //ESTRUTURAR OS DADOS RECEBIDOS DO MYSQL E MOSTRAR AO USUÁRIO
                // reader = leitor
                MySqlDataReader dados = cmd.ExecuteReader();

                listagem.Items.Clear();


                while (dados.Read())
                {
                    string[] linha = { dados.GetString(0), //pega o cpf
                    dados.GetString(1), // pega o nome
                    dados.GetString(2), // pega o endereco
                    dados.GetString(3) }; // pega o telefone

                    ListViewItem estrutura_da_linha = new ListViewItem(linha);

                    listagem.Items.Add(estrutura_da_linha);
                }
                dados.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu errado, erro: " + ex.Message);
            }
        }

        private void listagem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ListViewItem item = listagem.SelectedItems[0];
                txtCpf.Text = item.SubItems[0].Text;
                txtNome.Text = item.SubItems[1].Text;
                txtEndereco.Text = item.SubItems[2].Text;
                txtTelefone.Text = item.SubItems[3].Text;
                btEditar.Enabled = true;
                btExcluir.Enabled = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Error:{erro.Message}");
            }
        }

        private void btBuscar_Click_1(object sender, EventArgs e)
        {
            btEditar.Enabled = true;
            try
            {
                string txtid = txtId.Text;
                var comando = new MySqlCommand(
                    "select * from tutor where cpf=" + txtid,
                    conexao);
                var dados = comando.ExecuteReader();

                if (dados.Read())
                {
                    txtCpf.Text = $"{dados["CPF"]}";
                    txtNome.Text = $"{dados["Nome"]}";
                    txtEndereco.Text = $"{dados["Endereço"]}";
                    txtTelefone.Text = $"{dados["Telefone"]}";
                }
                else
                {
                    limparCampos();
                    MessageBox.Show("Não encontrado!");
                }
                dados.Close();
                comando = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
