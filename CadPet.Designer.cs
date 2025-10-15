namespace AUqueMIA_Pets
{
    partial class frmPet
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
            label3=new Label();
            txtPet=new TextBox();
            label1=new Label();
            cbPorte=new ComboBox();
            txtId=new TextBox();
            label7=new Label();
            label8=new Label();
            pesquisar=new TextBox();
            pesquisa=new Label();
            btListar=new Button();
            listagem=new ListView();
            txtCpf=new TextBox();
            idcpf=new Label();
            txtNome=new TextBox();
            nome=new Label();
            cbEspecie=new ComboBox();
            label2=new Label();
            cbSexo=new ComboBox();
            label6=new Label();
            btNovo=new Button();
            btCancelar=new Button();
            btExcluir=new Button();
            btEditar=new Button();
            btSalvar=new Button();
            btBuscar=new Button();
            labelCliente=new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(14, 225);
            label3.Name="label3";
            label3.Size=new Size(93, 15);
            label3.TabIndex=19;
            label3.Text="Porte do Animal";
            // 
            // txtPet
            // 
            txtPet.Enabled=false;
            txtPet.Location=new Point(114, 151);
            txtPet.Name="txtPet";
            txtPet.Size=new Size(184, 23);
            txtPet.TabIndex=1;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(12, 157);
            label1.Name="label1";
            label1.Size=new Size(98, 15);
            label1.TabIndex=15;
            label1.Text="Nome do Animal";
            // 
            // cbPorte
            // 
            cbPorte.Enabled=false;
            cbPorte.FormattingEnabled=true;
            cbPorte.Items.AddRange(new object[] { "Pequeno", "Médio", "Grande", "Mini" });
            cbPorte.Location=new Point(117, 218);
            cbPorte.Name="cbPorte";
            cbPorte.Size=new Size(181, 23);
            cbPorte.TabIndex=3;
            // 
            // txtId
            // 
            txtId.Enabled=false;
            txtId.Location=new Point(101, 122);
            txtId.Name="txtId";
            txtId.Size=new Size(74, 23);
            txtId.TabIndex=47;
            txtId.TabStop=false;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new Point(14, 125);
            label7.Name="label7";
            label7.Size=new Size(83, 15);
            label7.TabIndex=46;
            label7.Text="Código do Pet";
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.BackColor=Color.Transparent;
            label8.FlatStyle=FlatStyle.Flat;
            label8.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location=new Point(260, 9);
            label8.Name="label8";
            label8.Size=new Size(0, 15);
            label8.TabIndex=49;
            // 
            // pesquisar
            // 
            pesquisar.Location=new Point(406, 59);
            pesquisar.Name="pesquisar";
            pesquisar.Size=new Size(111, 23);
            pesquisar.TabIndex=93;
            pesquisar.TabStop=false;
            pesquisar.KeyUp+=pesquisar_KeyUp;
            // 
            // pesquisa
            // 
            pesquisa.AutoSize=true;
            pesquisa.FlatStyle=FlatStyle.Flat;
            pesquisa.ImageAlign=ContentAlignment.MiddleLeft;
            pesquisa.Location=new Point(319, 62);
            pesquisa.Name="pesquisa";
            pesquisa.Size=new Size(81, 15);
            pesquisa.TabIndex=92;
            pesquisa.Text="Pesquisar CPF";
            pesquisa.TextAlign=ContentAlignment.MiddleRight;
            // 
            // btListar
            // 
            btListar.BackColor=SystemColors.ControlLight;
            btListar.Font=new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btListar.ImageAlign=ContentAlignment.MiddleLeft;
            btListar.Location=new Point(572, 54);
            btListar.Name="btListar";
            btListar.Size=new Size(76, 24);
            btListar.TabIndex=91;
            btListar.Text="Listar todos";
            btListar.TextAlign=ContentAlignment.MiddleRight;
            btListar.UseVisualStyleBackColor=false;
            btListar.Click+=btListar_Click;
            // 
            // listagem
            // 
            listagem.Location=new Point(319, 88);
            listagem.Name="listagem";
            listagem.Size=new Size(329, 243);
            listagem.TabIndex=90;
            listagem.UseCompatibleStateImageBehavior=false;
            listagem.MouseClick+=listagem_MouseClick;
            // 
            // txtCpf
            // 
            txtCpf.Location=new Point(63, 58);
            txtCpf.Name="txtCpf";
            txtCpf.Size=new Size(91, 23);
            txtCpf.TabIndex=1;
            txtCpf.TabStop=false;
            // 
            // idcpf
            // 
            idcpf.AutoSize=true;
            idcpf.Location=new Point(14, 62);
            idcpf.Name="idcpf";
            idcpf.Size=new Size(41, 15);
            idcpf.TabIndex=84;
            idcpf.Text="id CPF";
            // 
            // txtNome
            // 
            txtNome.Enabled=false;
            txtNome.Location=new Point(58, 88);
            txtNome.Name="txtNome";
            txtNome.Size=new Size(240, 23);
            txtNome.TabIndex=80;
            txtNome.TabStop=false;
            // 
            // nome
            // 
            nome.AutoSize=true;
            nome.Location=new Point(13, 91);
            nome.Name="nome";
            nome.Size=new Size(35, 15);
            nome.TabIndex=79;
            nome.Text="Tutor";
            // 
            // cbEspecie
            // 
            cbEspecie.Enabled=false;
            cbEspecie.FormattingEnabled=true;
            cbEspecie.Items.AddRange(new object[] { "Canino", "Felino" });
            cbEspecie.Location=new Point(63, 185);
            cbEspecie.Name="cbEspecie";
            cbEspecie.Size=new Size(91, 23);
            cbEspecie.TabIndex=2;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(14, 188);
            label2.Name="label2";
            label2.Size=new Size(46, 15);
            label2.TabIndex=94;
            label2.Text="Espécie";
            // 
            // cbSexo
            // 
            cbSexo.Enabled=false;
            cbSexo.FormattingEnabled=true;
            cbSexo.Items.AddRange(new object[] { "Macho", "Fêmea" });
            cbSexo.Location=new Point(195, 185);
            cbSexo.Name="cbSexo";
            cbSexo.Size=new Size(103, 23);
            cbSexo.TabIndex=4;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(160, 188);
            label6.Name="label6";
            label6.Size=new Size(32, 15);
            label6.TabIndex=96;
            label6.Text="Sexo";
            // 
            // btNovo
            // 
            btNovo.BackColor=Color.Tan;
            btNovo.FlatStyle=FlatStyle.System;
            btNovo.ForeColor=Color.LightGray;
            btNovo.Location=new Point(19, 279);
            btNovo.Name="btNovo";
            btNovo.Size=new Size(75, 23);
            btNovo.TabIndex=104;
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
            btCancelar.Location=new Point(185, 279);
            btCancelar.Name="btCancelar";
            btCancelar.Size=new Size(75, 23);
            btCancelar.TabIndex=102;
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
            btExcluir.Location=new Point(145, 308);
            btExcluir.Name="btExcluir";
            btExcluir.Size=new Size(75, 23);
            btExcluir.TabIndex=100;
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
            btEditar.Location=new Point(64, 308);
            btEditar.Name="btEditar";
            btEditar.Size=new Size(75, 23);
            btEditar.TabIndex=99;
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
            btSalvar.Location=new Point(100, 279);
            btSalvar.Name="btSalvar";
            btSalvar.Size=new Size(75, 23);
            btSalvar.TabIndex=98;
            btSalvar.Text="Salvar";
            btSalvar.UseVisualStyleBackColor=false;
            btSalvar.Click+=btSalvar_Click;
            // 
            // btBuscar
            // 
            btBuscar.ImageAlign=ContentAlignment.MiddleLeft;
            btBuscar.Location=new Point(160, 57);
            btBuscar.Name="btBuscar";
            btBuscar.Size=new Size(53, 24);
            btBuscar.TabIndex=88;
            btBuscar.Text="Buscar";
            btBuscar.TextAlign=ContentAlignment.MiddleRight;
            btBuscar.UseVisualStyleBackColor=true;
            btBuscar.Click+=btBuscar_Click;
            // 
            // labelCliente
            // 
            labelCliente.Font=new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCliente.ForeColor=Color.Black;
            labelCliente.ImageAlign=ContentAlignment.MiddleLeft;
            labelCliente.Location=new Point(20, 9);
            labelCliente.Name="labelCliente";
            labelCliente.Size=new Size(152, 38);
            labelCliente.TabIndex=105;
            labelCliente.Text="CADASTRO DE PET";
            labelCliente.TextAlign=ContentAlignment.MiddleRight;
            // 
            // frmPet
            // 
            AutoScaleDimensions=new SizeF(96F, 96F);
            AutoScaleMode=AutoScaleMode.Dpi;
            ClientSize=new Size(672, 350);
            Controls.Add(labelCliente);
            Controls.Add(btNovo);
            Controls.Add(btCancelar);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btSalvar);
            Controls.Add(cbSexo);
            Controls.Add(label6);
            Controls.Add(cbEspecie);
            Controls.Add(label2);
            Controls.Add(pesquisar);
            Controls.Add(pesquisa);
            Controls.Add(btListar);
            Controls.Add(listagem);
            Controls.Add(btBuscar);
            Controls.Add(txtCpf);
            Controls.Add(idcpf);
            Controls.Add(txtNome);
            Controls.Add(nome);
            Controls.Add(label8);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(cbPorte);
            Controls.Add(label3);
            Controls.Add(txtPet);
            Controls.Add(label1);
            FormBorderStyle=FormBorderStyle.None;
            Name="frmPet";
            Text="CadPet";
            Load+=frmPet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox txtPet;
        private Label label1;
        private ComboBox cbPorte;
        private TextBox txtId;
        private Label label7;
        private Label label8;
        private TextBox pesquisar;
        private Label pesquisa;
        private Button btListar;
        private ListView listagem;
        private TextBox txtCpf;
        private Label idcpf;
        private TextBox txtNome;
        private Label nome;
        private ComboBox cbEspecie;
        private Label label2;
        private ComboBox cbSexo;
        private Label label6;
        private Button btNovo;
        private Button btCancelar;
        private Button btExcluir;
        private Button btEditar;
        private Button btSalvar;
        private Button btBuscar;
        private Label labelCliente;
    }
}