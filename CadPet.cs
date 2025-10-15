using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUqueMIA_Pets
{
    public partial class frmPet : Form
    {
        MySqlConnection conexao;
        string acao = "";

        public frmPet()
        {
            InitializeComponent();
        }

        private void frmPet_Load(object sender, EventArgs e)
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
            txtCpf.Enabled = true;
            txtNome.Enabled = true;
            txtId.Enabled = true;
            txtPet.Enabled = true;
            cbEspecie.Enabled = true;
            cbPorte.Enabled = true;
            cbSexo.Enabled = true;
        }

        public void desabilitarCampos()
        {
            txtCpf.Enabled = false;
            txtNome.Enabled = false;
            txtId.Enabled = false;
            txtPet.Enabled = false;
            cbEspecie.Enabled = false;
            cbPorte.Enabled = false;
            cbSexo.Enabled = false;
        }


        public void limparCampos()
        {
            txtCpf.Text = string.Empty;
            txtNome.Text = "";
            txtId.Text = string.Empty;
            txtPet.Text = "";
            cbEspecie.Text = "";
            cbPorte.Text = "";
            cbSexo.Text = "";
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btNovo.Enabled = true;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            acao = "novo";
            txtNome.Enabled = false;
            txtCpf.Enabled = true;
            txtId.Enabled = false;
            txtId.Text = "";
            txtPet.Text = "";
            cbEspecie.Text = "";
            cbPorte.Text = "";
            cbSexo.Text = "";

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
                "insert into pet (idPet,cpf_tutor,nome_pet,especie,sexo,porte)" +
                        " values ('" + txtId.Text + "','" + txtCpf.Text + "','" + txtPet.Text + "','" + cbEspecie.Text + "','" + cbSexo.Text + "','" + cbPorte.Text + "')", conexao);


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
                "insert into pet (idPet,cpf_tutor,nome_pet,especie,sexo,porte)" +
                        " values ('" + txtId.Text + "','" + txtCpf.Text + "','" + txtPet.Text + "','" + cbEspecie.Text + "','" + cbSexo.Text + "','" + cbPorte.Text + "')", conexao);

            }
            if (acao == "editar")
            {
                MySqlCommand? comando = new MySqlCommand(
                    "update pet set nome_pet='" + txtPet.Text + "',especie='" + cbEspecie.Text + "',porte='" + cbSexo.Text + "',sexo='" + cbPorte.Text +
                    "' where nome = " + txtNome.Text, conexao);
            }

            else
            {
                MessageBox.Show("Preencha corretamente os campos:" + mensagem);
            }
        }
        string mensagem = string.Empty;

        private bool validarCampos()
        {
            mensagem = "";
            if (txtPet.Text.Length < 3)
                mensagem += "\nDigite o nome do animal";
            if (cbEspecie.Text.Length == 0)
                mensagem += "\nEscolha uma opção.";
            if (cbPorte.Text.Length == 0)
                mensagem += "\nEscolha uma opção.";
            if (cbSexo.Text.Length == 0)
                mensagem += "\nEscolha uma opção.";

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
                string txtcpf = txtCpf.Text;
                var comando = new MySqlCommand(
                    "select * from tutor where cpf=" + txtcpf,
                    conexao);
                var dados = comando.ExecuteReader();

                if (dados.Read())
                {
                    txtCpf.Text = $"{dados["CPF"]}";
                    txtNome.Text = $"{dados["Nome"]}";
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
            btNovo.Enabled = false;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtId.Enabled = false;
            acao = "editar";
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "Confirmação", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MySqlCommand? comando = new MySqlCommand(
                    "delete from pet where nome_Pet = " + txtPet.Text,
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
                listagem.Columns.Add("Tutor", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("Id", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("Pet", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("Especie", 130, HorizontalAlignment.Left);
                listagem.Columns.Add("Sexo", 130, HorizontalAlignment.Left);
                listagem.Columns.Add("Porte", 90, HorizontalAlignment.Left);
                string sql = "SELECT * FROM pet, tutor where pet.cpf_tutor=tutor.cpf order by cpf_tutor";
                MySqlCommand? cmd = new MySqlCommand(sql, conexao);

                //ESTRUTURAR OS DADOS RECEBIDOS DO MYSQL E MOSTRAR AO USUÁRIO
                // reader = leitor
                MySqlDataReader dados = cmd.ExecuteReader();

                listagem.Items.Clear();

                while (dados.Read())
                {
                    string[] linha = { dados.GetString(6),
                    dados.GetString(7),
                    dados.GetString(0),
                    dados.GetString(2),
                    dados.GetString(3),
                    dados.GetString(4),
                    dados.GetString(5) };



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
                listagem.Columns.Add("Tutor", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("Id", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("Pet", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("Especie", 130, HorizontalAlignment.Left);
                listagem.Columns.Add("Sexo", 130, HorizontalAlignment.Left);
                listagem.Columns.Add("Porte", 90, HorizontalAlignment.Left);
                string sql = "SELECT * FROM pet, tutor where pet.cpf_tutor=tutor.cpf order by cpf_tutor";
                MySqlCommand? cmd = new MySqlCommand(sql, conexao);

                //ESTRUTURAR OS DADOS RECEBIDOS DO MYSQL E MOSTRAR AO USUÁRIO
                // reader = leitor
                MySqlDataReader dados = cmd.ExecuteReader();

                listagem.Items.Clear();


                while (dados.Read())
                {

                    string[] linha = { dados.GetString(6),
                    dados.GetString(7),
                    dados.GetString(0),
                    dados.GetString(2),
                    dados.GetString(3),
                    dados.GetString(4),
                    dados.GetString(5) };


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
                txtId.Text = item.SubItems[2].Text;
                txtPet.Text = item.SubItems[3].Text;
                cbEspecie.Text = item.SubItems[4].Text;
                cbSexo.Text = item.SubItems[5].Text;
                cbPorte.Text = item.SubItems[6].Text;
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





