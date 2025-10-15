namespace AUqueMIA_Pets
{
    partial class Agendamentos
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
            pesquisar=new TextBox();
            pesquisa=new Label();
            listagem=new ListView();
            labelCliente=new Label();
            txtCpf=new TextBox();
            CPF=new Label();
            txtPet=new TextBox();
            nomepet=new Label();
            btNovo=new Button();
            btCancelar=new Button();
            btExcluir=new Button();
            btEditar=new Button();
            btSalvar=new Button();
            cbHorario=new ComboBox();
            cbSemana=new ComboBox();
            cbTosa=new ComboBox();
            cbBanho=new ComboBox();
            label5=new Label();
            label4=new Label();
            label3=new Label();
            label2=new Label();
            idPet=new TextBox();
            label7=new Label();
            txtNome=new TextBox();
            nome=new Label();
            txtAgendamento=new TextBox();
            label1=new Label();
            SuspendLayout();
            // 
            // pesquisar
            // 
            pesquisar.Location=new Point(48, 56);
            pesquisar.Name="pesquisar";
            pesquisar.Size=new Size(111, 23);
            pesquisar.TabIndex=163;
            pesquisar.TabStop=false;
            pesquisar.KeyUp+=pesquisar_KeyUp;
            // 
            // pesquisa
            // 
            pesquisa.AutoSize=true;
            pesquisa.FlatStyle=FlatStyle.Flat;
            pesquisa.ImageAlign=ContentAlignment.MiddleLeft;
            pesquisa.Location=new Point(14, 60);
            pesquisa.Name="pesquisa";
            pesquisa.Size=new Size(28, 15);
            pesquisa.TabIndex=166;
            pesquisa.Text="CPF";
            pesquisa.TextAlign=ContentAlignment.MiddleRight;
            // 
            // listagem
            // 
            listagem.Location=new Point(15, 85);
            listagem.Name="listagem";
            listagem.Size=new Size(295, 113);
            listagem.TabIndex=164;
            listagem.UseCompatibleStateImageBehavior=false;
            listagem.MouseClick+=listagem_MouseClick;
            // 
            // labelCliente
            // 
            labelCliente.Font=new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCliente.ForeColor=Color.Black;
            labelCliente.ImageAlign=ContentAlignment.MiddleLeft;
            labelCliente.Location=new Point(12, 9);
            labelCliente.Name="labelCliente";
            labelCliente.Size=new Size(135, 38);
            labelCliente.TabIndex=162;
            labelCliente.Text="AGENDAMENTO";
            labelCliente.TextAlign=ContentAlignment.MiddleRight;
            // 
            // txtCpf
            // 
            txtCpf.Enabled=false;
            txtCpf.Location=new Point(48, 240);
            txtCpf.Name="txtCpf";
            txtCpf.Size=new Size(240, 23);
            txtCpf.TabIndex=160;
            // 
            // CPF
            // 
            CPF.AutoSize=true;
            CPF.Location=new Point(14, 243);
            CPF.Name="CPF";
            CPF.Size=new Size(28, 15);
            CPF.TabIndex=159;
            CPF.Text="CPF";
            // 
            // txtPet
            // 
            txtPet.Enabled=false;
            txtPet.Location=new Point(469, 122);
            txtPet.Name="txtPet";
            txtPet.Size=new Size(174, 23);
            txtPet.TabIndex=158;
            // 
            // nomepet
            // 
            nomepet.AutoSize=true;
            nomepet.Location=new Point(364, 127);
            nomepet.Name="nomepet";
            nomepet.Size=new Size(98, 15);
            nomepet.TabIndex=157;
            nomepet.Text="Nome do Animal";
            // 
            // btNovo
            // 
            btNovo.BackColor=Color.Tan;
            btNovo.FlatStyle=FlatStyle.System;
            btNovo.ForeColor=Color.Transparent;
            btNovo.Location=new Point(136, 315);
            btNovo.Name="btNovo";
            btNovo.Size=new Size(75, 23);
            btNovo.TabIndex=156;
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
            btCancelar.Location=new Point(311, 315);
            btCancelar.Name="btCancelar";
            btCancelar.Size=new Size(75, 23);
            btCancelar.TabIndex=155;
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
            btExcluir.Location=new Point(475, 315);
            btExcluir.Name="btExcluir";
            btExcluir.Size=new Size(75, 23);
            btExcluir.TabIndex=154;
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
            btEditar.Location=new Point(393, 315);
            btEditar.Name="btEditar";
            btEditar.Size=new Size(75, 23);
            btEditar.TabIndex=153;
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
            btSalvar.Location=new Point(222, 315);
            btSalvar.Name="btSalvar";
            btSalvar.Size=new Size(75, 23);
            btSalvar.TabIndex=152;
            btSalvar.Text="Salvar";
            btSalvar.UseVisualStyleBackColor=false;
            btSalvar.Click+=btSalvar_Click;
            // 
            // cbHorario
            // 
            cbHorario.FormattingEnabled=true;
            cbHorario.Items.AddRange(new object[] { "9h", "10h", "11h", "13h", "14h", "15h", "16h", "17h" });
            cbHorario.Location=new Point(422, 241);
            cbHorario.Name="cbHorario";
            cbHorario.Size=new Size(221, 23);
            cbHorario.TabIndex=151;
            // 
            // cbSemana
            // 
            cbSemana.FormattingEnabled=true;
            cbSemana.Items.AddRange(new object[] { "Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira", "Sábado" });
            cbSemana.Location=new Point(456, 212);
            cbSemana.Name="cbSemana";
            cbSemana.Size=new Size(187, 23);
            cbSemana.TabIndex=150;
            // 
            // cbTosa
            // 
            cbTosa.FormattingEnabled=true;
            cbTosa.Items.AddRange(new object[] { "Não Tosar", "Higiênica", "Da Raça", "Bebê", "Ursinho", "Tesoura", "Máquina", "Leão" });
            cbTosa.Location=new Point(442, 183);
            cbTosa.Name="cbTosa";
            cbTosa.Size=new Size(200, 23);
            cbTosa.TabIndex=149;
            // 
            // cbBanho
            // 
            cbBanho.FormattingEnabled=true;
            cbBanho.Items.AddRange(new object[] { "Simples", "Hidratação", "Terapêutico" });
            cbBanho.Location=new Point(455, 154);
            cbBanho.Name="cbBanho";
            cbBanho.Size=new Size(187, 23);
            cbBanho.TabIndex=148;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(364, 244);
            label5.Name="label5";
            label5.Size=new Size(47, 15);
            label5.TabIndex=147;
            label5.Text="Horário";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(365, 215);
            label4.Name="label4";
            label4.Size=new Size(85, 15);
            label4.TabIndex=146;
            label4.Text="Dia da Semana";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(364, 186);
            label3.Name="label3";
            label3.Size=new Size(77, 15);
            label3.TabIndex=145;
            label3.Text="Tipos de Tosa";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(364, 157);
            label2.Name="label2";
            label2.Size=new Size(88, 15);
            label2.TabIndex=144;
            label2.Text="Tipos de Banho";
            // 
            // idPet
            // 
            idPet.Enabled=false;
            idPet.Location=new Point(456, 89);
            idPet.Name="idPet";
            idPet.Size=new Size(74, 23);
            idPet.TabIndex=168;
            idPet.TabStop=false;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new Point(364, 92);
            label7.Name="label7";
            label7.Size=new Size(83, 15);
            label7.TabIndex=167;
            label7.Text="Código do Pet";
            // 
            // txtNome
            // 
            txtNome.Enabled=false;
            txtNome.Location=new Point(60, 269);
            txtNome.Name="txtNome";
            txtNome.Size=new Size(228, 23);
            txtNome.TabIndex=169;
            // 
            // nome
            // 
            nome.AutoSize=true;
            nome.Location=new Point(14, 272);
            nome.Name="nome";
            nome.Size=new Size(40, 15);
            nome.TabIndex=170;
            nome.Text="Nome";
            // 
            // txtAgendamento
            // 
            txtAgendamento.Enabled=false;
            txtAgendamento.Location=new Point(513, 60);
            txtAgendamento.Name="txtAgendamento";
            txtAgendamento.Size=new Size(75, 23);
            txtAgendamento.TabIndex=174;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(365, 63);
            label1.Name="label1";
            label1.Size=new Size(142, 15);
            label1.TabIndex=173;
            label1.Text="Código do Agendamento";
            // 
            // Agendamentos
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(672, 350);
            Controls.Add(txtAgendamento);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(nome);
            Controls.Add(idPet);
            Controls.Add(label7);
            Controls.Add(pesquisar);
            Controls.Add(pesquisa);
            Controls.Add(listagem);
            Controls.Add(labelCliente);
            Controls.Add(txtCpf);
            Controls.Add(CPF);
            Controls.Add(txtPet);
            Controls.Add(nomepet);
            Controls.Add(btNovo);
            Controls.Add(btCancelar);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btSalvar);
            Controls.Add(cbHorario);
            Controls.Add(cbSemana);
            Controls.Add(cbTosa);
            Controls.Add(cbBanho);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle=FormBorderStyle.None;
            Name="Agendamentos";
            Text="Agendamentos";
            Load+=Agendamentos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pesquisar;
        private Label pesquisa;
        private ListView listagem;
        private Label labelCliente;
        private TextBox txtCpf;
        private Label CPF;
        private TextBox txtPet;
        private Label nomepet;
        private Button btNovo;
        private Button btCancelar;
        private Button btExcluir;
        private Button btEditar;
        private Button btSalvar;
        private ComboBox cbHorario;
        private ComboBox cbSemana;
        private ComboBox cbTosa;
        private ComboBox cbBanho;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox idPet;
        private Label label7;
        private TextBox txtNome;
        private Label nome;
        private TextBox txtAgendamento;
        private Label label1;
    }
}