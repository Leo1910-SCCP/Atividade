namespace Q3_PassagemPorDistancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double km;

            km = Convert.ToDouble(txtKm.Text);
            if (km > 200)
            {
                km = km * 0.45;
                
            }
            else
            {
                km = km * 0.50;
            }

            LbPreço.Text = Convert.ToString(km)+"R$";
        }
    }
}
