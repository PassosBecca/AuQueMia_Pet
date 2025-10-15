using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AUqueMIA_Pets
{
    public partial class TelaLogin : Form
    {


        public TelaLogin()
        {
            InitializeComponent();
        }


        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtSenha.Text == "admin")
            {
                MessageBox.Show("Bem vindo ao Sistema!");
                //this.Hide();
                new MenuPrincipal().Show();
            }


            else
            {
                MessageBox.Show("Usuário ou Senha inválidos!");
            }
        }
    }

}
