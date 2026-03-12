namespace Q5_CadastroSimples
{
    partial class Form1
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
            btnCadastro = new Button();
            TxtNome = new TextBox();
            ListaDados = new ListBox();
            txtIdade = new TextBox();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(115, 95);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(75, 23);
            btnCadastro.TabIndex = 0;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += button1_Click;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(32, 37);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(100, 23);
            TxtNome.TabIndex = 1;
            // 
            // ListaDados
            // 
            ListaDados.FormattingEnabled = true;
            ListaDados.IntegralHeight = false;
            ListaDados.ItemHeight = 15;
            ListaDados.Location = new Point(339, 55);
            ListaDados.Name = "ListaDados";
            ListaDados.Size = new Size(256, 145);
            ListaDados.TabIndex = 2;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(178, 37);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListaDados);
            Controls.Add(txtIdade);
            Controls.Add(TxtNome);
            Controls.Add(btnCadastro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastro;
        private TextBox TxtNome;
        public ListBox ListaDados;
        private TextBox txtIdade;
    }
}
