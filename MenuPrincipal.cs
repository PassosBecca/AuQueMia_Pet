using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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

    public partial class MenuPrincipal : Form
    {
        //MySqlConection conexao;
        private Form frmAtivo;


        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in painelPrincipal.Controls)
                ctrl.ForeColor = Color.White;
            frmAtivo.ForeColor = Color.Black;
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btHome);
            ActiveFormClose();
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            ActiveButton(btCliente);
            FormShow(new frmTutor());
        }

        private void btPet_Click(object sender, EventArgs e)
        {
            ActiveButton(btPet);
            FormShow(new frmPet());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActiveButton(btFuncionario);
            FormShow(new frmFuncionario());
        }

        private void btAgendamento_Click(object sender, EventArgs e)
        {
            ActiveButton(btAgendamento);
            FormShow(new Agendamentos());
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            ActiveButton(btRelatorio);
            FormShow(new frmRelatorio());
        }
    }
}
