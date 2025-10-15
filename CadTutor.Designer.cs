namespace AUqueMIA_Pets
{
    partial class frmTutor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pesquisar=new TextBox();
            pesquisa=new Label();
            btListar=new Button();
            listagem=new ListView();
            btNovo=new Button();
            btCancelar=new Button();
            btExcluir=new Button();
            btEditar=new Button();
            btSalvar=new Button();
            txtTelefone=new TextBox();
            telefone=new Label();
            txtCpf=new TextBox();
            cpf=new Label();
            txtNome=new TextBox();
            nome=new Label();
            txtEndereco=new TextBox();
            endereco=new Label();
            labelCliente=new Label();
            txtId=new TextBox();
            id=new Label();
            btBuscar=new Button();
            SuspendLayout();
            // 
            // pesquisar
            // 
            pesquisar.Location=new Point(368, 54);
            pesquisar.Name="pesquisar";
            pesquisar.Size=new Size(111, 23);
            pesquisar.TabIndex=6;
            pesquisar.TabStop=false;
            pesquisar.KeyUp+=pesquisar_KeyUp;
            // 
            // pesquisa
            // 
            pesquisa.AutoSize=true;
            pesquisa.FlatStyle=FlatStyle.Flat;
            pesquisa.ImageAlign=ContentAlignment.MiddleLeft;
            pesquisa.Location=new Point(305, 59);
            pesquisa.Name="pesquisa";
            pesquisa.Size=new Size(57, 15);
            pesquisa.TabIndex=77;
            pesquisa.Text="Pesquisar";
            pesquisa.TextAlign=ContentAlignment.MiddleRight;
            // 
            // btListar
            // 
            btListar.BackColor=SystemColors.ControlLight;
            btListar.Font=new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btListar.ImageAlign=ContentAlignment.MiddleLeft;
            btListar.Location=new Point(574, 50);
            btListar.Name="btListar";
            btListar.Size=new Size(74, 24);
            btListar.TabIndex=76;
            btListar.TabStop=false;
            btListar.Text="Listar todos";
            btListar.TextAlign=ContentAlignment.MiddleRight;
            btListar.UseVisualStyleBackColor=false;
            btListar.Click+=btListar_Click;
            // 
            // listagem
            // 
            listagem.Location=new Point(305, 83);
            listagem.Name="listagem";
            listagem.Size=new Size(343, 247);
            listagem.TabIndex=75;
            listagem.UseCompatibleStateImageBehavior=false;
            listagem.MouseClick+=listagem_MouseClick;
            // 
            // btNovo
            // 
            btNovo.BackColor=Color.Tan;
            btNovo.FlatStyle=FlatStyle.System;
            btNovo.ForeColor=Color.Transparent;
            btNovo.Location=new Point(25, 278);
            btNovo.Name="btNovo";
            btNovo.Size=new Size(75, 23);
            btNovo.TabIndex=74;
            btNovo.TabStop=false;
            btNovo.Text="NOVO";
            btNovo.UseVisualStyleBackColor=false;
            btNovo.Click+=btNovo_Click;
            // 
            // btCancelar
            // 
            btCancelar.BackColor=SystemColors.Control;
            btCancelar.Enabled=false;
            btCancelar.FlatStyle=FlatStyle.System;
            btCancelar.ForeColor=SystemColors.ControlText;
            btCancelar.Location=new Point(187, 278);
            btCancelar.Name="btCancelar";
            btCancelar.Size=new Size(75, 23);
            btCancelar.TabIndex=70;
            btCancelar.TabStop=false;
            btCancelar.Text="Cancelar";
            btCancelar.UseVisualStyleBackColor=false;
            btCancelar.Click+=btCancelar_Click;
            // 
            // btExcluir
            // 
            btExcluir.BackColor=Color.Wheat;
            btExcluir.Enabled=false;
            btExcluir.FlatAppearance.BorderSize=0;
            btExcluir.FlatStyle=FlatStyle.System;
            btExcluir.ForeColor=SystemColors.ControlText;
            btExcluir.Location=new Point(154, 307);
            btExcluir.Name="btExcluir";
            btExcluir.Size=new Size(75, 23);
            btExcluir.TabIndex=65;
            btExcluir.TabStop=false;
            btExcluir.Text="Excluir";
            btExcluir.UseVisualStyleBackColor=false;
            btExcluir.Click+=btExcluir_Click;
            // 
            // btEditar
            // 
            btEditar.BackColor=Color.Wheat;
            btEditar.Enabled=false;
            btEditar.FlatAppearance.BorderSize=0;
            btEditar.FlatStyle=FlatStyle.System;
            btEditar.ForeColor=SystemColors.ControlText;
            btEditar.Location=new Point(73, 307);
            btEditar.Name="btEditar";
            btEditar.Size=new Size(75, 23);
            btEditar.TabIndex=64;
            btEditar.TabStop=false;
            btEditar.Text="Editar";
            btEditar.UseVisualStyleBackColor=false;
            btEditar.Click+=btEditar_Click;
            // 
            // btSalvar
            // 
            btSalvar.BackColor=SystemColors.Control;
            btSalvar.Enabled=false;
            btSalvar.FlatStyle=FlatStyle.System;
            btSalvar.ForeColor=SystemColors.ControlText;
            btSalvar.Location=new Point(106, 278);
            btSalvar.Name="btSalvar";
            btSalvar.Size=new Size(75, 23);
            btSalvar.TabIndex=63;
            btSalvar.TabStop=false;
            btSalvar.Text="Salvar";
            btSalvar.UseVisualStyleBackColor=false;
            btSalvar.Click+=btSalvar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Enabled=false;
            txtTelefone.Location=new Point(73, 192);
            txtTelefone.Name="txtTelefone";
            txtTelefone.Size=new Size(212, 23);
            txtTelefone.TabIndex=5;
            // 
            // telefone
            // 
            telefone.AutoSize=true;
            telefone.Location=new Point(11, 195);
            telefone.Name="telefone";
            telefone.Size=new Size(51, 15);
            telefone.TabIndex=61;
            telefone.Text="Telefone";
            // 
            // txtCpf
            // 
            txtCpf.Enabled=false;
            txtCpf.Location=new Point(42, 103);
            txtCpf.Name="txtCpf";
            txtCpf.Size=new Size(243, 23);
            txtCpf.TabIndex=1;
            // 
            // cpf
            // 
            cpf.AutoSize=true;
            cpf.Location=new Point(11, 106);
            cpf.Name="cpf";
            cpf.Size=new Size(28, 15);
            cpf.TabIndex=59;
            cpf.Text="CPF";
            // 
            // txtNome
            // 
            txtNome.Enabled=false;
            txtNome.Location=new Point(57, 133);
            txtNome.Name="txtNome";
            txtNome.Size=new Size(228, 23);
            txtNome.TabIndex=2;
            // 
            // nome
            // 
            nome.AutoSize=true;
            nome.Location=new Point(11, 136);
            nome.Name="nome";
            nome.Size=new Size(40, 15);
            nome.TabIndex=57;
            nome.Text="Nome";
            // 
            // txtEndereco
            // 
            txtEndereco.Enabled=false;
            txtEndereco.Location=new Point(73, 163);
            txtEndereco.Name="txtEndereco";
            txtEndereco.Size=new Size(212, 23);
            txtEndereco.TabIndex=3;
            // 
            // endereco
            // 
            endereco.AutoSize=true;
            endereco.Location=new Point(11, 166);
            endereco.Name="endereco";
            endereco.Size=new Size(56, 15);
            endereco.TabIndex=79;
            endereco.Text="Endereço";
            // 
            // labelCliente
            // 
            labelCliente.Font=new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCliente.ForeColor=Color.Black;
            labelCliente.ImageAlign=ContentAlignment.MiddleLeft;
            labelCliente.Location=new Point(12, 9);
            labelCliente.Name="labelCliente";
            labelCliente.Size=new Size(183, 38);
            labelCliente.TabIndex=82;
            labelCliente.Text="CADASTRO DE TUTOR";
            labelCliente.TextAlign=ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            txtId.Location=new Point(36, 74);
            txtId.Name="txtId";
            txtId.Size=new Size(75, 23);
            txtId.TabIndex=84;
            // 
            // id
            // 
            id.AutoSize=true;
            id.Location=new Point(10, 77);
            id.Name="id";
            id.Size=new Size(20, 15);
            id.TabIndex=83;
            id.Text="id ";
            // 
            // btBuscar
            // 
            btBuscar.ImageAlign=ContentAlignment.MiddleLeft;
            btBuscar.Location=new Point(117, 73);
            btBuscar.Name="btBuscar";
            btBuscar.Size=new Size(74, 24);
            btBuscar.TabIndex=89;
            btBuscar.Text="Buscar CPF";
            btBuscar.TextAlign=ContentAlignment.MiddleRight;
            btBuscar.UseVisualStyleBackColor=true;
            btBuscar.Click+=btBuscar_Click_1;
            // 
            // frmTutor
            // 
            AutoScaleDimensions=new SizeF(96F, 96F);
            AutoScaleMode=AutoScaleMode.Dpi;
            ClientSize=new Size(672, 350);
            Controls.Add(btBuscar);
            Controls.Add(txtId);
            Controls.Add(id);
            Controls.Add(labelCliente);
            Controls.Add(txtEndereco);
            Controls.Add(endereco);
            Controls.Add(pesquisar);
            Controls.Add(pesquisa);
            Controls.Add(btListar);
            Controls.Add(listagem);
            Controls.Add(btNovo);
            Controls.Add(btCancelar);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(telefone);
            Controls.Add(txtCpf);
            Controls.Add(cpf);
            Controls.Add(txtNome);
            Controls.Add(nome);
            FormBorderStyle=FormBorderStyle.None;
            Name="frmTutor";
            Text="Cadastro Tutor";
            Load+=frmTutor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pesquisar;
        private Label pesquisa;
        private Button btListar;
        private ListView listagem;
        private Button btNovo;
        private Button btCancelar;
        private Button btExcluir;
        private Button btEditar;
        private Button btSalvar;
        private TextBox txtTelefone;
        private Label telefone;
        private TextBox txtCpf;
        private Label cpf;
        private TextBox txtNome;
        private Label nome;
        private TextBox txtEndereco;
        private Label endereco;
        private Label labelCliente;
        private TextBox txtId;
        private Label id;
        private Button btBuscar;
    }
}