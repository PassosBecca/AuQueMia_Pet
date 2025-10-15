namespace AUqueMIA_Pets
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            pictureBox1 = new PictureBox();
            usuario = new Label();
            txtUser = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            btEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.BackColor = Color.Transparent;
            usuario.FlatStyle = FlatStyle.Flat;
            usuario.Location = new Point(66, 323);
            usuario.Name = "usuario";
            usuario.Size = new Size(47, 15);
            usuario.TabIndex = 1;
            usuario.Text = "Usuário";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(119, 320);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(144, 23);
            txtUser.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(119, 349);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(144, 23);
            txtSenha.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 349);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // btEntrar
            // 
            btEntrar.BackColor = Color.FromArgb(192, 64, 0);
            btEntrar.FlatAppearance.BorderColor = Color.Ivory;
            btEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btEntrar.FlatStyle = FlatStyle.Flat;
            btEntrar.ForeColor = Color.White;
            btEntrar.Location = new Point(174, 378);
            btEntrar.Name = "btEntrar";
            btEntrar.Size = new Size(89, 23);
            btEntrar.TabIndex = 5;
            btEntrar.Text = "Entrar";
            btEntrar.UseVisualStyleBackColor = false;
            btEntrar.Click += btEntrar_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(330, 465);
            AutoSize = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(341, 454);
            Controls.Add(usuario);
            Controls.Add(btEntrar);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AUqueMIA - Sistema de Gestão";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label usuario;
        private TextBox txtUser;
        private TextBox txtSenha;
        private Label label2;
        private Button btEntrar;
    }
}