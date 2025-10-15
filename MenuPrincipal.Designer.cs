namespace AUqueMIA_Pets
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            panelForm = new Panel();
            label2 = new Label();
            btHome = new Button();
            btCliente = new Button();
            btPet = new Button();
            btRelatorio = new Button();
            btFuncionario = new Button();
            btSair = new Button();
            btAgendamento = new Button();
            painelPrincipal = new Panel();
            panelForm.SuspendLayout();
            painelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelForm
            // 
            panelForm.Controls.Add(label2);
            panelForm.Location = new Point(172, 12);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(672, 393);
            panelForm.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 181);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 0;
            label2.Text = "BEM VINDO";
            // 
            // btHome
            // 
            btHome.BackColor = Color.Transparent;
            btHome.FlatAppearance.BorderSize = 0;
            btHome.FlatAppearance.MouseDownBackColor = Color.Gray;
            btHome.FlatAppearance.MouseOverBackColor = Color.Gray;
            btHome.FlatStyle = FlatStyle.Flat;
            btHome.Image = (Image)resources.GetObject("btHome.Image");
            btHome.ImageAlign = ContentAlignment.MiddleLeft;
            btHome.Location = new Point(3, 32);
            btHome.Name = "btHome";
            btHome.Size = new Size(148, 45);
            btHome.TabIndex = 0;
            btHome.Text = "Pagina Inicial";
            btHome.TextAlign = ContentAlignment.MiddleRight;
            btHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btHome.UseVisualStyleBackColor = false;
            btHome.Click += btHome_Click;
            // 
            // btCliente
            // 
            btCliente.BackColor = Color.Transparent;
            btCliente.FlatAppearance.BorderSize = 0;
            btCliente.FlatAppearance.MouseDownBackColor = Color.Gray;
            btCliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            btCliente.FlatStyle = FlatStyle.Flat;
            btCliente.Image = (Image)resources.GetObject("btCliente.Image");
            btCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btCliente.Location = new Point(3, 83);
            btCliente.Name = "btCliente";
            btCliente.Size = new Size(148, 43);
            btCliente.TabIndex = 1;
            btCliente.Text = "Cadastro Cliente";
            btCliente.TextAlign = ContentAlignment.MiddleRight;
            btCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btCliente.UseVisualStyleBackColor = false;
            btCliente.Click += btCliente_Click;
            // 
            // btPet
            // 
            btPet.BackColor = Color.Transparent;
            btPet.FlatAppearance.BorderSize = 0;
            btPet.FlatAppearance.MouseDownBackColor = Color.Gray;
            btPet.FlatAppearance.MouseOverBackColor = Color.Gray;
            btPet.FlatStyle = FlatStyle.Flat;
            btPet.Image = (Image)resources.GetObject("btPet.Image");
            btPet.ImageAlign = ContentAlignment.MiddleLeft;
            btPet.Location = new Point(3, 132);
            btPet.Name = "btPet";
            btPet.Size = new Size(148, 43);
            btPet.TabIndex = 2;
            btPet.Text = "Cadastro Pet";
            btPet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btPet.UseVisualStyleBackColor = false;
            btPet.Click += btPet_Click;
            // 
            // btRelatorio
            // 
            btRelatorio.BackColor = Color.Transparent;
            btRelatorio.FlatAppearance.BorderSize = 0;
            btRelatorio.FlatAppearance.MouseDownBackColor = Color.Gray;
            btRelatorio.FlatAppearance.MouseOverBackColor = Color.Gray;
            btRelatorio.FlatStyle = FlatStyle.Flat;
            btRelatorio.Image = (Image)resources.GetObject("btRelatorio.Image");
            btRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btRelatorio.Location = new Point(3, 275);
            btRelatorio.Name = "btRelatorio";
            btRelatorio.Size = new Size(148, 39);
            btRelatorio.TabIndex = 5;
            btRelatorio.Text = "Pesquisa";
            btRelatorio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btRelatorio.UseVisualStyleBackColor = false;
            btRelatorio.Click += btRelatorio_Click;
            // 
            // btFuncionario
            // 
            btFuncionario.BackColor = Color.Transparent;
            btFuncionario.FlatAppearance.BorderSize = 0;
            btFuncionario.FlatAppearance.MouseDownBackColor = Color.Gray;
            btFuncionario.FlatAppearance.MouseOverBackColor = Color.Gray;
            btFuncionario.FlatStyle = FlatStyle.Flat;
            btFuncionario.Image = (Image)resources.GetObject("btFuncionario.Image");
            btFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btFuncionario.Location = new Point(3, 224);
            btFuncionario.Name = "btFuncionario";
            btFuncionario.Size = new Size(148, 45);
            btFuncionario.TabIndex = 4;
            btFuncionario.Text = "Funcionários";
            btFuncionario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btFuncionario.UseVisualStyleBackColor = false;
            btFuncionario.Click += button5_Click;
            // 
            // btSair
            // 
            btSair.BackColor = Color.Transparent;
            btSair.FlatAppearance.BorderSize = 0;
            btSair.FlatAppearance.MouseDownBackColor = Color.Gray;
            btSair.FlatAppearance.MouseOverBackColor = Color.Gray;
            btSair.FlatStyle = FlatStyle.Flat;
            btSair.Image = (Image)resources.GetObject("btSair.Image");
            btSair.ImageAlign = ContentAlignment.MiddleLeft;
            btSair.Location = new Point(3, 320);
            btSair.Name = "btSair";
            btSair.Size = new Size(148, 39);
            btSair.TabIndex = 6;
            btSair.Text = "Sair";
            btSair.TextAlign = ContentAlignment.MiddleLeft;
            btSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSair.UseVisualStyleBackColor = false;
            // 
            // btAgendamento
            // 
            btAgendamento.BackColor = Color.Transparent;
            btAgendamento.FlatAppearance.BorderSize = 0;
            btAgendamento.FlatAppearance.MouseDownBackColor = Color.Gray;
            btAgendamento.FlatAppearance.MouseOverBackColor = Color.Gray;
            btAgendamento.FlatStyle = FlatStyle.Flat;
            btAgendamento.Image = (Image)resources.GetObject("btAgendamento.Image");
            btAgendamento.ImageAlign = ContentAlignment.MiddleLeft;
            btAgendamento.Location = new Point(3, 181);
            btAgendamento.Name = "btAgendamento";
            btAgendamento.Size = new Size(148, 43);
            btAgendamento.TabIndex = 7;
            btAgendamento.Text = "Agendamentos";
            btAgendamento.TextImageRelation = TextImageRelation.ImageBeforeText;
            btAgendamento.UseVisualStyleBackColor = false;
            btAgendamento.Click += btAgendamento_Click;
            // 
            // painelPrincipal
            // 
            painelPrincipal.BackColor = SystemColors.ControlDark;
            painelPrincipal.Controls.Add(btAgendamento);
            painelPrincipal.Controls.Add(btSair);
            painelPrincipal.Controls.Add(btFuncionario);
            painelPrincipal.Controls.Add(btRelatorio);
            painelPrincipal.Controls.Add(btPet);
            painelPrincipal.Controls.Add(btCliente);
            painelPrincipal.Controls.Add(btHome);
            painelPrincipal.Location = new Point(12, 12);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(154, 401);
            painelPrincipal.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(857, 417);
            Controls.Add(panelForm);
            Controls.Add(painelPrincipal);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaInicial";
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            painelPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelForm;
        private Button btHome;
        private Button btCliente;
        private Button btPet;
        private Button btRelatorio;
        private Button btFuncionario;
        private Button btSair;
        private Button btAgendamento;
        private Panel painelPrincipal;
        private Label label2;
    }
}