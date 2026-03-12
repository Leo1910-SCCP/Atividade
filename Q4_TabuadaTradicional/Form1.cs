namespace Q4_TabuadaTradicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {


            int a, n;

            a = Convert.ToInt32(txtNum.Text);

            for (int i = 1; i <= 10; i++)
            {
                n = a * i;

                listTabuada.Items.Add($"{a} X {i} = {n}");
            }
        }

        private void listTabuada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
