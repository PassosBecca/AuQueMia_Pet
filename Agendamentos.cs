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
    public partial class Agendamentos : Form
    {
        MySqlConnection conexao;
        string acao = "";

        public Agendamentos()
        {
            InitializeComponent();
        }

        private void Agendamentos_Load(object sender, EventArgs e)
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
            txtPet.Enabled = true;
            txtAgendamento.Enabled = true;
            txtNome.Enabled = true;
            cbBanho.Enabled = true;
            cbTosa.Enabled = true;
            cbSemana.Enabled = true;
            cbHorario.Enabled = true;
        }

        public void desabilitarCampos()
        {
            txtCpf.Enabled = false;
            txtPet.Enabled = false;
            txtAgendamento.Enabled = false;
            txtNome.Enabled = false;
            cbBanho.Enabled = false;
            cbTosa.Enabled = false;
            cbSemana.Enabled = false;
            cbHorario.Enabled = false;
        }


        public void limparCampos()
        {
            txtCpf.Text = string.Empty;
            txtPet.Text = "";
            txtAgendamento.Text = string.Empty;
            txtNome.Text = "";
            cbBanho.Text = "";
            cbTosa.Text = "";
            cbSemana.Text = "";
            cbHorario.Text = "";
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btNovo.Enabled = true;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            acao = "novo";
            txtPet.Text = "";
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
                "insert into pet (cpf_tutor,nome,idAgendamento,idPet, nome_pet,banho,tosa,semana,horario)" +
                        " values ('" + txtCpf.Text + "','" + txtNome.Text + "','" + txtAgendamento.Text + "','" + idPet.Text + "','" + txtPet.Text + "','" + cbBanho.Text + "','" + cbTosa.Text + "','" + cbSemana.Text +
                        "','" + cbHorario.Text + "')", conexao);


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
                 "insert into pet (cpf_tutor,nome,idAgendamento,idPet, nome_pet,banho,tosa,semana,horario)" +
                        " values ('" + txtCpf.Text + "','" + txtNome.Text + "','" + txtAgendamento.Text + "','" + idPet.Text + "','" + txtPet.Text + "','" + cbBanho.Text + "','" + cbTosa.Text + "','" + cbSemana.Text +
                        "','" + cbHorario.Text + "')", conexao);
            }
            if (acao == "editar")
            {
                MySqlCommand? comando = new MySqlCommand(
                    "update pet set banho='" + cbBanho.Text + "',tosa='" + cbTosa.Text + "',semana='" + cbSemana.Text + "',horario='" + cbHorario.Text +
                    "' where nome = " + txtPet.Text, conexao);
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
            if (cbBanho.Text.Length == 0)
                mensagem += "\nEscolha uma opção.";
            if (cbTosa.Text.Length == 0)
                mensagem += "\nEscolha uma opção.";
            if (cbSemana.Text.Length == 0)
                mensagem += "\nEscolha uma opção.";
            if (cbHorario.Text.Length == 0)
                mensagem += "\nEscolha uma opção.";

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
            txtPet.Enabled = false;
            txtCpf.Enabled = false;
            txtNome.Enabled = false;
            txtAgendamento.Enabled = false;
            idPet.Enabled = false;
            txtPet.Enabled = false;

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
                listagem.Columns.Add("CPF", 80, HorizontalAlignment.Left);
                listagem.Columns.Add("Tutor", 90, HorizontalAlignment.Left);
                listagem.Columns.Add("Id Agendamento", 40, HorizontalAlignment.Left);
                listagem.Columns.Add("Id Pet", 40, HorizontalAlignment.Left);
                listagem.Columns.Add("Pet", 80, HorizontalAlignment.Left);
                listagem.Columns.Add("Banho", 80, HorizontalAlignment.Left);
                listagem.Columns.Add("Tosa", 80, HorizontalAlignment.Left);
                listagem.Columns.Add("Semana", 80, HorizontalAlignment.Left);
                listagem.Columns.Add("Horario", 80, HorizontalAlignment.Left);
                string sql = "SELECT * FROM tutor where nome like '" + pesquisar.Text + "%' order by nome";
                //string sql = "SELECT * FROM tutor, pete, agendamento where pet.cpf_tutor=tutor.cpf and agendamento.idPet=pet.idPet order by cpf";
                MySqlCommand? cmd = new MySqlCommand(sql, conexao);


                MySqlDataReader dados = cmd.ExecuteReader();

                listagem.Items.Clear();


                while (dados.Read())
                {
                    string[] linha = { dados.GetString(0),
                    dados.GetString(1),
                    dados.GetString(2),
                    dados.GetString(2),
                    dados.GetString(2),
                    dados.GetString(2),
                    dados.GetString(3) };


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
                idPet.Text = item.SubItems[2].Text;
                txtPet.Text = item.SubItems[3].Text;
                btEditar.Enabled = true;
                btExcluir.Enabled = true;
                btSalvar.Enabled = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Error:{erro.Message}");
            }
        }
    }
}
