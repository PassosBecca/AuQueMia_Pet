namespace AUqueMIA_Pets
{
    partial class frmRelatorio
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
            labelCliente = new Label();
            SuspendLayout();
            // 
            // labelCliente
            // 
            labelCliente.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCliente.ForeColor = Color.Black;
            labelCliente.ImageAlign = ContentAlignment.MiddleLeft;
            labelCliente.Location = new Point(12, 9);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(110, 38);
            labelCliente.TabIndex = 163;
            labelCliente.Text = "RELATÓRIOS";
            labelCliente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmRelatorio
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(608, 346);
            Controls.Add(labelCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRelatorio";
            Text = "Relatorios";
            ResumeLayout(false);
        }

        #endregion

        private Label labelCliente;
    }
}