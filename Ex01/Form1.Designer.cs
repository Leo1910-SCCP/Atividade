namespace Ex01
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
            LbResultado = new Label();
            txtCelsius = new TextBox();
            label2 = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(140, 124);
            button1.Name = "button1";
            button1.Size = new Size(90, 29);
            button1.TabIndex = 0;
            button1.Text = "Converter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LbResultado
            // 
            LbResultado.AutoSize = true;
            LbResultado.Location = new Point(207, 66);
            LbResultado.Name = "LbResultado";
            LbResultado.Size = new Size(63, 15);
            LbResultado.TabIndex = 1;
            LbResultado.Text = "Fahrenheit";
            LbResultado.Click += label1_Click;
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(86, 95);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(90, 23);
            txtCelsius.TabIndex = 2;
            txtCelsius.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 66);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Celsius (°C)";
            label2.Click += label2_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.Window;
            txtResultado.Location = new Point(197, 95);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(90, 23);
            txtResultado.TabIndex = 2;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 249);
            Controls.Add(txtResultado);
            Controls.Add(txtCelsius);
            Controls.Add(label2);
            Controls.Add(LbResultado);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label LbResultado;
        private TextBox txtCelsius;
        private Label label2;
        private TextBox txtResultado;
    }
}
