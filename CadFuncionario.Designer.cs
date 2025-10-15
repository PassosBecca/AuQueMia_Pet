namespace AUqueMIA_Pets
{
    partial class frmFuncionario
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
            funcao = new Label();
            btExcluir = new Button();
            btEditar = new Button();
            btSalvar = new Button();
            txtTelefone = new TextBox();
            telefone = new Label();
            txtCpf = new TextBox();
            cpf = new Label();
            txtNome = new TextBox();
            nome = new Label();
            txtId = new TextBox();
            id = new Label();
            labelCliente = new Label();
            btCancelar = new Button();
            btBuscar = new Button();
            btNovo = new Button();
            pesquisar = new TextBox();
            pesquisa = new Label();
            btListar = new Button();
            listagem = new ListView();
            cbFuncao = new ComboBox();
            SuspendLayout();
            // 
            // funcao
            // 
            funcao.AutoSize = true;
            funcao.Location = new Point(11, 215);
            funcao.Name = "funcao";
            funcao.Size = new Size(46, 15);
            funcao.TabIndex = 40;
            funcao.Text = "Função";
            // 
            // btExcluir
            // 
            btExcluir.BackColor = Color.Wheat;
            btExcluir.Enabled = false;
            btExcluir.FlatAppearance.BorderSize = 0;
            btExcluir.FlatStyle = FlatStyle.System;
            btExcluir.ForeColor = SystemColors.ControlText;
            btExcluir.Location = new Point(137, 306);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 23);
            btExcluir.TabIndex = 39;
            btExcluir.TabStop = false;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            btExcluir.Click += btExcluir_Click;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.Wheat;
            btEditar.Enabled = false;
            btEditar.FlatAppearance.BorderSize = 0;
            btEditar.FlatStyle = FlatStyle.System;
            btEditar.ForeColor = SystemColors.ControlText;
            btEditar.Location = new Point(56, 306);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(75, 23);
            btEditar.TabIndex = 38;
            btEditar.TabStop = false;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = false;
            btEditar.Click += btEditar_Click;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = SystemColors.Control;
            btSalvar.Enabled = false;
            btSalvar.FlatStyle = FlatStyle.System;
            btSalvar.ForeColor = SystemColors.ControlText;
            btSalvar.Location = new Point(95, 277);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 37;
            btSalvar.TabStop = false;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Enabled = false;
            txtTelefone.Location = new Point(152, 180);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(123, 23);
            txtTelefone.TabIndex = 34;
            // 
            // telefone
            // 
            telefone.AutoSize = true;
            telefone.Location = new Point(152, 162);
            telefone.Name = "telefone";
            telefone.Size = new Size(51, 15);
            telefone.TabIndex = 33;
            telefone.Text = "Telefone";
            // 
            // txtCpf
            // 
            txtCpf.Enabled = false;
            txtCpf.Location = new Point(11, 180);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(120, 23);
            txtCpf.TabIndex = 32;
            // 
            // cpf
            // 
            cpf.AutoSize = true;
            cpf.Location = new Point(11, 162);
            cpf.Name = "cpf";
            cpf.Size = new Size(28, 15);
            cpf.TabIndex = 31;
            cpf.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Location = new Point(56, 121);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(218, 23);
            txtNome.TabIndex = 30;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(10, 124);
            nome.Name = "nome";
            nome.Size = new Size(40, 15);
            nome.TabIndex = 29;
            nome.Text = "Nome";
            // 
            // txtId
            // 
            txtId.Location = new Point(39, 74);
            txtId.Name = "txtId";
            txtId.Size = new Size(75, 23);
            txtId.TabIndex = 45;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(16, 77);
            id.Name = "id";
            id.Size = new Size(17, 15);
            id.TabIndex = 44;
            id.Text = "id";
            // 
            // labelCliente
            // 
            labelCliente.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCliente.ForeColor = Color.Black;
            labelCliente.ImageAlign = ContentAlignment.MiddleLeft;
            labelCliente.Location = new Point(11, 9);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(234, 38);
            labelCliente.TabIndex = 46;
            labelCliente.Text = "CADASTRO DE FUNCIONÁRIO";
            labelCliente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = SystemColors.Control;
            btCancelar.Enabled = false;
            btCancelar.FlatStyle = FlatStyle.System;
            btCancelar.ForeColor = SystemColors.ControlText;
            btCancelar.Location = new Point(185, 277);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 48;
            btCancelar.TabStop = false;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // btBuscar
            // 
            btBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btBuscar.Location = new Point(120, 74);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(58, 24);
            btBuscar.TabIndex = 49;
            btBuscar.TabStop = false;
            btBuscar.Text = "Buscar";
            btBuscar.TextAlign = ContentAlignment.MiddleRight;
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // btNovo
            // 
            btNovo.BackColor = SystemColors.ControlDark;
            btNovo.FlatStyle = FlatStyle.System;
            btNovo.ForeColor = Color.Transparent;
            btNovo.Location = new Point(11, 277);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(75, 23);
            btNovo.TabIndex = 52;
            btNovo.TabStop = false;
            btNovo.Text = "NOVO";
            btNovo.UseVisualStyleBackColor = false;
            btNovo.Click += btNovo_Click_1;
            // 
            // pesquisar
            // 
            pesquisar.Location = new Point(351, 72);
            pesquisar.Name = "pesquisar";
            pesquisar.Size = new Size(110, 23);
            pesquisar.TabIndex = 56;
            pesquisar.TabStop = false;
            pesquisar.KeyUp += pesquisar_KeyUp;
            // 
            // pesquisa
            // 
            pesquisa.AutoSize = true;
            pesquisa.FlatStyle = FlatStyle.Flat;
            pesquisa.ImageAlign = ContentAlignment.MiddleLeft;
            pesquisa.Location = new Point(292, 77);
            pesquisa.Name = "pesquisa";
            pesquisa.Size = new Size(53, 15);
            pesquisa.TabIndex = 55;
            pesquisa.Text = "Pesquisa";
            pesquisa.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btListar
            // 
            btListar.BackColor = SystemColors.ControlLight;
            btListar.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btListar.ImageAlign = ContentAlignment.MiddleLeft;
            btListar.Location = new Point(578, 68);
            btListar.Name = "btListar";
            btListar.Size = new Size(77, 24);
            btListar.TabIndex = 54;
            btListar.TabStop = false;
            btListar.Text = "Listar todos";
            btListar.TextAlign = ContentAlignment.MiddleRight;
            btListar.UseVisualStyleBackColor = false;
            btListar.Click += btListar_Click;
            // 
            // listagem
            // 
            listagem.Location = new Point(292, 101);
            listagem.Name = "listagem";
            listagem.Size = new Size(363, 228);
            listagem.TabIndex = 53;
            listagem.UseCompatibleStateImageBehavior = false;
            listagem.MouseClick += listagem_MouseClick;
            // 
            // cbFuncao
            // 
            cbFuncao.Enabled = false;
            cbFuncao.FormattingEnabled = true;
            cbFuncao.Items.AddRange(new object[] { "Banhista", "Tosador" });
            cbFuncao.Location = new Point(11, 233);
            cbFuncao.Name = "cbFuncao";
            cbFuncao.Size = new Size(139, 23);
            cbFuncao.TabIndex = 50;
            // 
            // frmFuncionario
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(672, 350);
            Controls.Add(pesquisar);
            Controls.Add(pesquisa);
            Controls.Add(btListar);
            Controls.Add(listagem);
            Controls.Add(btNovo);
            Controls.Add(cbFuncao);
            Controls.Add(btBuscar);
            Controls.Add(btCancelar);
            Controls.Add(labelCliente);
            Controls.Add(txtId);
            Controls.Add(id);
            Controls.Add(funcao);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(telefone);
            Controls.Add(txtCpf);
            Controls.Add(cpf);
            Controls.Add(txtNome);
            Controls.Add(nome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFuncionario";
            Text = "Cadastro de Funcionário";
            Load += frmFuncionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label funcao;
        private Button btExcluir;
        private Button btEditar;
        private Button btSalvar;
        private TextBox txtTelefone;
        private Label telefone;
        private TextBox txtCpf;
        private Label cpf;
        private TextBox txtNome;
        private Label nome;
        private TextBox txtId;
        private Label id;
        private Label labelCliente;
        private Button btCancelar;
        private Button btBuscar;
        private Button btNovo;
        private TextBox pesquisar;
        private Label pesquisa;
        private Button btListar;
        private ListView listagem;
        private ComboBox cbFuncao;
    }
}