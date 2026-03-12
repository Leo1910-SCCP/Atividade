namespace Ex02
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
            txtCotacao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDolar = new TextBox();
            label3 = new Label();
            txtReais = new TextBox();
            btnConversor = new Button();
            SuspendLayout();
            // 
            // txtCotacao
            // 
            txtCotacao.Location = new Point(88, 65);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(100, 23);
            txtCotacao.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 47);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 1;
            label1.Text = "Qual a cotação do dólar?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 47);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantos dólares você tem?";
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(276, 65);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(100, 23);
            txtDolar.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 109);
            label3.Name = "label3";
            label3.Size = new Size(164, 15);
            label3.TabIndex = 1;
            label3.Text = "O valor convertido em reais é:";
            // 
            // txtReais
            // 
            txtReais.Location = new Point(276, 140);
            txtReais.Name = "txtReais";
            txtReais.ReadOnly = true;
            txtReais.Size = new Size(100, 23);
            txtReais.TabIndex = 0;
            // 
            // btnConversor
            // 
            btnConversor.Location = new Point(99, 120);
            btnConversor.Name = "btnConversor";
            btnConversor.Size = new Size(75, 23);
            btnConversor.TabIndex = 2;
            btnConversor.Text = "Converter";
            btnConversor.UseVisualStyleBackColor = true;
            btnConversor.Click += btnConversor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 450);
            Controls.Add(btnConversor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtReais);
            Controls.Add(txtDolar);
            Controls.Add(txtCotacao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCotacao;
        private Label label1;
        private Label label2;
        private TextBox txtDolar;
        private Label label3;
        private TextBox txtReais;
        private Button btnConversor;
    }
}
