namespace Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConversor_Click(object sender, EventArgs e)
        {
            double reais;

            reais = Convert.ToDouble(txtCotacao.Text) * Convert.ToDouble(txtDolar.Text);

            txtReais.Text ="R$"+ reais.ToString();
        }
    }
}
