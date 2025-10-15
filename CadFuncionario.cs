using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;


namespace AUqueMIA_Pets
{
    public partial class frmFuncionario : Form
    {
        MySqlConnection conexao;
        string acao = "";

        public frmFuncionario() => InitializeComponent();


        private void frmFuncionario_Load(object sender, EventArgs e)
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
            txtCpf.Enabled = true;
            txtTelefone.Enabled = true;
            cbFuncao.Enabled = true;
        }

        public void desabilitarCampos()
        {
            txtId.Enabled = false;
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtTelefone.Enabled = false;
            cbFuncao.Enabled = false;
        }

        public void limparCampos()
        {
            txtId.Text = string.Empty;
            txtNome.Text = "";
            txtCpf.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            cbFuncao.Text = string.Empty;
            txtId.Enabled = true;
        }



        private void btNovo_Click_1(object sender, EventArgs e)
        {
            habilitarCampos();
            btNovo.Enabled = true;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            txtId.Enabled = false;
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
                "insert into funcionario (nome,cpf,telefone,funcao)" +
                        " values ('" + txtNome.Text + "','" + txtCpf.Text + "','" + txtTelefone.Text + "','" + cbFuncao.Text + "')", conexao);


                var dados = comando.ExecuteReader();
                dados.Close();
                comando = null;


                MessageBox.Show("Salvo com sucesso!");

                desabilitarCampos();
                limparCampos();

                btCancelar.Enabled = false;
                btSalvar.Enabled = false;
                btNovo.Enabled = true;
                txtId.Enabled = true;

            }

            if (acao == "novo")
            {
                MySqlCommand comando = new MySqlCommand(
                "insert into funcionario (nome,cpf,telefone,funcao)" +
                    " values ('" + txtNome.Text + "','" + txtCpf.Text + "','" + txtTelefone.Text + "','" + cbFuncao.Text + "')", conexao);
            }
            if (acao == "editar")
            {
                MySqlCommand comando = new MySqlCommand(
                    "update funcionario set nome='" + txtNome.Text + "',cpf='" + txtCpf.Text +
                    "',telefone='" + txtTelefone.Text + "',funcao='" + cbFuncao.Text + "' where id = " + txtId.Text, conexao);
            }

            else
            {
                //MessageBox.Show("Preencha corretamente os campos:" + mensagem);
            }

            //MessageBox.Show("Salvo com sucesso!");
        }
        string mensagem = string.Empty;
        private bool validarCampos()
        {
            mensagem = "";
            if (txtNome.Text.Length < 3)
                mensagem += "\nDigite o campo nome";
            if (txtCpf.Text.Length == 10)
                mensagem += "\nO CPF deve conter 11 dígitos.";
            if (txtTelefone.Text.Length == 10)
                mensagem += "\nDigite o código da área e o número do telefone";
            if (mensagem.Length == 0)
                return true;
            else
                return false;
        }


        private void btBuscar_Click(object sender, EventArgs e)
        {
            btEditar.Enabled = true;

            try
            {
                string txtid = txtId.Text;
                var comando = new MySqlCommand(
                    "select * from funcionario where idFuncionario=" + txtid,
                    conexao);
                var dados = comando.ExecuteReader();

                if (dados.Read())
                {
                    //txtId.Text = $"{dados["Id"]}";
                    txtNome.Text = $"{dados["Nome"]}";
                    txtCpf.Text = $"{dados["CPF"]}";
                    txtTelefone.Text = $"{dados["Telefone"]}";
                    cbFuncao.Text = $"{dados["Funcao"]}";
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

        private void btEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            id.Enabled = false;
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
                    "delete from funcionario where idFuncionario = " + txtId.Text,
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
                listagem.Columns.Add("Id", 30, HorizontalAlignment.Left);
                listagem.Columns.Add("Nome", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("CPF", 85, HorizontalAlignment.Left);
                listagem.Columns.Add("Telefone", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("Função", 60, HorizontalAlignment.Left);
                //listagem.Columns.Add("Turma", 48, HorizontalAlignment.Left);
                string sql = "SELECT * FROM funcionario order by nome";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                //ESTRUTURAR OS DADOS RECEBIDOS DO MYSQL E MOSTRAR AO USUÁRIO
                // reader = leitor
                MySqlDataReader dados = cmd.ExecuteReader();

                listagem.Items.Clear();

                while (dados.Read())
                {
                    string[] linha = { dados.GetString(0), //pega a id
                    dados.GetString(1), // pega o nome
                    dados.GetString(2), // pega o cpf
                    dados.GetString(3), // pega o telefone
                    dados.GetString(4)}; // pega a função
                    //dados.GetString(5)};

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
                listagem.Columns.Add("Id", 30, HorizontalAlignment.Left);
                listagem.Columns.Add("Nome", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("CPF", 85, HorizontalAlignment.Left);
                listagem.Columns.Add("Telefone", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("Função", 60, HorizontalAlignment.Left);
                string sql = "SELECT * FROM funcionario where nome like '" + pesquisar.Text + "%' order by nome";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                //ESTRUTURAR OS DADOS RECEBIDOS DO MYSQL E MOSTRAR AO USUÁRIO
                // reader = leitor
                MySqlDataReader dados = cmd.ExecuteReader();

                listagem.Items.Clear();


                while (dados.Read())
                {
                    string[] linha = { dados.GetString(0), //pega a id
                    dados.GetString(1), // pega o nome
                    dados.GetString(2), // pega o cpf
                    dados.GetString(3), // pega o telefone
                    dados.GetString(4)}; // pega a função

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
                txtId.Text = item.SubItems[0].Text;
                txtNome.Text = item.SubItems[1].Text;
                txtCpf.Text = item.SubItems[2].Text;
                txtTelefone.Text = item.SubItems[3].Text;
                cbFuncao.Text = item.SubItems[4].Text;
                btEditar.Enabled = true;
                btExcluir.Enabled = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Error:{erro.Message}");
            }
        }
    }
}
