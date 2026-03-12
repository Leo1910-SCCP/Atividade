namespace Q4_TabuadaTradicional
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
            components = new System.ComponentModel.Container();
            btnCalculo = new Button();
            txtNum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bindingSource1 = new BindingSource(components);
            listTabuada = new ListBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnCalculo
            // 
            btnCalculo.Location = new Point(324, 144);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(75, 23);
            btnCalculo.TabIndex = 0;
            btnCalculo.Text = "Calcular";
            btnCalculo.UseVisualStyleBackColor = true;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(324, 86);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 58);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 2;
            label1.Text = "Escreva um número inteiro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 31);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Tabuada";
            // 
            // listTabuada
            // 
            listTabuada.FormattingEnabled = true;
            listTabuada.IntegralHeight = false;
            listTabuada.ItemHeight = 15;
            listTabuada.Location = new Point(23, 73);
            listTabuada.Name = "listTabuada";
            listTabuada.Size = new Size(150, 109);
            listTabuada.TabIndex = 3;
            listTabuada.SelectedIndexChanged += listTabuada_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listTabuada);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNum);
            Controls.Add(btnCalculo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculo;
        private TextBox txtNum;
        private Label label1;
        private Label label2;
        private BindingSource bindingSource1;
        public ListBox listTabuada;
    }
}
