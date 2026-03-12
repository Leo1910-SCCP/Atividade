namespace Q3_PassagemPorDistancia
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
            button1 = new Button();
            label1 = new Label();
            txtKm = new TextBox();
            label2 = new Label();
            LbPreço = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(83, 87);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 0;
            button1.Text = "Ver passagem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 40);
            label1.Name = "label1";
            label1.Size = new Size(207, 15);
            label1.TabIndex = 1;
            label1.Text = "Qual a distância que irá percorrer(KM)";
            // 
            // txtKm
            // 
            txtKm.Location = new Point(83, 58);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(114, 23);
            txtKm.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 126);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Você vai pagar:";
            // 
            // LbPreço
            // 
            LbPreço.AutoSize = true;
            LbPreço.Location = new Point(141, 126);
            LbPreço.Name = "LbPreço";
            LbPreço.Size = new Size(86, 15);
            LbPreço.TabIndex = 1;
            LbPreço.Text = "Você vai pagar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtKm);
            Controls.Add(LbPreço);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtKm;
        private Label label2;
        private Label LbPreço;
    }
}
